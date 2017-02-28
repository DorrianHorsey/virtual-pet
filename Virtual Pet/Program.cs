using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is a program to create a virtual pet.  This instance of the class creates a parrot.

            var arr = new[] //this code displays a parrot. I put it in the main program because a person might want to instantiate the class with another animal
            {
@"          _____           ",
@"     ,----/,--.   `.      ",
@"    /    '. `-'     \     ",
@"    | ____ \      '`|_    ",
@"    \'.--._/` _     \ '.  ",
@"         /'-|/ \|`\|-`  \ ",
@"        /   /       \   | ",
@"        |  ;    '`  |  .' ",
@"        '. |;;      ;  /  ",
@"         \ \ ;     / ,'   ",
@"          ;--,   .,--,    ",
@"     mx__ ||=|=|./|=|=||___   ",
@"         `'-'-'  `-'-'`   ",
@" ___________________________  ",
@"         /'/ /  \  \ \    ",
@"         / '.';  ; \ ' \  ",
@"       '-/   | ; | ; \-'  ",
@"         \_ | |   | |_/   ",
@"           `-'\_/`-'  ",
 



            };
            
            Console.WriteLine("\n\n\n\n");
            foreach (string line in arr)
            Console.WriteLine(line);




            Console.WriteLine("Hello, welcome to the world of your new virtual parrot! \n\n What do you want to call him?");
        
            string name = (Console.ReadLine());

            int userinput; //declare variable to store user input related to what user wants to do with pet

            MyPet parrot = new MyPet(); //This code creates a new instance of the MyPet class called parrot
         
            

            do  //creates a do while loop that sets up the user interface showing the pets current stats and options for user input.
            // the loop will continue to run until the user types the number 5 to quit the program.

            {
                Console.WriteLine("\nHere are " + name + " the parrot's current stats ...\n"); //the lines below show updated values for the 4 properties I created for the pet
                Console.WriteLine("Hunger: {0}", parrot.FeelingHungry); 
                Console.WriteLine("Thirst: {0}", parrot.FeelingThirsty);
                Console.WriteLine("Fatigue: {0}", parrot.FeelingTired);
                Console.WriteLine("Loneliness: {0}\n\n\n", parrot.FeelingLonely);
           
                Console.WriteLine("What do you want to do for your parrot? Please enter a number.\n");
                Console.WriteLine("1: Feed him \n" + "2: Give him Water \n" + "3: Sing him a lullaby \n" + "4: Talk to him\n" + "5. Quit the program");
             
            
                userinput = int.Parse(Console.ReadLine());

           
                if (userinput == 1) //conditional statement allowing user input to call a method that corresponds with each number selected.
                {
                    parrot.FeedPet(); //this method relates to the value for pet's hunger
                
                }
                else if (userinput == 2)
                {
                    parrot.WaterPet();// this method relates to the value for pet's thirst
                }
                else if (userinput == 3)
                {
                    parrot.SingToPet(); //this method relates to the value for pet's sleepiness
                }
                else if (userinput == 4)
                {
                    parrot.TalkToPet(); //this method relates to the value for pet's loneliness
                }
                else if (userinput == 5)
                {
                    parrot.Quit(); //calling Quit method to close program
                }
                else
                {
                    Console.WriteLine("Please type a number between 1 and 5");
                }

                Console.Clear(); //clearing the console to make it easier for user to read options
                parrot.Tick();// calling the Tick method to randomly switch values for properties

            } while (userinput != 5); //closes off the loop when user inputs "5" to quit program
           


        }
    }
}
