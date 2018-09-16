using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStripPrinting
{
    public static class Printer
    {
        public static void Print(IPhotoStripListRepositary repositary)
        {
            using (RptPhotoStrip report = new RptPhotoStrip()) { 
                report.DataSource = new PhotoStripList(repositary).PhotoStrips;

                using (ReportPrintTool tool = new ReportPrintTool(report))
                {
                    if (System.Diagnostics.Debugger.IsAttached)
                    {
                        tool.ShowRibbonPreviewDialog();
                    }
                    else
                    {
                        tool.Print();
                    }
                }
            }
        }
    }
}
