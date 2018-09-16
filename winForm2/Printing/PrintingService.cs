using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emotions.Gamification;
using PhotoStripPrinting;

namespace Emotions.Printing
{
    static class PrintingService
    {
        public static void Print(PhotoStripList repository)
        {
            Printer.Print(repository);
        }
    }
}
