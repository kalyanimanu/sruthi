using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pre defined class libraries

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
          g:  Console.WriteLine("please enter day:");

            string day = Console.ReadLine();


           switch (day)
            {
                case "Mon":
                    Console.WriteLine("working day:");
                    break;
                case "Tues":
                    Console.WriteLine("working day:");
                    break;
                case "Wed":
                    Console.WriteLine("working day:");
                    break;
                case "Thurs":
                    Console.WriteLine("working day:");
                    break;
                case "Fri":
                    Console.WriteLine("working day:");
                    break;
                case "Sat":
                    Console.WriteLine("Not working day:");
                    break;
                case "Sun":
                    Console.WriteLine("Not working day:");
                    break;

                default:
                    Console.WriteLine("not a  valid day:");
                    break;
            }
           goto g;
            Console.ReadKey();
            //printf
        }
    }
}
