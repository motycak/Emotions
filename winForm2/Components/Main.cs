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
        }


        #region Variables

        BindigListData actualPersons = new BindigListData();
        Camera myCamera = new Camera();        
        Image _lastImage = null;
        GamificationService game = new GamificationService();
        Timer TimerProgress = new Timer();
        Timer TimerEmotion = new Timer();
        Boolean IsActiveEmotionGame = true;
        SettingsInfo DataSettings;
        CoreRecalc coreRecal;

        #endregion

        private void ImageProcessingFinished(object sender, IList<Person> e)
        {
            game.ProcessEmotions(e, (Image)sender);
            RefreshGameEmotionText();
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
            _lastImage = e.GetFrame();
            this.pictureBox.Image = _lastImage;
            StartProgressAnimation();
        }

        private void TimerEmotion_Tick(object sender, EventArgs e)
        {
            CreateImage();
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
            AnimateProgressEmotion(prgContempt, game.Contempt);
            AnimateProgressEmotion(prgDisgust, game.Disgust);
            AnimateProgressEmotion(prgHappines, game.Happiness);
            AnimateProgressEmotion(prgNeutral, game.Neutral);
            AnimateProgressEmotion(prgSadness, game.Sadness);
            AnimateProgressEmotion(prgSurprise, game.Surprise);
        }

        private void AnimateProgressEmotion(ProgressBarControl prg, int target)
        {
            int step = 5;
            int actual = prg.Position;
            if (actual != target)
            {
                if (Math.Abs(actual - target) < step)
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


        #endregion

    


        public void CameraStop()
        {
            myCamera.Stop();
        }


        public void StartClick()
        {
            StartTimerEmotion();
            game.NewGame();
        }


        public void ResetClick()
        {
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
