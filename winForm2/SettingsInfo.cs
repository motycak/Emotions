using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions
{
    public class SettingsInfo : INotifyPropertyChanged
    {

        public SettingsInfo()
        {
        }




        private string paFaceApiKey;

        public string FaceApiKey
        {
            get
            {
                return this.paFaceApiKey;
            }
            set
            {
                this.paFaceApiKey = value;
                RaisePropertyChanged("FaceApiKey");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;


        void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}
