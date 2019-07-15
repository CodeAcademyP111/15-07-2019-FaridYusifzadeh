using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDelegate
{
    class Program
    {
        public static float money = 50;
        public delegate void NotMoney(int n);

        public delegate void NumbersInt(int num);

        static void Main(string[] args)
        {
            //Bankomat(60, Money);
            NumbersInt n = new NumbersInt(CheckInteger);
            n(3);

        }


        static void Bankomat(int m , NotMoney Money)
        {
            Money(m);
        }

        static void Money(int n)
        {
            if(n < money)
            {
                money -= n;
                Console.WriteLine($"qaliq pul : {money} " );
            }
            else
            {
                Console.WriteLine("pul yoxdur");
            }


        }






        public static void CheckInteger(int num)
        {
            bool tag =false;
            

            if (num < 0)
            {
                Console.WriteLine("Menfi ededdir");
            }
            else
            {
                Console.WriteLine("Musbet ededdir");
            }

            for (int i = 2; i < num; i++)
            {
                if(num % i==0)
                {
                    tag = true;
                }
            }

            if (tag)
            {
                Console.WriteLine("Sade eded deil");

               

                if (num % 2 ==0)
                {
                    Console.WriteLine("Cut ededdir");
                }

            }
            else
            {
                Console.WriteLine("Sade ve Tek ededdir");

                
            }
           
          

        }
    }
}
