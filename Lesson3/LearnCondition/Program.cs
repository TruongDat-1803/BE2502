// See https://aka.ms/new-console-template for more information
using LearnCondition;
Console.OutputEncoding = System.Text.Encoding.UTF8; // Set the console output encoding to UTF-8
Console.InputEncoding = System.Text.Encoding.UTF8; // Set the console input encoding to UTF-8


//Viết hàm xác định học lực của học sinh dựa vào điểm trung bình
// =5 => TB
// >5 => Khá
// <5 => Yếu
var demo = new Demo();
var result = demo.GetStudentResult(5);

Console.WriteLine($"Học lực của học sinh là: {result}");

//Viết hàm xác định số lớn nhaast trong 3 số
var max = demo.GetMaxNumber(1, 2, 3);

Console.WriteLine($"Số lớn nhất là: {max}");

//Viết hàm kiểm tra xem có phải năm nhuận hay không
var year = 2024;
if (demo.IsLeapYear(year))
{
    Console.WriteLine($"Năm {year} là năm nhuận");
}
else
{
    Console.WriteLine($"Năm {year} không phải là năm nhuận");
}

var year2 = 2023;
if (demo.IsLeapYear2(year2))
{
    Console.WriteLine($"Năm {year2} là năm nhuận");
}
else
{
    Console.WriteLine($"Năm {year2} không phải là năm nhuận");
}

var year3 = 2000;
if (demo.IsLeapYear2(year3))
{
    Console.WriteLine($"Năm {year3} là năm nhuận");
}
else
{
    Console.WriteLine($"Năm {year3} không phải là năm nhuận");
}

