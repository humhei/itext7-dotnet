// See https://aka.ms/new-console-template for more information


using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.StyledXmlParser.Resolver.Font;
var dir = new DirectoryInfo(@"C:\Windows\Fonts");

var files = dir.GetFiles("*.*");
var a = new BasicFontProvider(true, true);

PdfCanvasProcessor parser = new PdfCanvasProcessor(new FilteredEventListener()
    );
parser.ProcessPageContent(new PdfDocument(new PdfReader(@"D:\VsCode\Workspace\Shrimp.Pdf.Enhancement\tests\Shrimp.Pdf.Enhancement.Tests\datas\manipulate\set font ratio.pdf")).GetPage(1
    ));
Console.WriteLine("Hello, World!");
