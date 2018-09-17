using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Emotions
{
    public class Person : INotifyPropertyChanged
    {

        public Person()
        {
        }


        public Guid FaceID { get; set; }
        public int GroupId { get; set; }


        private Image _image;
        /// <summary>
        /// Nahnevaný
        /// </summary>
        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                RaisePropertyChanged("Image");
            }
        }


        private decimal _anger;
        /// <summary>
        /// Nahnevaný
        /// </summary>
        public decimal Anger
        {
            get { return _anger; }
            set
            {
                _anger = value;
                RaisePropertyChanged("Anger");
            }
        }

        private decimal contempt;
        /// <summary>
        /// Opovrhnutie
        /// </summary>
        public decimal Contempt
        {
            get { return contempt; }
            set
            {
                contempt = value;
                RaisePropertyChanged("Contempt");
            }
        }


        private decimal disgust;
        /// <summary>
        /// Znechutenie
        /// </summary>
        public decimal Disgust
        {
            get { return disgust; }
            set
            {
                disgust = value;
                RaisePropertyChanged("Disgust");
            }
        }


        private decimal fear;
        /// <summary>
        /// Strach
        /// </summary>
        public decimal Fear
        {
            get { return fear; }
            set
            {
                fear = value;
                RaisePropertyChanged("Fear");
            }
        }


        private decimal happiness;
        /// <summary>
        /// Stastie
        /// </summary>
        public decimal Happiness
        {
            get { return happiness; }
            set
            {
                happiness = value;
                RaisePropertyChanged("Happiness");
            }
        }


        private decimal neutral;
        /// <summary>
        /// Neutral
        /// </summary>
        public decimal Neutral
        {
            get { return neutral; }
            set
            {
                neutral = value;
                RaisePropertyChanged("Neutral");
            }
        }


        private decimal sadness;
        /// <summary>
        /// Smutok
        /// </summary>
        public decimal Sadness
        {
            get { return sadness; }
            set
            {
                sadness = value;
                RaisePropertyChanged("Sadness");
            }
        }


        private decimal surprise;
        /// <summary>
        /// Prekvapenie
        /// </summary>
        public decimal Surprise
        {
            get { return surprise; }
            set
            {
                surprise = value;
                RaisePropertyChanged("Surprise");
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
