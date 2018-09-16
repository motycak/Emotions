using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStripPrinting
{
    public interface IPhotoStripListRepositary
    {
        IEnumerable<IPhotoStrip> GetPhotoStrips();
    }
}
