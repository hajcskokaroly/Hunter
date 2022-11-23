using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals = new Animal[3];


            animals[0] = new Squirrel();
            animals[1]=new Rabbit();
            animals[2]=new PolarBear();

            for (int i = 0; i < animals.Length; i++)
                Console.WriteLine(animals[i].GetType()+ animals[i].getPrice());
            Console.ReadKey();
        }
    }
}
