using Lab_Task.Models;
using System;

namespace Lab_Task
{
    class Program
    {       
        static void Main(string[] args)
        {          
            Gun gun = new Gun();
            Console.WriteLine(" Enter the Gun Name");
            gun.Type = Console.ReadLine();
            Console.WriteLine("\n Select the volume of TotalBulletSize");
            gun.TotalBulletSize = Convert.ToByte(Console.ReadLine());      
            Console.WriteLine("\n Select MagazineSize");
            gun.MagazineSize = Convert.ToByte(Console.ReadLine());
            gun.BulletLeft = gun.MagazineSize;
        NewPlace:
            Console.WriteLine($" 1. Shoot \n 2. FullShoot \n 3. Reload \n 4. BulletLeft \n 5. GunIformation  \n 6. Clear \n 7. Finish the program");
            Console.WriteLine("\n Please choose one of them");
            byte num = Convert.ToByte(Console.ReadLine());
            switch (num)
            {
                case (byte)GunsName.Shoot:                  
                    gun.Shoot();
                  goto NewPlace;

                case (byte)GunsName.FullShoot:                   
                    gun.FullShoot();
                    goto NewPlace;

                case (byte)GunsName.Reload:                  
                    gun.Reload();
                    goto NewPlace;

                case (byte)GunsName.BulletLeft:                   
                    gun.Bulletleft();
                    goto NewPlace;

                case (byte)GunsName.GunInformation:                  
                    gun.GetInformation();
                    goto NewPlace;

                case (byte)GunsName.Clear:
                    Console.Clear();
                    goto NewPlace;
                case (byte)GunsName.Exit:
                    break;
            }
        }
    }
}
 