using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Rental_Case_Study
{
    class Sprint3_1
    {

        public  string[] arr = new string[5];
         public void NameOrder()
        {
            Console.WriteLine("enter the names for the toys");
            for(int i=0;i<5;i++)
            {
                arr[i] = Console.ReadLine();

            }

            Array.Sort(arr);
            Console.WriteLine("Toys in ascending order are");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

    }


}



