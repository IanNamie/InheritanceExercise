using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var hummingBird = new Bird() { };
            hummingBird.ColorOfFeathers = "Purple with blue and pink accents.";
            hummingBird.LivesWhere = "Alabama";
            hummingBird.IsCute = true;
            hummingBird.IsWaterResistint = true;
            Console.WriteLine($"I was walking in the woods when I saw a hummingbird feeder with a beautiful hummingbird drinking from it");
            Console.WriteLine($"it had to be from {hummingBird.LivesWhere} because of the colors it was {hummingBird.ColorOfFeathers}" +
                $" I asked my fiancee if she thought that it was cute she said {hummingBird.IsCute} and I had to agree. I also looked it up it is {hummingBird.IsWaterResistint}" +
                $" that the humming bird is water resistant.");


            Console.WriteLine("");

            var hornedLizard = new Reptile() { };
            hornedLizard.CanRegenerate = true;
            hornedLizard.NumberOfLegs = 4;
            hornedLizard.IsAmphibious = false;
            hornedLizard.LikesToDig = true;
            hornedLizard.TypeOfLizard = "Horned Lizard";
           
            Console.WriteLine($"I heard a story the other day of a giant lizard that attacked a city! The news network said that it was {hornedLizard.CanRegenerate}" +
                $" that the lizard could regenerate, They said that it walked on {hornedLizard.NumberOfLegs} legs and that it was {hornedLizard.LikesToDig}" +
                $" that the lizard dug a hole right in the center of the city, it tried to escape in the water but the reports that it could swim were {hornedLizard.IsAmphibious}" +
                $" and it looks like the lizard drowned! but it looks like they were able to identify the type Of lizard it was a {hornedLizard.TypeOfLizard}.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
