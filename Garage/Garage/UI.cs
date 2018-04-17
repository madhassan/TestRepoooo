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
        private int Capacity { get; set; }
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
                        AddingVehicle();
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

        public int NewGarage()
        {
            int cap;
            Console.Write("Please enter the capacity of your garage:");
            
            do
            {
                bool input = int.TryParse(Console.ReadLine(), out cap);
                if (input == true)
                {
                    Capacity = cap;
                    return Capacity;
                }
                else
                {
                    Console.WriteLine("You should input the capacity numerically");
                }
            } while (true);
          
        }

        public void AddingVehicle()
        {
            var garage = new Garage<Vehicle>(Capacity);


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
                Console.WriteLine("6) Moped");
                Console.WriteLine("7) Check parked vehicles");
                Console.WriteLine("8) Remove a vehicle");
                Console.WriteLine("0) Quit");

                string Input = Console.ReadLine();  
                    int length, noOfSeats, numberOfengines,padels;
                     string fuelType;
                     bool  endLoop2 = true;
                     float cylinderVolume;
                if (Input == "1")
                {
                    VehicleProperties();
                    Console.WriteLine("Enter the cylinder volume:");
                    do
                    {
                        bool input = float.TryParse(Console.ReadLine(), out cylinderVolume);
                        if (input == true)
                        {
                            endLoop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("You should input the cylindervolume numerically(float)");
                        }
                    } while (endLoop2);

                    garage.Add(new Car(RegistrationNumber, Color, NOfWheels, cylinderVolume));
                }
                else if (Input == "2")
                {
                    VehicleProperties();
                    Console.WriteLine("Enter the fueltype:");
                    fuelType = Console.ReadLine();

                    garage.Add(new Boat(RegistrationNumber, Color, NOfWheels, fuelType));
                }
                else if (Input == "3")
                {
                    VehicleProperties();
                    Console.WriteLine("Enter the number of seats:");
                    do
                    {
                        bool input = int.TryParse(Console.ReadLine(), out noOfSeats);
                        if (input == true)
                        {
                            endLoop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("You should input the number of seats numerically");
                        }
                    } while (endLoop2);
                    garage.Add(new Bus(RegistrationNumber, Color, NOfWheels, noOfSeats));
                }
                else if (Input == "4")
                {
                    VehicleProperties();
                    Console.WriteLine("Enter the length:");
                    do
                    {
                        bool input = int.TryParse(Console.ReadLine(), out length);
                        if (input == true)
                        {
                            endLoop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("You should input the length number numerically");
                        }
                    } while (endLoop2);
                    garage.Add(new Motorcycle(RegistrationNumber, Color, NOfWheels, length));
                }
                else if (Input == "5")
                {
                    VehicleProperties();
                    Console.WriteLine("Enter the number of engines :");
                    do
                    {
                        bool input = int.TryParse(Console.ReadLine(), out numberOfengines);
                        if (input == true)
                        {
                            endLoop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("You should input the number numerically");
                        }
                    } while (endLoop2);
                    garage.Add(new Airplane(RegistrationNumber, Color, NOfWheels, numberOfengines));
                }
                else if (Input == "6")
                {
                    VehicleProperties();
                    Console.WriteLine("Enter the number of padels:");
                    do
                    {
                        bool input = int.TryParse(Console.ReadLine(), out padels);
                        if (input == true)
                        {
                            endLoop2 = false;
                        }
                        else
                        {
                            Console.WriteLine("You should input the number numerically");
                        }
                    } while (endLoop2);
                    garage.Add(new Mopeds(RegistrationNumber, Color, NOfWheels, padels));
                    
                }
                
                else if (Input == "7")
                {
                    for (int i = 0; i < Capacity; i++)
                    {
                        Console.WriteLine(garage.vehicles[i]);
                    }
                        
                    
                    Console.WriteLine("Press enter to go back");
                    Console.ReadLine();
                }
                else if (Input == "8")
                {
                    Console.WriteLine("Enter the vehicle registration number to unpark it :");
                    garage.Remove(RegistrationNumber = Console.ReadLine()) ;
                }
                else if (Input == "0")

                    Keeprunning = false;
                
                else
                    Console.WriteLine("Incorrect Input");

            }
            Console.Write("\n<PRESS ANY BUTTON TO GO BACK>");
            Console.ReadKey();
            
        }
        public void VehicleProperties()
        {
            string registrationNo,color;
            int nOfWheels;
            bool endLoop = true;
            Console.WriteLine("Enter the registration number:");
            registrationNo = Console.ReadLine();
            RegistrationNumber = registrationNo;
            Console.WriteLine("Enter the color:");
            color = Console.ReadLine();
            Color = color;
            Console.WriteLine("Enter the number of wheels:");
            do
            {
                bool input = int.TryParse(Console.ReadLine(), out nOfWheels);
                if (input == true)
                {
                    NOfWheels = nOfWheels;
                    endLoop = false;
                }
                else
                {
                    Console.WriteLine("You should input the number numerically");
                }
            } while (endLoop);
        }
        private int NOfWheels { get; set; }
        private string Color { get; set; }
        private string RegistrationNumber { get; set; }
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
    
    
