// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;

Console.WriteLine("Hello, World!");


IFurnitureFactory factory = new ModernFurnitureFactory();
IChair chair = factory.CreateChair();
ISofa sofa = factory.CreateSofa();

chair.SitOn(); // Output: Sitting on a modern chair.
sofa.LieOn();  // Output: Lying on a Victorian sofa.
