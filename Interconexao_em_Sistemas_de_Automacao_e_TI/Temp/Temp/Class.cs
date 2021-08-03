using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temp
{
    public class Class
    {

        public static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");

            foreach (string item in cities)
            {
                Console.WriteLine(item);
            }

        }


        }
    }
