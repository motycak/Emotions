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
using System.Threading;

namespace Emotions.Components
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }


        public void Initialize()
        {
            this.InitializeCamera();
            coreRecal.ImageProcessingFinished += ImageProcessingFinished;
            StartProgressAnimation();
        }


        #region Variables

        BindigListData actualPersons = new BindigListData();
        Camera myCamera = new Camera();
        CoreRecalc coreRecal = new CoreRecalc();
        Image _lastImage = null;
        GamificationService game = new GamificationService();
        System.Windows.Forms.Timer TimerProgress = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer TimerEmotion = new System.Windows.Forms.Timer();
        Boolean IsActiveEmotionGame = true;


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



            //this.cmbCameras.SelectedIndex = 0;
            //this.cmbResolutions.SelectedIndex = 0;
        }


        private void SetSettingsInfo()
        {
            //var cameraDevices = myCamera.GetCameraSources();
            //var cameraResolutions = myCamera.GetSupportedResolutions();

            //foreach (var d in cameraDevices)
            //    this.cmbCameras.Properties.Items.Add(d);

            //foreach (var r in cameraResolutions)
            //    this.cmbResolutions.Properties.Items.Add(r);
        }


        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            var img = e.GetFrame();
            ShowCameraImage(img.Clone() as Image);
            _lastImage = img;
        }

        private void TimerEmotion_Tick(object sender, EventArgs e)
        {
            CreateImage();
        }

        private void ShowCameraImage(Image image)
        {
            this.pictureBox.Image = image;
        }

        //private void cmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    myCamera.ChangeCamera(this.cmbCameras.SelectedIndex);
        //}


        //private void cmbResolutions_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    myCamera.Start(cmbResolutions.SelectedIndex);
        //}


        private void CreateImage()
        {
            if (!(_lastImage is null) && IsActiveEmotionGame)
            {
                // musim tu naklonovat obrazok lebo to ide do ineho vlakna
                Image processImage = _lastImage.Clone() as Image;
                coreRecal.RecalcImage(processImage, actualPersons);
            }
        }

        #endregion


        #region "Progressbar"

        private void StartProgressAnimation()
        {
            TimerProgress.Tick += AnimateProgress;
            TimerProgress.Interval = 100;
            TimerProgress.Start();
        }

        private void AnimateProgress(object sender, EventArgs e)
        {
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
