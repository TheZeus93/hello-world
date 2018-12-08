using System;

namespace AbstractFactory {

    public class MyRectangle : Rectangle {
        public override void Print() {
            Console.WriteLine("My Rectangle");
        }
    }

}