using System;
using Homework;
using Homework.Extension;

namespace Program{
    public class MyProgram{
        public static void MultOfNumbers(int a, int b){
            System.Console.WriteLine(
                "{0}*{1}={2}",
                a, b, a*b
            );
        }

        public static void MultOfNumbers(double a, double b){
            System.Console.WriteLine(
                "{0}*{1}={2}",
                a, b, a*b
            );
        }

        public static void Main(string[] args){

/////////////////////////////////////////////////////////////////
            System.Console.WriteLine(
                "Enter number from 1 to 7"
            );
            int numberOfTheDay = int.Parse(Console.ReadLine());

            DaysOfWeek dayOfTheNumber = (DaysOfWeek)numberOfTheDay;
            System.Console.WriteLine(
                "The day you choose was {0}",
                dayOfTheNumber
            );


            System.Console.WriteLine();

////////////////////////////////////////////////////////////////////
            Status status = Status.Delivered;
            switch(status){
                case Status.Deleted:
                    System.Console.WriteLine("Status: Deleted");break;
                case Status.Delivered:
                    System.Console.WriteLine("Status: Delivered");break;
                case Status.Sent:
                    System.Console.WriteLine("Status: Sent");break;
            }


            System.Console.WriteLine();

//////////////////////////////////////////////////////////////
            Person perosn = new Person();
            System.Console.WriteLine(Person.count);


            System.Console.WriteLine();

//////////////////////////////////////////////////////////////
            Triangle triangle = new Triangle();

            triangle.TriangleInfo(3,5);
            triangle.TriangleInfo(3,4,5);


            System.Console.WriteLine();
                
/////////////////////////////////////////////////////
            MultOfNumbers(5,7);
            MultOfNumbers(3.7,75.3);


            System.Console.WriteLine();

/////////////////////////////////////////////////////////////////
            Shape shape = new Shape(4,5);
            shape.CountPerimetre();

            Shape triangle1 = new Triangle(5,6,7);
            triangle1.CountPerimetre();


            System.Console.WriteLine();

///////////////////////////////////////////////////////////////////
            Person person1 = new Person("Giorgi", 20);
            System.Console.WriteLine(
                "Name: {0}\nAge: {1}",
                person1.Name, person1.Age
            );
            
            System.Console.WriteLine();

            Person person2 = new Person();
            System.Console.WriteLine(
                "Name: {0}\nAge: {1}",
                person2.Name, person2.Age
            );


            System.Console.WriteLine();

//////////////////////////////////////////////////////////////////////
            BankAccount bankAccount = new BankAccount();

            bankAccount.AccountNumber = "GE00992233";
            bankAccount.Currency = "GEL";
            bankAccount.Amount = 546.2m;

            System.Console.WriteLine(
                "Account Number: {0}",
                bankAccount.AccountNumber
            );
        }
    }
}