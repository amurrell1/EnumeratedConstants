using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
    class Program
    {
        enum Color
        {
            Red,
            Blue,
            White, 
        }


        static void Main(string[] args)
        {
            Color favorite = Color.White;
            switch(favorite)
            {
                case Color.Blue:
                    Console.WriteLine("Blue is your favorite color silly!");
                    break; 
            }
        }
    }
}
