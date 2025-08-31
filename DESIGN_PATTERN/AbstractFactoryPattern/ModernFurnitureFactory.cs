using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // Abstract Products
    public interface IChair
    {
        void SitOn();
    }

    public interface ISofa
    {
        void LieOn();
    }

    // Concrete Products
    public class ModernChair : IChair
    {
        public void SitOn() => Console.WriteLine("Sitting on a modern chair.");
    }

    public class VictorianSofa : ISofa
    {
        public void LieOn() => Console.WriteLine("Lying on a Victorian sofa.");
    }

    // Abstract Factory
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ISofa CreateSofa() => new VictorianSofa(); // Just for demo
    }
}
