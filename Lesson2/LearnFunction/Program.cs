// See https://aka.ms/new-console-template for more information
using LearnFunction;

Console.WriteLine("Hello, World!");
// Tinh diện tích hình chữ nhật
var demo = new Demo();
var result = demo.CalculateSRec(5.2 , 10.5);
Console.WriteLine($"Dien tich hinh chu nhat la: {result}");

var result1 = demo.CalculateSRec1(5.2, 10.5, out var p);
var onlySRec = demo.CalculateSRec1(10, 20, out _);

// Tinh diện tích hình tròn
var resultCircle = demo.CaculateSCircle(10);
Console.WriteLine($"Dien tich hinh tron la: {resultCircle}");

// Tinh trung bình 3 so
var a = 10;
var b = 20;
var c = 30;
var resultAverage = demo._average(a, b, c);
Console.WriteLine($"Trung binh 3 so la: {resultAverage}");

// Thay doi gia tri
var value = 10;
demo.ChangeValue(value);
demo.ChangeValue1(ref value);

const double PI = 3.14;



Console.ReadKey();