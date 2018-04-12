using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong180410
{
    public class UI
    {
        public void MainMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Enter number for choice");
                Console.WriteLine("1) Example");
                Console.WriteLine("0) Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Example();
                        break;
                    case "0":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
                Console.Write("\n<PRESS ANY BUTTON TO CONTINUE>");
                Console.ReadKey();
            }
        }

        public void Example()
        {
            var g  = new AnimalShelter<Animal>(10);
            theShelter.Leave(new Animal(57, "zafa", "horse", 4, true));
            theShelter.Leave(new Animal(100, "Hati", "Elephant", 4, true));
            theShelter.Leave(new Animal(2, "Jessica", "Dog", 3, true));
            theShelter.Leave(new Animal(3, "Herr Nilsson", "Monkey", 2, true));
            theShelter.Leave(new Animal(50, "Trump", "Orange", 2, false));

            var filteredShelter = theShelter.Where(x => x.NrOfLegs > 2 || x.Species == "Orange").OrderBy(x => x.IsTame).OrderBy(x => x.Age).OrderBy(x => x.Name)
            foreach (Animal a in filteredShelter)
            {
                Console.WriteLine($"{a.Name} is {a.Age} years old and has {a.NrOfLegs} legs, is a {a.Species} and is a tame {a.IsTame}");
            }

        }
    }

}