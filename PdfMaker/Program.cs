using Aspose.Pdf;

using iText.Kernel.Pdf.Canvas;

namespace PdfMaker;

internal class Program
{
    static void Main(string[] args)
    {
        // Crate Option
        HtmlLoadOptions htmloptions = new HtmlLoadOptions();
        // Find And Load Html Document 
        Document doc = new Document(@"C:\Users\Amin\Desktop\index.html", htmloptions);
        // Save Converted pdf document
        doc.Save("example.pdf");

        //Use Aspose NuGet Package 
        //Version (24.9.0)

        // Attention
        //  the code part for removing the advertisement in the PDF 

        // PDF with advertisement
        string inputPdf = @"example.pdf";

        // PDF widhout advertisement
        string outputPdf = @"result.pdf";


        using (iText.Kernel.Pdf.PdfReader reader = new iText.Kernel.Pdf.PdfReader(inputPdf))
        using (iText.Kernel.Pdf.PdfWriter writer = new iText.Kernel.Pdf.PdfWriter(outputPdf))
        using (iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(reader, writer))
        {

            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
            {
                var page = pdfDoc.GetPage(i);

                PdfCanvas canvas = new PdfCanvas(page);

                // Advertisment Cordinate
                float x = 0;
                float y = 780;
                float width = 500;
                float height = 20;

                canvas.SetFillColor(iText.Kernel.Colors.ColorConstants.WHITE);
                canvas.Rectangle(x, y, width, height);
                canvas.Fill();
            }
        }

        // Itext.Pdf NuGet Package
        // Version(8.0.5)
        // Itext.bouncy-castle-adapter
        //Version(8.0.5) 

    }
}
