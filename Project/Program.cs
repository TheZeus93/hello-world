using System;

namespace AbstractFactory {

    public class Program {

        static void Main(string[] args) {

            IShapeFactory factory = new MyShapeFactory();
            Circle circle = factory.CreateCircle();
            Rectangle rectangle = factory.CreateRectangle();
            circle.Print();
            rectangle.Print();
            Console.ReadLine();

        }

    }

}