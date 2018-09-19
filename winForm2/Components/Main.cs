using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;
using Emotions.Gamification;
using DevExpress.XtraEditors;
using Emotions.Printing;

namespace Emotions.Components
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }


        public void Initialize(SettingsInfo dataSettings)
        {
            this.InitializeCamera();
            coreRecal = new CoreRecalc(dataSettings);
            coreRecal.ImageProcessingFinished += ImageProcessingFinished;
            StartProgressAnimation();
            DataSettings = dataSettings;
            photoStripListBindingSource.DataSource = game.PhotoStripList;
        }


        #region Variables

        BindigListData actualPersons = new BindigListData();
        Camera myCamera = new Camera();
        Image _lastImage = null;
        GamificationService game = new GamificationService();
        Timer TimerAnimation = new Timer();
        Timer TimerEmotion = new Timer();
        Boolean IsActiveEmotionGame = true;
        SettingsInfo DataSettings;
        CoreRecalc coreRecal;

        #endregion

        private void ImageProcessingFinished(object sender, IList<Person> e)
        {
            var process = (sender as Image).Clone() as Image;
            game.ProcessEmotions(e, process);
            RefreshGameEmotionText();
            RefreshPictures();
        }


        #region Camera


        private void InitializeCamera()
        {
            this.GetInfo();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;

            TimerEmotion.Interval = 400;
            TimerEmotion.Tick += TimerEmotion_Tick;
            StartTimerEmotion();
        }


        private void GetInfo()
        {
            myCamera.ChangeCamera(0);
            myCamera.Start(0);
        }

        public Camera GetCamera()
        {
            return myCamera;
        }


        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            var img = e.GetFrame();
            _lastImage = img;
        }

        private async void TimerEmotion_Tick(object sender, EventArgs e)
        {
            await CreateImage();
        }

        private void UpdateCameraImage()
        {
            if (!(_lastImage is null))
            {
                var pic = pictureEdit1;
                var image = _lastImage.Clone() as Image;
                var zoom = Math.Max(100 * pic.Width / image.Width, 100 * pic.Height / image.Height);

                pic.Properties.ZoomPercent = zoom;
                pic.Image = image;
            }
        }        


        private async Task CreateImage()
        {
            if (!(_lastImage is null) && IsActiveEmotionGame)
            {
                // musim tu naklonovat obrazok lebo to ide do ineho vlakna
                Image processImage = _lastImage.Clone() as Image;
                string result = await coreRecal.RecalcImage(processImage, actualPersons);
                // ked pushnes formular, tak to vypysem do nejakeho labla v pravom panely, aby sme vedeli co sa deje...
            }
        }

        #endregion


        #region "Progressbar"

        private void StartProgressAnimation()
        {
            TimerAnimation.Tick += Animate;
            TimerAnimation.Interval = 50;
            TimerAnimation.Start();
        }

        private void Animate(object sender, EventArgs e)
        {
            UpdateCameraImage();
            AnimateProgressEmotion(prgAnger, game.Anger);
            AnimateProgressEmotion(prgDisgust, game.Disgust);
            AnimateProgressEmotion(prgHappines, game.Happiness);
            AnimateProgressEmotion(prgNeutral, game.Neutral);
            AnimateProgressEmotion(prgSadness, game.Sadness);
            AnimateProgressEmotion(prgSurprise, game.Surprise);
        }

        private void AnimateProgressEmotion(ProgressBarControl prg, int target)
        {
            //prg.Position = target;
            int step = Math.Abs((prg.Position - target) / 2);
            int actual = prg.Position;
            if (actual != target)
            {
                if (Math.Abs(actual - target) < 5)
                {
                    prg.Position = target;
                }
                else if (actual < target)
                {
                    prg.Position += step;
                }
                else
                {
                    prg.Position -= step;
                }
            }
        }

        private void RefreshGameEmotionText()
        {
            var str = game.GetGameEmotionText();
            if (!lblTitle.Text.Equals(str))
            {
                lblTitle.Text = str;
            }
        }


        private void RefreshPictures()
        {
            SetPicture(picHappiness, game.PhotoStripList.Last.Photo1);
            SetPicture(picAnger, game.PhotoStripList.Last.Photo2);
            SetPicture(picSadness, game.PhotoStripList.Last.Photo3);
            SetPicture(picSurprise, game.PhotoStripList.Last.Photo4);
            SetPicture(picDisgust, game.PhotoStripList.Last.Photo5);
        }

        private void ClearPictures()
        {
            ClearPicture(picHappiness);
            ClearPicture(picAnger);
            ClearPicture(picSadness);
            ClearPicture(picSurprise);
            ClearPicture(picDisgust);
        }

        private void SetPicture(PictureEdit pic, Image image)
        {
            if (!(image is null) && pic.Image is null) {
                pic.Image = image;
                pic.Height = 145;
            }
        }

        private void ClearPicture(PictureEdit pic)
        {
            pic.Image = null;
            pic.Height = 0;
        }


        #endregion

    


        public void CameraStop()
        {
            myCamera.Stop();
        }


        public void StartClick()
        {
            ClearPictures();
            StartTimerEmotion();
            game.NewRound();
        }


        public void ResetClick()
        {
            ClearPictures();
            StartTimerEmotion();
            game.ResetRound();
        }

        public void StopClick()
        {
            StopTimerEmotion();
            game.Stop();
            RefreshGameEmotionText();
        }


        public void PrintClick()
        {
            PrintingService.Print(game.PhotoStripList);
        }

        public void ClearClick()
        {
            game.NewGame();
        }

        /// <summary>
        /// 
        /// </summary>
        private void StartTimerEmotion()
        {
            IsActiveEmotionGame = true;
            TimerEmotion.Start();
        }

        private void StopTimerEmotion()
        {
            IsActiveEmotionGame = false;
            TimerEmotion.Stop();
        }
    }
}
