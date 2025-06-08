// See https://aka.ms/new-console-template for more information
using LearnEF;
using LearnEF.Model.Authors;
using LearnEF.Services;

Console.WriteLine("Hello, World!");

var _authorManager = new AuthorManager();
_authorManager.Init();

Console.ReadKey();