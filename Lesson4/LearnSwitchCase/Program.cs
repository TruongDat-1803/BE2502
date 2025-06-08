// See https://aka.ms/new-console-template for more information
using LearnSwitchCase;

Console.OutputEncoding = System.Text.Encoding.UTF8; // Set the console output encoding to UTF-8
Console.InputEncoding = System.Text.Encoding.UTF8; // Set the console input encoding to UTF-8

var demo = new Demo();
var statusCode = 404;
var message = demo.GetMessage(statusCode);
Console.WriteLine($"{message}");

int result = demo.GetDaysOfMonth(2);
Console.WriteLine($"Tháng 2 có {result} ngày");

var result2 = demo.GetDaysOfMonth1(Month.August);
Console.WriteLine($"Tháng 8 có {result2} ngày");

var result3 = demo.GetDaysOfMonthAndYear(Month.February, 2024);
Console.WriteLine($"Tháng 2 năm 2024 có {result3} ngày");
