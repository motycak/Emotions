﻿using DarrenLee.Media;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Emotions.Gamification;
using Emotions.Printing;
using ImageProcessor.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotions
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.InitializeGrid();
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
        Timer TimerProgress = new Timer();
        Timer TimerEmotion = new Timer();
        Boolean IsActiveEmotionGame = true;

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
            var cameraDevices = myCamera.GetCameraSources();
            var cameraResolutions = myCamera.GetSupportedResolutions();

            foreach (var d in cameraDevices)
                this.cmbCameras.Properties.Items.Add(d);

            foreach (var r in cameraResolutions)
                this.cmbResolutions.Properties.Items.Add(r);

            this.cmbCameras.SelectedIndex = 0;
            this.cmbResolutions.SelectedIndex = 0;
        }


        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            _lastImage = e.GetFrame();
            this.pictureBox.Image = _lastImage;
            StartProgressAnimation();
        }

        private  void TimerEmotion_Tick(object sender, EventArgs e)
        {
             CreateImage();
        }


        private void cmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(this.cmbCameras.SelectedIndex);
        }


        private void cmbResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.Start(cmbResolutions.SelectedIndex);
        }


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
            if(actual != target)
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


        #region Grid


        private void InitializeGrid()
        {
            //this.gridGroupingControl1.TableDescriptor.Columns["Image"].Appearance.AnyRecordFieldCell.CellType = "Image";

            //this.gridGroupingControl1.TableDescriptor.Columns["Image"].Appearance.AnyRecordFieldCell.ImageSizeMode = GridImageSizeMode.AutoSize;
            //this.gridGroupingControl1.TableDescriptor.Columns["Anger"].HeaderText = "Nahnevaný";
            //this.gridGroupingControl1.TableDescriptor.Columns["Contempt"].HeaderText = "Opovrhnutie";
            //this.gridGroupingControl1.TableDescriptor.Columns["Disgust"].HeaderText = "Znechutenie";
            //this.gridGroupingControl1.TableDescriptor.Columns["Fear"].HeaderText = "Strach";
            //this.gridGroupingControl1.TableDescriptor.Columns["Happiness"].HeaderText = "Štastie";
            //this.gridGroupingControl1.TableDescriptor.Columns["Neutral"].HeaderText = "Neutral";
            //this.gridGroupingControl1.TableDescriptor.Columns["Sadness"].HeaderText = "Smútok";
            //this.gridGroupingControl1.TableDescriptor.Columns["Surprise"].HeaderText = "Prekvapenie";
            ////this.gridGroupingControl1.TableDescriptor.Columns["FaceID"]
            //this.gridGroupingControl1.DataSource = actualPersons.Data;
        }


        #endregion




        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }


        private void acStart_Click(object sender, EventArgs e)
        {
            StartTimerEmotion();
            game.NewGame();
        }


        private void acReset_Click(object sender, EventArgs e)
        {
            StartTimerEmotion();
            game.ResetRound();
        }

        private void acStop_Click(object sender, EventArgs e)
        {
            StopTimerEmotion();
            game.Stop();
            RefreshGameEmotionText();
        }


        private void acPrint_Click(object sender, EventArgs e)
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