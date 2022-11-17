// See https://aka.ms/new-console-template for more information
using Composeur;

Console.WriteLine("Bienvenu dans notre compositeur de Sandwich !");

string car;
Console.Write("Appuyez sur entré pour générer un sandwich, n'importe qu'elle autre touche pour quitter ::: ");
car = Console.ReadLine();
if (car == "")
{
    SandwichMaker sandwichMaker = new SandwichMaker();
    Sandwich sandwich = sandwichMaker.composeSandwich();
    Console.WriteLine(sandwich);
}