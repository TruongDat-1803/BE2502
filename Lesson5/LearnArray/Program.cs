// See https://aka.ms/new-console-template for more information
using LearnArray;

int[] arr = new int[5];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
arr[3] = 4;
arr[4] = 5;

foreach (var item in arr)
{
    if (item % 2 == 0)
    {
        Console.WriteLine(item);
    }
}

var demo = new Demo();
var result = demo.LookUp("table");
Console.WriteLine(result);


