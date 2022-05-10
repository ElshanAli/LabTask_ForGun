using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task.Models
{
    class Gun
    {
        public string Type;
        public byte TotalBulletSize;
        public  byte MagazineSize;
        public byte BulletLeft;      
        byte count = 0;      
        public Gun()
        {
           
        }
        
        public void Shoot()
        {
            BulletLeft = MagazineSize;
            BulletLeft -= count;
            if (BulletLeft==0)
            {               
                Console.WriteLine(" You can't shoot because there are no bullets");
                return;
            }
            else
            {              
                Console.WriteLine($" You have {--BulletLeft} bullet");
                count++;
            }
        }
        public void FullShoot()
        {
           if (BulletLeft!=0)
            {              
                count = MagazineSize;             
                BulletLeft = 0;
            }          
        }
        public void Reload()
        {
            if (TotalBulletSize==0)
            {
                Console.WriteLine(" Empty bulletsize");
                return;
            }
            else
            {
                TotalBulletSize -=count;
                BulletLeft = MagazineSize;               
                count = 0;
                Console.WriteLine($" You have {TotalBulletSize} bullet");
            }          
        }
        public void Bulletleft()
        {
           
            Console.WriteLine($"You have {BulletLeft} Bulletleft");
        }  
       
        public void GetInformation()
        {
            //BulletLeft -=count;
            Console.WriteLine($" Gun name : {Type} \n Total size: {TotalBulletSize} \n Gun Magazine size { MagazineSize} \n BulletLeft {BulletLeft}");
        }
    }
}
