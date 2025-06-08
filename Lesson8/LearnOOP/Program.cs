// See https://aka.ms/new-console-template for more information
using LearnOOP;
Console.OutputEncoding = System.Text.Encoding.UTF8; // Set the console output encoding to UTF-8
Console.InputEncoding = System.Text.Encoding.UTF8; // Set the console input encoding to UTF-8

try
{
    var student1 = new Student();
    student1.Name = "Nguyen Van A";
    student1._Age = 20;
    student1._Address = "Ha Noi";
    student1.PrintInfo();
}
catch (Exception ex)
{
   Console.WriteLine(ex.Message);
}

var student2 = new Student("Nguyen Van B", 12, "Cầu Giấy");
student2.PrintInfo();

var _productmanager = new  ProductManager();
_productmanager.init();

Console.WriteLine("Hello, World!");