using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Drawing;
using PhotoStripPrinting;
using System.Linq;
using ImageProcessor;
using System;

namespace PhotoStripPrinting
{
    [HighlightedClass]
    class PhotoStripList
    {
        IPhotoStripListRepositary _repositary;

        public PhotoStripList(IPhotoStripListRepositary repositary)
        {
            _repositary = repositary;
        }

        [HighlightedMember]
        public IEnumerable<IPhotoStrip> PhotoStrips
        {
            get
            {
                if(_repositary is null)
                {
                    return new List<IPhotoStrip>();
                }
                return _repositary.GetPhotoStrips().Select(ps => new PrintPhotoStrip(ps));
            }
        }

        private class PrintPhotoStrip : IPhotoStrip
        {
            IPhotoStrip _photoStrip;

            public PrintPhotoStrip(IPhotoStrip photoStrip)
            {
                _photoStrip = photoStrip;
            }

            public Image Photo1 => PreprocessImage(_photoStrip.Photo1);
            public Image Photo2 => PreprocessImage(_photoStrip.Photo2);
            public Image Photo3 => PreprocessImage(_photoStrip.Photo3);
            public Image Photo4 => PreprocessImage(_photoStrip.Photo4);
            public Image Photo5 => PreprocessImage(_photoStrip.Photo5);

            private static ImageFactory _imageFactory = new ImageFactory();

            private Image PreprocessImage(Image image)
            {
                if (image is null) return null;
              
                return _imageFactory.Load(image)
                                    .Rotate(270)
                                    .Image;
            }
        }
    }
}
