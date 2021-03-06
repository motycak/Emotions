﻿using System;
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

        public SettingsInfo(string faceApiKey)
        {
            FaceApiKey = faceApiKey;
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


    public class DescriptionCamera
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DescriptionCamera(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
