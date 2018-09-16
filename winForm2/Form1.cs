﻿using DarrenLee.Media;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emotions.Printing;
using Emotions.Gamification;

namespace winForm2
{
    public partial class Form1 : MetroForm
    {

        #region Variables

        BindigListData actualPersons = new BindigListData();
        Camera myCamera = new Camera();
        CoreRecalc coreRecal = new CoreRecalc();
        Image _lastImage = null;
        GamificationService game = new GamificationService();

        #endregion


        public Form1()
        {
            InitializeComponent();
            //FaceApi.DeleteGroups(100);
            //FaceApi.DeleteFolderGroups();
            this.InitializeGrid();
            this.InitializeCamera();
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
                this.cmbCameras.Items.Add(d);

            foreach (var r in cameraResolutions)
                this.cmbResolutions.Items.Add(r);

            this.cmbCameras.SelectedIndex = 0;
            this.cmbResolutions.SelectedIndex = 0;
        }


        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            _lastImage = e.GetFrame();
            this.pictureBox1.Image = _lastImage;
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
            coreRecal.RecalcImage(_lastImage, actualPersons);
            game.ProcessEmotions(actualPersons.Data, _lastImage);
            SetProgressValue(game.LastEmotionValue);
            RefreshGameEmotionText(game.ActualEmotion);
        }


        #endregion


        #region "Progressbar"

        private void SetProgressValue(int value)
        {
            ProgressValue = value;
        }

        /// <summary>
        /// Toto tu radsej zabalim ak by sme menili tento komponent
        /// </summary>
        private int ProgressValue {
            get {
                return progressBarAdv1.Value;
            }
            set {
                progressBarAdv1.Value = value;
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
            this.gridGroupingControl1.TableDescriptor.Columns["Image"].Appearance.AnyRecordFieldCell.CellType = "Image";

            this.gridGroupingControl1.TableDescriptor.Columns["Image"].Appearance.AnyRecordFieldCell.ImageSizeMode = GridImageSizeMode.AutoSize;
            this.gridGroupingControl1.TableDescriptor.Columns["Anger"].HeaderText = "Nahnevaný";
            this.gridGroupingControl1.TableDescriptor.Columns["Contempt"].HeaderText = "Opovrhnutie";
            this.gridGroupingControl1.TableDescriptor.Columns["Disgust"].HeaderText = "Znechutenie";
            this.gridGroupingControl1.TableDescriptor.Columns["Fear"].HeaderText = "Strach";
            this.gridGroupingControl1.TableDescriptor.Columns["Happiness"].HeaderText = "Štastie";
            this.gridGroupingControl1.TableDescriptor.Columns["Neutral"].HeaderText = "Neutral";
            this.gridGroupingControl1.TableDescriptor.Columns["Sadness"].HeaderText = "Smútok";
            this.gridGroupingControl1.TableDescriptor.Columns["Surprise"].HeaderText = "Prekvapenie";
            //this.gridGroupingControl1.TableDescriptor.Columns["FaceID"]
            this.gridGroupingControl1.DataSource = actualPersons.Data;
        }


        #endregion




        private void gridGroupingControl1_TableControlCellDrawn(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlDrawCellEventArgs e)
        {
            if (actualPersons.Data.Count() != 0)
            {
                if (e.Inner.ColIndex == 0)
                {
                    //ImageList images = new ImageList();
                    //images.ImageSize = new Size(100, 100);
                    //images.Images.Add(actualPersons.Data.First().Image);
                    //Rectangle rect = new Rectangle(0, 0, 100, 100);
                    //GridStaticCellRenderer.DrawImage(e.Inner.Graphics, images, 0, rect, false);
                    //e.Inner.Cancel = true;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintingService.Print(game.PhotoStripList);
            game.NewGame();
        }
    }
}
