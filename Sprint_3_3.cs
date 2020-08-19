using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Rental_Case_Study
{
    class Sprint_3_3
    {
        public void CustomerDetailsSort()
        {

            string[,,] s = new string[1,3,3];

            Console.WriteLine("enter customerid,name,adress");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        s[i, j, k] = Console.ReadLine();
                    }
                }
            }

            Sprint_3_4 s4 = new Sprint_3_4();
             bool res = s4.Liner_search(s);
            if(res==true)
            {
                Console.WriteLine("customer is available");
            }
            else
            {
                Console.WriteLine("customer is not available");
            }




        }
         



    }


}
