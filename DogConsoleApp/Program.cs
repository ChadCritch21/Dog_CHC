/**
 * This Main class is being used to test the modeled Dog class.
 * @author Chad Crithelow
 * @version 1.0
 * Program Project 1 Dog_CHC
 * SP20
 */
using System;

namespace DogConsoleApp
{
    class Program
    {

        static void Main(string[] args)//main method
        {
            Dog dog = new Dog();//creating a new Dog object

            dog.setName("Dash");//setting the dogs name and age
            dog.setAge(3);

            Console.WriteLine("This new dogs named is " + dog.getName() + ".");//getting the dogs name, age in human/dog years, and both together.
            Console.WriteLine(dog.getName() + " in human years is " + dog.getAge() + " years old.");
            Console.WriteLine(dog.getName() + " in dog years is " + dog.calcDogYears() + " years old.");
            Console.WriteLine("The animal will be saved in the system as: " + dog.ToString());

        }
    }
}


