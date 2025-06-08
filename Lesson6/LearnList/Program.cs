// See https://aka.ms/new-console-template for more information
using LearnList;
Console.OutputEncoding = System.Text.Encoding.UTF8; // Set the console output encoding to UTF-8
Console.InputEncoding = System.Text.Encoding.UTF8; // Set the console input encoding to UTF-8

Console.WriteLine("Hello, World!");

//var fruits = new List<string>() { "banana", "orange", "lemon"};
//var length = fruits.Count;
//var first = fruits[0];

//foreach (var fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

//var demo = new Demo();
//var result = demo.LookUp1("aBle");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//List<int> ints = new List<int>() { 5, 10, 15, 20, 25, 30};
//var oddNumbers = demo.GetOddNumber(ints);

//var oddNumbers2 = ints.GetObbNumber1();


//Func<int, bool> check = x => x % 2 != 0;
//var oddNumbers3 = ints.ShyWhere(check).ToList();

//foreach (var item in oddNumbers)
//{
//    Console.WriteLine(item);
//}

//var learnLinq = new LearnLinq();
//learnLinq.DemoWhere();
//learnLinq.DemoFistLast();
//learnLinq.DemoOrder();
//learnLinq.DemoSum();
//learnLinq.DemoSelect();
//learnLinq.DemoTakeSkip();
//learnLinq.DemoAnyAll();
//learnLinq.DemoContain();

var btvn = new BTVN();
btvn.Sum_SoLe();
btvn.Select_List();

