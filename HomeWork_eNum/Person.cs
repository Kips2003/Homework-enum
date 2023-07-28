namespace Homework{
    public class Person{
        public string Name { get; set; }
        public int Age { get; set; }
        public static int count;

        public Person(){
            count++;
            Name = "NoName";
            Age = 0;
        }

        public Person(string Name, int Age){
            this.Name = Name;
            this.Age = Age;
            count++;
        }
    }
}