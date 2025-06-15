// See https://aka.ms/new-console-template for more information
using BookApp;
using BookApp.Model.Authors;
using BookApp.Services;

Console.WriteLine("Hello, World!");

var _authorManager = new AuthorManager();
_authorManager.Init();

Console.ReadKey();