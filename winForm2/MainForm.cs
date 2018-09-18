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

        SettingsInfo dataSettings = new SettingsInfo();


        public MainForm()
        {
            InitializeComponent();
            main1.Initialize();
            settings1.settingsInfoBindingSource.DataSource = dataSettings;
        }
        

        private void acStart_Click(object sender, EventArgs e)
        {
            main1.StartClick();
            ShowGame();
        }


        private void acReset_Click(object sender, EventArgs e)
        {
            main1.ResetClick();
            ShowGame();
        }

        private void acStop_Click(object sender, EventArgs e)
        {
            main1.StopClick();
            ShowGame();
        }


        private void acPrint_Click(object sender, EventArgs e)
        {
            main1.PrintClick();
            ShowGame();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            main1.CameraStop();
        }

        private void acSettings_Click(object sender, EventArgs e)
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

    }
}
