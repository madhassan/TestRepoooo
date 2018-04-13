using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class GarageHandler
    {
       
            public Vehicle CreateVehicle(int registrationNo, string color, int numberOfwheels)
            {
                Vehicle vehicle = new Vehicle(registrationNo,color,numberOfwheels);
                vehicle.RegistrationNumber = registrationNo;
                vehicle.Color = color;
                vehicle.NumberofWheels = numberOfwheels;


                return vehicle;
            }
            public void SetRegistrationNumber(Vehicle vehicle, int registrationNo)
            {
                vehicle.RegistrationNumber = registrationNo;
            }
            public int GetRegistrationNumber(Vehicle vehicle)
            {
                return vehicle.RegistrationNumber;
            }
            public void SetColor(Vehicle vehicle, string color)
            {
                vehicle.Color = color;
            }
            public string GetColor(Vehicle vehicle)
            {
                return vehicle.Color;
            }
            public void SetNumberofWheels(Vehicle vehicle, int numberofWheels)
            {
                vehicle.NumberofWheels = numberofWheels;
            }
            public int GetNumberofWheels(Vehicle vehicle)
            {
                return vehicle.NumberofWheels;
            }


        public Car CreateCar(int registrationNo, string color, int numberOfwheels,float cylinderVolume)
        {
            Car car = new Car(registrationNo, color, numberOfwheels,cylinderVolume);
            vehicle.RegistrationNumber = registrationNo;
            vehicle.Color = color;
            vehicle.NumberofWheels = numberOfwheels;


            return car;
        }
        public void SetRegistrationNumber(Vehicle vehicle, int registrationNo)
        {
            vehicle.RegistrationNumber = registrationNo;
        }
        public int GetRegistrationNumber(Vehicle vehicle)
        {
            return vehicle.RegistrationNumber;
        }

    }
}
