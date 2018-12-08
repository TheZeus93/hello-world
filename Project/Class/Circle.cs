using System;

namespace AbstractFactory {

    public class Circle : IShape {

        public virtual void Print() {
            Console.WriteLine("Circle");
        }

    }

}