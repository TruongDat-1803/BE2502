// See https://aka.ms/new-console-template for more information
using OOP2;

Console.WriteLine("Hello, World!");

var Quang = new EnglishStudent("Quang", 20, 8, 9, "Hà Nội", 10);
Quang.GetInfo();

var eng1 = new EnglishStudent();
var eng2 = new EnglishStudent();
var his1 = new HistoryStudent();
var his2 = new HistoryStudent();

var students = new List<Student>() { eng1, eng2, his1, his2 };

foreach (var item in students)
{
    if (item is EnglishStudent engStd)
    {
        Console.WriteLine($"Eng score: {engStd.English}");
    }
    if (item is HistoryStudent hisStd)
    {
        Console.WriteLine($"Eng score: {hisStd.History}");
    }
}