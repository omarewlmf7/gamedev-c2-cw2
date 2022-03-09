using System;

namespace c2_cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "fawaz";
            int age = 17;
            int speed = 89;
            int height1 = 157;
            int force = 78;
            string SuperPower1 = "fly";
            string heroName = "taleb";
            int heroAge = 25;
            int heroSpeed = 98;
            int heroForce = 97;
            string heroSuperPower1 = "invisible";
            int ageDifference = age - heroAge;
            int heroHeight = 175;
            bool heightCheck = height1 == heroHeight;

            Console.WriteLine("I am " + characterName + " and my age is " + age + " my speed is " + speed + " my Super power is " + SuperPower1);
            if (force > heroForce)
            {
                Console.WriteLine(characterName + " is more powerful");
            }
            else if (force < heroForce)
            {
                Console.WriteLine(heroName + " is more powerful");
            }
            else
            {
                Console.WriteLine("Neither is more powerful");
            }

            if (height1 > heroHeight)
            {
                Console.WriteLine(characterName + " is taller than " + heroName);
            }
            else if (height1 < heroHeight)
            {
                Console.WriteLine(heroName + " is taller than " + characterName);
            }
            else
            {
                Console.WriteLine("Neither is more powerful");
            }

        }
    }
}