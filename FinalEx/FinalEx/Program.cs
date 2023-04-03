// See https://aka.ms/new-console-template for more information
using FinalEx;
using System.IO.Pipes;

AnimalMenu animalMenu = new AnimalMenu(new ConsoleUI());
animalMenu.Start();
Console.ReadLine();
