using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStripPrinting
{
    public interface IPhotoStrip
    {
        Image Photo1 { get; }
        Image Photo2 { get; }
        Image Photo3 { get; }
        Image Photo4 { get; }
        Image Photo5 { get; }
    }
}
