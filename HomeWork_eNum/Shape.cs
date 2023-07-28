namespace Homework{
    public class Shape{
        protected int side1;
        protected int side2;

        public Shape():this(0,0){}

        public Shape(int side1, int side2){
            this.side1 = side1;
            this.side2 = side2;
        }

        public virtual void CountPerimetre(){
            System.Console.WriteLine(
                "The perimetre of the shape is {0}",
                side1*2+side2*2
            );
        }
    }
}