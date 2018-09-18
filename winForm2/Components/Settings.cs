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

namespace Emotions.Components
{
    public partial class Settings : UserControl
    {


        Camera MyCamera;


        public Settings()
        {
            InitializeComponent();
        }



        public void Initialize(SettingsInfo dataSettings, Camera camera)
        {
            settingsInfoBindingSource.DataSource = dataSettings;
            MyCamera = camera;
            SetSettingsInfo();
        }



        private void SetSettingsInfo()
        {
            foreach (var d in MyCamera.GetCameraSources())
                this.cmbCameras.Properties.Items.Add(d);

            foreach (var r in MyCamera.GetSupportedResolutions())
                this.cmbResolutions.Properties.Items.Add(r);

            cmbCameras.SelectedIndex = 0;
            cmbResolutions.SelectedIndex = 0;
        }


        private void cmbCameras_EditValueChanged(object sender, EventArgs e)
        {
            MyCamera.ChangeCamera(this.cmbCameras.SelectedIndex);
        }


        private void cmbResolutions_EditValueChanged(object sender, EventArgs e)
        {
            MyCamera.Start(cmbResolutions.SelectedIndex);
        }


    }
}
