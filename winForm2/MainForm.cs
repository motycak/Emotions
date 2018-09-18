using DarrenLee.Media;
using DevExpress.ClipboardSource.SpreadsheetML;
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

        SettingsInfo dataSettings = new SettingsInfo(Properties.Resources.FaceApiKey);


        public MainForm()
        {
            InitializeComponent();
            settings1.settingsInfoBindingSource.DataSource = dataSettings;
            main1.Initialize(dataSettings);
            settings1.Initialize(dataSettings, main1.GetCamera());
        }
        

        private void AcStart_Click(object sender, EventArgs e)
        {
            main1.StartClick();
            ShowGame();
        }


        private void AcReset_Click(object sender, EventArgs e)
        {
            main1.ResetClick();
            ShowGame();
        }

        private void AcStop_Click(object sender, EventArgs e)
        {
            main1.StopClick();
            ShowGame();
        }


        private void AcPrint_Click(object sender, EventArgs e)
        {
            main1.PrintClick();
            ShowGame();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            main1.CameraStop();
        }

        private void AcSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }




        private void ShowSettings()
        {
            settings1.Visible = true;
            main1.Visible = false;
            
        }

        private void ShowGame()
        {
            settings1.Visible = false;
            main1.Visible = true;
        }

        private void AcFullscreen_Click(object sender, EventArgs e)
        {
            main1.ClearClick();
        }

        private void GameGroup_Click(object sender, EventArgs e)
        {
            ShowGame();
        }
    }
}
