using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Diagnostics;

namespace BusinessLogic
{
    public class PDFOpener
    {
        public static void OpenPdfFil(string pdf)
        {
            Process.Start(pdf);
        }

        public static void SupportPdf()
        {
            string pdf_path=
                AppDomain.CurrentDomain.BaseDirectory + "//BusinessLogicResources//PdfFiles//SynsPunktSupport.pdf";
            
            OpenPdfFil(pdf_path);
        }

    }
}
