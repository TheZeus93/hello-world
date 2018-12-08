using System;

namespace AbstractFactory {

    public class Rectangle : IShape {

        public virtual void Print() {
            Console.WriteLine("Rectangle");
        }

    }

}