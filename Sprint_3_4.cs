using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Rental_Case_Study
{
    class Sprint_3_4
    {

      public   bool Liner_search(string[,,] a)
        {
            Console.WriteLine("Enter the Customer Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        if (Equals(a[i, j, k], name))
                            return true;

                    }
                }
            }
            return false;
        }

    }
}
