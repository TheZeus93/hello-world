namespace AbstractFactory {

    public class MyShapeFactory : IShapeFactory {

        public Rectangle CreateRectangle() {
            return new MyRectangle();
        }

        public Circle CreateCircle() {
            return new MyCircle();
        }

    }

}