// See https://aka.ms/new-console-template for more information
using Test;

Console.WriteLine("Hello, World!");
var sportcar = new SportCar("Sport car", 15, 60, 400, 2, 40);
Console.WriteLine("Max sportcar Distance = " + sportcar.MaxDistance());
Console.WriteLine("Max current sportcar distance = " + sportcar.MaxCurrentDistance());
var truck = new Truck("Truck", 30, 200, 110, 3, 2, 15, 2000, 775);
Console.WriteLine("Max truck Distance = " + truck.MaxDistance());
Console.WriteLine("Max current truck distance = " + truck.MaxCurrentDistance());