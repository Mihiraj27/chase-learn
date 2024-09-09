using System;
using myApp;

// Console.WriteLine("Enter Your Name Here ");

// string firtsName = Console.ReadLine();


// Console.WriteLine("Your Name is "+firtsName);




// int x = 100 + 50;

// Console.WriteLine(x);


// string firstName = "John";
// string lastName = "Doe";
// string name = $"My full name is: {firstName} {lastName}";
// Console.WriteLine(name);



// string txt = "We are the so-called \'Vikings\' from the north.";

// Console.WriteLine(txt);


// int myAge = 25;
// int votingAge = 37;

// if (myAge >= votingAge) 
// {
//   Console.WriteLine("Old enough to vote!");
// } 
// else 
// {
//   Console.WriteLine("Not old enough to vote.");
// };

// int age = 45;

// switch(age){

//     case ((age > 30)):
//         Console.WriteLine("HIiiiiii");
//     break;

//     default:
//     // code block
//     break;
// }


// int i = 0;
// while (i < 5) 
// {
//   Console.WriteLine(i);
//   i++;
// }


// for(int i = 1 ; i <= 5 ; i++){

//     for (int j= 1 ; j <= i ; j++){

//         Console.Write(" * ");
//     }

//       Console.WriteLine();
// }

// int i = 0;
// do 
// {
//   Console.WriteLine(i);
//   i++;
// }
// while (i < 5);


// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};


// foreach (string car in cars){

//     Console.WriteLine(car);
// }


// for (int i = 0; i < 10; i++) 
// {
//   if (i == 4) 
//   {
//     break;
//   }
//   Console.WriteLine(i);
// }


// for (int i = 0; i < 10; i++) 
// {
//   if (i == 4) 
//   {
//     continue;
//   }
//   Console.WriteLine(i);
// }

// Sort an int
// int[] myNumbers = {5, 1, 8, 9};
// Array.Sort(myNumbers);
// foreach (int i in myNumbers)
// {
//   Console.WriteLine(i);
// }



///Defile Main Method
///


// using System;

// namespace HelloWorldApplication {
//    class HelloWorld {
//       static void Main(string[] args) {
//          /* my first program in C# */
//          Console.WriteLine("Hello World");
//       }
//    }
// }


// class Car 
// {
//   string color = "red";

//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     Console.WriteLine(myObj.color);
//   }
// }


// class Car
// {
//   string color = "red";
//   static void Main(string[] args)
//   {
//     Car myObj1 = new Car();
//     Car myObj2 = new Car();
//     Console.WriteLine(myObj1.color);
//     Console.WriteLine(myObj2.color);
//   }
// }



// class Car {

//     private int carNo;
//     private string carModel;

//      public int CarNo   // property
//         {
//             get { return carNo; }
//             set { carNo = value; }
//         }

//     public string CarModel   // property
//         {
//             get { return carModel; }
//             set { carModel = value; }
//         }


// }


// class Program
// {
//   static void Main(string[] args)
//   {
//     Car myObj = new Car();
//     myObj.CarModel = "Volvo";


//     Console.WriteLine(myObj.CarModel);
//   }
//}

//Inheritnace


// using System;

// namespace myApp {
//     class Vehicle {

//     public string vehicleTCode;


//     public string VehicleCode{
//         get;
//         set;
//     }
// }


// class  MotorVehicle : Vehicle{
//     public string  color;


//     public string Color{
//         get;
//         set;
//     }
// }


//  static void Main (string[] args){

//     MotorVehicle motorVehicle = new MotorVehicle();

//     motorVehicle.vehicleTCode = "CR";
//     motorVehicle.color = "Red";

//     Console.WriteLine(motorVehicle.Color);
// }

// }


namespace myApp {


    abstract class Animal{


       public abstract void animalName();

        public void animalColor(string name){
            Console.WriteLine(name);
        }
    }


    class Pig : Animal {
        public override void animalName(){
            Console.WriteLine("Piff");
        }
    }

    class Program{
    static void Main(string[] args)
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalName();
      myPig.animalColor("Red");
    }
  }
}