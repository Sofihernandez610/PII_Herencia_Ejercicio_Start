using System;
using System.Collections;
using Library;

namespace PII_Herencia
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Person pasajero1 = new Passenger("Juan", "Perez", 123451234, 10);
            Person pasajero2 = new Passenger("Martin", "Gonzalez", 98769876, 9);

            Person conductor1 = new Driver("Juan", "Perez", 123451234, 10, "Volkswagen up");
            Person conductorPool1 = new PoolDriver("Paula", "Perez", 4566540, 9, "Ford Ranger", 8);
            UcuRideShare rideShare = new UcuRideShare();

            rideShare.AddUser(conductor1);
            

            rideShare.AddUser(conductorPool1);
          

            rideShare.AddUser(pasajero1);
            

            rideShare.AddUser(pasajero2);
              



            foreach (var user in rideShare.users)
            {
                Console.WriteLine(user.Name);
            }



           


        
        }
    }
}
