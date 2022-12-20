using DatabaseConfig.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using DatabaseConfig.Services.Data;
using Syncfusion.Drawing;

namespace CandidCert
{
    public class Program
    {
        public static void ExportPDF()
        {
            const string filename = "mycerts.pdf";
            MemoryStream fileStream  = new MemoryStream(Encoding.Unicode.GetBytes(filename));
            PdfDocument document = new PdfDocument();
            //Add a page to the document
            PdfPage page = document.Pages.Add();
            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;
            //set the standard font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            AppDBContext appDBContext = new AppDBContext();
            Console.WriteLine("Type Candidate's Number");
            int CandidateNumber = Convert.ToInt32(Console.ReadLine());
            //Candidate readCand = appDBContext.Candidates.Find(CandidateNumber);
            Certificate readCert = appDBContext.Certificates.SingleOrDefault(c => c.Candidate.CandidateNumber == CandidateNumber);
            var text = readCert.CertTitle.ToString();
            //Set the formats for the text
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Justify;
            format.LineAlignment = PdfVerticalAlignment.Top;
            format.ParagraphIndent = 15f;
            //Draw the text
            graphics.DrawString(text, font, PdfBrushes.Black, new RectangleF(new PointF(0, 0), page.GetClientSize()), format);
            //Save the document
            document.Save(fileStream);
            //Close the document
            document.Close(true);
            //This will open the PDF file so, the result will be seen in default PDF viewer
            Process.Start(fileStream.ToString());
        }
        static void Main(string[] args)
        {
            Candidate candidate = new Candidate();
            Console.WriteLine(candidate);
        }
    }
}
