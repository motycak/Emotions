using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStripPrinting;

namespace Emotions.Printing
{
    class PrintRepository : IPhotoStripListRepositary
    {
        private List<PhotoStrip> _list = new List<PhotoStrip>();

        public IEnumerable<IPhotoStrip> GetPhotoStrips()
        {
            return _list;
        }

        protected PhotoStrip Last
        {
            get
            {
                return _list.Last();
            }
        }

        protected void AddNew()
        {
            var ps = new PhotoStrip();
            _list.Add(ps);
        }

        protected void Clear()
        {
            _list.Clear();
        }

        protected class PhotoStrip : IPhotoStrip
        {
            public Image Photo2 { get; set; }
            public Image Photo3 { get; set; }
            public Image Photo4 { get; set; }
            public Image Photo1 { get; set; }
            public Image Photo5 { get; set; }
        }
    }
}
