using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStripPrinting;

namespace Emotions.Gamification
{
    class PhotoStripList : IPhotoStripListRepositary,  INotifyPropertyChanged
    {
        private List<PhotoStrip> _list = new List<PhotoStrip>();

        public IEnumerable<IPhotoStrip> GetPhotoStrips()
        {
            return _list;
        }

        public PhotoStrip Last
        {
            get
            {
                return _list.Last();
            }
        }

        public void AddNew()
        {
            var ps = new PhotoStrip();
            _list.Add(ps);
            Count = _list.Count();
        }

        public void Clear()
        {
            _list.Clear();
            Count = _list.Count();
        }

        public class PhotoStrip : IPhotoStrip
        {
            public Image Photo2 { get; set; }
            public Image Photo3 { get; set; }
            public Image Photo4 { get; set; }
            public Image Photo1 { get; set; }
            public Image Photo5 { get; set; }
        }


        private decimal count;

        public decimal Count
        {
            get { return count; }
            set
            {
                count = value;
                RaisePropertyChanged("Count");
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
