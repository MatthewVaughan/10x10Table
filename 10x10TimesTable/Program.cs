using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _10x10TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {

            //Intro to Console application
            WriteLine("This table helps you reference your basic times tables\n\n");

            //Create an outer loop to denote 10 lines of data
            for (int i = 1; i < 11; i++)
            {
                //Create inner loop to denote 10 columns of data
                for (int j = 1; j < 11; j++)
                {
                    //display the outer loops index multiplied by our innerloops index 
                    Write($"{i * j}\t");
                }

                //Display a new line
                Write("\n");
            }

            //Hault program
            ReadLine();
        }
    }
}
