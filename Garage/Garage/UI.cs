using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Garage
{
    internal class UI
    {

            public void MainMenu()
            {
                bool Keeprunning = true;
                while (Keeprunning)
                {
                    Console.Clear();
                    Console.WriteLine("Enter number for choice");
                    Console.WriteLine("1) Start a new garage");
                    Console.WriteLine("0) Quit");

                    string Input = Console.ReadLine();                                  //ReadKey().KeyChar

                    switch (Input)
                    {
                        case "1":
                        NewGarage();
                            break;
                    case "0":
                            Keeprunning = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect Input");
                            break;
                    }
                    Console.Write("\n<PRESS ANY BUTTON TO CONTINUE>");
                    Console.ReadKey();
                }
            }
        
        public void NewGarage()
            {
            Console.Write("Please enter the capacity of your garage:");
            int cap;
            do
            {
                bool input =int.TryParse(Console.ReadLine(), out cap);
                if (input==true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You should input the capacity numerically");
                }
            } while (true);

            GarageClass<Vehicle> garageClass = new GarageClass<Vehicle>(cap);


            bool Keeprunning = true;
            while (Keeprunning)
            {
                Console.Clear();
                Console.WriteLine("Enter number for choice");
                Console.WriteLine("1) Car");
                Console.WriteLine("2) Boat");
                Console.WriteLine("3) Bus");
                Console.WriteLine("4) Motorcycle");
                Console.WriteLine("5) Airplane");
                Console.WriteLine("0) Quit");

                string Input = Console.ReadLine();                                  //ReadKey().KeyChar

                switch (Input)
                {
                    case "1":
                        NewGarage();
                        break;
                    case "0":
                        Keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }
                Console.Write("\n<PRESS ANY BUTTON TO CONTINUE>");
                Console.ReadKey();
            }

          
                //garageClass.Add(new Animal(23, "Trump", "Orange", 2, false));

                ///*
                //foreach (var item in collection. Where (x=> x.Property))
                //{

                //}*/

                //var filteredShelter = garageClass.Where(x => x.NrOfLegs > 2 || x.Species == "Orange").OrderBy(x => x.IsTame).OrderBy(x => x.Age).OrderBy(x => x.Name);

                //foreach (var animal in filteredShelter)
                //{
                //    Console.WriteLine(animal.Name + "is " + animal.Age + " years old has " + animal.NrOfLegs + " legs, is a " + animal.Species + " and is tame = " + animal.IsTame);
                //}

            
        }
    
    }
}