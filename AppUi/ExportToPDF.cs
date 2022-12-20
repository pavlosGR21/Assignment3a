using DatabaseConfig.Models;
using DatabaseConfig.Services.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Xml.Linq;
using PdfSharp.Drawing.Layout;

namespace AppUi
{
    public class ExportToPDF
    {
        public static void ExportPDF()
        {
            const string filename = "mycerts.pdf";
            
            AppDBContext appDBContext = new AppDBContext();
            Console.WriteLine("Type Candidate's Number");
            int CandidateNumber = Convert.ToInt32(Console.ReadLine());
            //Candidate readCand = appDBContext.Candidates.Find(CandidateNumber);
            Certificate readCert = appDBContext.Certificates.SingleOrDefault(c => c.Candidate.CandidateNumber == CandidateNumber);
            var text = readCert.CertTitle.ToString() + " " + readCert.AssessmentResultLabel.ToString();
            //Set the formats for the text
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Times New Roman", 10, XFontStyle.Bold);
            XTextFormatter tf = new XTextFormatter(gfx);

            XRect rect = new XRect(40, 100, 250, 220);
            gfx.DrawRectangle(XBrushes.SeaShell, rect);
            //tf.Alignment = ParagraphAlignment.Left;
            tf.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);

            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }
    }
}
