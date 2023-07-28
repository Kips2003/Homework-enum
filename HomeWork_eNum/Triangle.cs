namespace Homework{
    public class Triangle:Shape{
        protected int side3;
        
        public Triangle(){}

        public Triangle(int side1, int side2,int side3):base(side1, side2){
            this.side3 = side3;
        }

        public override void CountPerimetre()
        {
            System.Console.WriteLine(
                "the Perimetre of the Triangle is {0}",
                side1+side2+side3
            );
        }

        public void TriangleInfo(int height, int Base){
            System.Console.WriteLine(
                "The Area of the Triangle is {0}",
                height*Base
            );
        }
        public void TriangleInfo(int side1, int side2, int side3){
            System.Console.WriteLine(
                "The perimetre of the Triangle is {0}",
                side1+side2+side3
            );
        }
    }
}