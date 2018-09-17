using DarrenLee.Media;
using DevExpress.XtraBars;
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
using System.Windows.Forms;

namespace Emotions
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
            //FaceApi.DeleteGroups(100);
            //FaceApi.DeleteFolderGroups();
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

        #endregion

        private void ImageProcessingFinished(object sender, IList<Person> e)
        {
            game.ProcessEmotions(e, (Image)sender);
            SetProgressValue(game.LastEmotionValue);
            RefreshGameEmotionText(game.ActualEmotion);
        }


        #region Camera


        private void InitializeCamera()
        {
            this.GetInfo();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
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

        private void Timer_Tick(object sender, EventArgs e)
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
            if (!(_lastImage is null))
            {
                // musim tu naklonovat obrazok lebo to ide do ineho vlakna
                Image processImage = _lastImage.Clone() as Image;
                coreRecal.RecalcImage(processImage, actualPersons);
            }
        }

        #endregion


        #region "Progressbar"

        private int TargetProgressValue { get; set; } = 0;

        private void SetProgressValue(int value)
        {
            if (value == 100)
            {
                // tuto to potrebujem hned spravit
                ProgressValue = 100;
            }
            else
            {
                TargetProgressValue = value;
            }
        }

        private void StartProgressAnimation()
        {
            TimerProgress.Tick += AnimateProgress;
            TimerProgress.Interval = 100;
            TimerProgress.Start();
        }

        private void AnimateProgress(object sender, EventArgs e)
        {
            int step = 5;
            if (ProgressValue != TargetProgressValue)
            {
                if (Math.Abs(TargetProgressValue - ProgressValue) < step)
                {
                    ProgressValue = TargetProgressValue;
                }
                else if (TargetProgressValue > ProgressValue)
                {
                    ProgressValue += step;
                }
                else
                {
                    ProgressValue -= step;
                }
            }
        }

        /// <summary>
        /// Toto tu radsej zabalim ak by sme menili tento komponent
        /// </summary>
        private int ProgressValue
        {
            get
            {
                return (int)progressBarControl1.EditValue;
            }
            set
            {
                progressBarControl1.EditValue = value;
            }
        }

        private void RefreshGameEmotionText(GamificationService.eEmotions emotion)
        {
            var str = GetGameEmotionText(emotion);
            if (!lblTitle.Text.Equals(str))
            {
                lblTitle.Text = str;
            }
        }

        private string GetGameEmotionText(GamificationService.eEmotions emotion)
        {
            switch (emotion)
            {
                case GamificationService.eEmotions.Anger:
                    return "BUĎ NAHNEVANÝ !!!";
                case GamificationService.eEmotions.Happines:
                    return "BUĎ ŠŤASTNÝ !!!";
                case GamificationService.eEmotions.Sadness:
                    return "BUĎ SMUTNÝ !!!";
                case GamificationService.eEmotions.Surprise:
                    return "BUĎ PREKVAPENÝ !!!";
                case GamificationService.eEmotions.Disgust:
                    return "BUĎ ZNECHUTENÝ !!!";
                default:
                    return "Game on!";

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




        //private void gridGroupingControl1_TableControlCellDrawn(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlDrawCellEventArgs e)
        //{
        //    if (actualPersons.Data.Count() != 0)
        //    {
        //        if (e.Inner.ColIndex == 0)
        //        {
        //            //ImageList images = new ImageList();
        //            //images.ImageSize = new Size(100, 100);
        //            //images.Images.Add(actualPersons.Data.First().Image);
        //            //Rectangle rect = new Rectangle(0, 0, 100, 100);
        //            //GridStaticCellRenderer.DrawImage(e.Inner.Graphics, images, 0, rect, false);
        //            //e.Inner.Cancel = true;
        //        }
        //    }
        //}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }

        private void acPrint_Click(object sender, EventArgs e)
        {
            PrintingService.Print(game.PhotoStripList);
            game.NewGame();
        }

    }
}
