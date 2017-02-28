using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    public class MyPet //This is a class that allows the user to create a virtual pet
    {
        //FIELDS
        private int feelingHungry;
        private int feelingThirsty;
        private int feelingLonely;
        private int feelingTired;
        public int tick;

        //CONSTRUCTORS
        public MyPet()
        {
            FeelingHungry = 5;
            FeelingThirsty = 5;
            FeelingTired = 5;
            FeelingLonely = 5;
        }

        public MyPet(int feelingHungry, int feelingThirsty, int feelingLonely, int feelingTired)
        {

            this.feelingHungry = feelingHungry;
            this.feelingThirsty = feelingThirsty;
            this.feelingTired = feelingTired;
            this.feelingLonely = feelingLonely;
        }

        //PROPERTIES

        public int FeelingHungry
        {
            get { return this.feelingHungry; }
            set { this.feelingHungry = value; }
        }

        public int FeelingThirsty
        {
            get { return this.feelingThirsty; }
            set { this.feelingThirsty = value; }
        }


        public int FeelingTired

        {
            get { return this.feelingTired; }
            set { this.feelingTired = value; }
        }

        public int FeelingLonely
        {
            get { return this.feelingLonely; }
            set { this.feelingLonely = value; }
        }

        //METHODS
        public void FeedPet() //Method that decreases hunger and increases thirst

        {
            if (FeelingHungry > 0) //conditional statement that prevents thirst from going below 0 when method decrementss it down

            {
                Console.WriteLine("Yum! That's delicious.");
                FeelingHungry = FeelingHungry - 1; //pet's stat for hunger decreases by 1
                FeelingThirsty = FeelingThirsty + 1; //pet's stat for thirst increases by 1
                Console.WriteLine("Your pet's hunger has now decreased to " + FeelingHungry + " but its thirst has increased to " + FeelingThirsty);

                System.Threading.Thread.Sleep(3700);  //Creates a pause to allow user to read updated stats
            }
            else
            {
                Console.WriteLine("Your pet is full for now!");
                System.Threading.Thread.Sleep(3700); //Creates a pause to allow user to read updated stats
            }

        }


        public void WaterPet() //method that decreases pets thirst and increases sleepiness
        {
            if (FeelingThirsty > 0) //conditional statement that prevents thirst from going below 0 when method decrementss it down

            {
                Console.WriteLine("Ahhh, that's refreshing. Your pet is feeling hydrated.");
                FeelingThirsty = FeelingThirsty - 1; //pet's stat for thirst decreases by 1
                FeelingTired = FeelingTired + 1; //pet's stat for sleepiness increases by 1
                Console.WriteLine("Your pet's thirst has now decreased to " + FeelingThirsty + " but its fatigue has increased to " + FeelingTired);
                System.Threading.Thread.Sleep(3700);//Creates a pause to allow user to read updated stats
            }
            else
            {
                Console.WriteLine("Your pet's thirst is quenched for now!");
                System.Threading.Thread.Sleep(3000); //Creates a pause to allow user to read updated stats
            }
        }


        public void SingToPet() //method that reduces pets sleepiness and increases its hunger
        {
            if (FeelingTired > 0) //conditional statement that prevents fatigue from going below 0 when method decrements it down

            {
                Console.WriteLine("That tune makes your pet wake up and sing!");
                FeelingTired = FeelingTired - 1; //pet's stat for sleepiness decreases by 1
                FeelingHungry = FeelingHungry + 1; //pet's stat for hunger increases by 1
                Console.WriteLine("Your pet's fatigue has now decreased to " + FeelingTired + " but its hunger has increased " + FeelingHungry);
                System.Threading.Thread.Sleep(3700); //Creates a pause to allow user to read writing on screen
            }
            else
            {
                Console.WriteLine("Your pet's not feeling tired right now!");
                System.Threading.Thread.Sleep(3700); //Creates a pause to allow user to read writing on screen
            }

        }

        public void TalkToPet() //method that affects decreases pets loneliness and increases sleepiness

        {
            if (FeelingLonely > 0) //conditional statement that prevents loneliness from going below 0 when method decrements it down

            {
                Console.WriteLine("Your voice relaxes your pet!");
                FeelingLonely = FeelingLonely - 1; //pet's stat for loneliness decreases by 1
                FeelingTired = FeelingTired + 1; //pet's stat for hunger increases by 1
                Console.WriteLine("Your pet's loneliness has now decreased to " + FeelingLonely + " but its sleepiness has increased to " + FeelingTired);
                System.Threading.Thread.Sleep(3700); //Creates a pause to allow user to read writing on screen
            }

            else
            {
                Console.WriteLine("Your pet is no longer lonely!");
                System.Threading.Thread.Sleep(2000);//Creates a pause to allow user to read writing on screen
            }
        }

        public void Quit() //method that allows user to end program
        {
            var arr = new[]
           {
                //This ASCII smiley face displays whenever Quit method is called and user is ready to exit virtual pet game.
                //I put it in the class because it can display no matter what animal the user decides to create when they instantiate a new object of the class.
@"            OOOOOOOOOOO       ",
@"        OOOOOOOOOOOOOOOOOOO   ",
@"     OOOOOO OOOOOOOOO  OOOOOO ",
@"   OOOOOO      OOOOO       OOOOOO ",
@"  OOOOOOOO  #   OOOOO  #   OOOOOOO   ",
@"  OOOOOOOOOO    OOOOOOO  OOOOOOOOOO    ",
@" OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ",
@" OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO   ",
@" OOOO OOOOOOOOOOOOOOOOOOOOOOOOO OOOO    ",
@" OOOO  OOOOOOOOOOOOOOOOOOOOOOO OOOO  ",
@"   OOOO OOOOOOOOOOOOOOOOOOOO  OOOO   ",
@"    OOOOO   OOOOOOOOOOOOOOO OOOO ",
 @"    OOOOOO   OOOOOOOOO   OOOOOO   ",
 @"       OOOOOO         OOOOOO  ",
 @"           OOOOOOOOOOOO ",

            };

        Console.WriteLine("\n\n\n\n");
        foreach (string line in arr)
        Console.WriteLine(line);

        Console.WriteLine("\n \n Thanks for visiting your virtual pet!");
        System.Threading.Thread.Sleep(3500);//Creates a pause to allow user to read writing on screen
        }

        public void Tick() // method that randomly increases values for various properties based on Random method that selects a different
                           // place in the index that has a range from 0 to 4
        {
            Random rnd = new Random(); //Initializes a new instance of the Random class, using a time-dependent default seed value
            tick = rnd.Next(0, 4);   
            if (tick == 0)
            {
                FeelingHungry++;
            }
            else if (tick == 1)
            {
                FeelingThirsty++;
            }

            else if (tick == 2)
            {
                FeelingTired++;
            }
            else
            {
                FeelingLonely++;
            }

         }



    }

      
    }
    
 
