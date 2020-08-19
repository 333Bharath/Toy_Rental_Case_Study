using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Rental_Case_Study
{
    class Sprint_3_2
    {
        public void AgeOrder()
        {
            Sprint3_1 s1 = new Sprint3_1();
            string[] arr = s1.arr;

            Console.WriteLine("enter the age of the toy");
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 & age <= 20)
                age = 1;
            else if (age > 20 & age <= 40)
                age = 2;
            else if (age > 40 & age <= 60)
                age = 3;
            else if (age > 60 & age <= 80)
                age = 4;
            else
                age = 5;

            switch (age)
            {
                case 1:
                    Console.WriteLine(arr[0]);
                    break;
                case 2:
                    Console.WriteLine(arr[1]);
                    break;
                case 3:
                    Console.WriteLine(arr[2]);
                    break;
                case 4:
                    Console.WriteLine(arr[3]);
                    break;
                case 5:
                    Console.WriteLine(arr[4]);
                    break;

            }


   
        }



    }
}
