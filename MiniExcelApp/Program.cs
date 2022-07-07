// See https://aka.ms/new-console-template for more information
using MiniExcelApp;
using MiniExcelLibs;

Console.WriteLine("Hello, World!");
var path = "c:\\temp\\test1.xlsx";
foreach (dynamic r in MiniExcel.Query(path))
{
    Console.WriteLine($"{r.A}|{r.B}|{r.C}|{r.D}");
}

foreach (var r in MiniExcel.Query<Part>(path))
{
    Console.WriteLine($"{r.Id}|{r.Partnumber}|{r.Lotnumber}|{r.Birth}");
}

Console.ReadLine();
