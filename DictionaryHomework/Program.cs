using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        { 

    //Dictionary Homework - Create dictionary with 6 animals, run queries against it and think of 
    //of ways to make queries more effient

         Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("panda", 4);
            animals.Add("grizzly", 4);
            animals.Add("Tucan", 2);
            animals.Add("Octopus", 8);
            animals.Add("sea horse", 0);
            animals.Add("Otter", 4);

            //Demo way to get the value of legs. 
            if (animals.ContainsKey("panda"))
            {
                int legValue = animals["panda"];
                Console.WriteLine("Panda has " + legValue + " legs.");
            }


            //second way to get value of legs more effienctly.
                  foreach (KeyValuePair<string, int> item in animals)
                {
                   Console.WriteLine(item.Key + " has " + item.Value + " legs.");
                 }

            Console.ReadLine();
        }
    }
}
