using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStripPrinting;

namespace Emotions.Printing
{
    static class PrintingService
    {
        public static void Print(PrintRepository repository)
        {
            Printer.Print(repository);
        }
    }
}
