using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace first_program
{
    class Program {
        // write in console
        static void Main(string [] args ) {
            int a, b = 0;
            Console.Write("Write a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write a number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b) {
                Console.WriteLine (" 1º maior"); }
                else if (a < b ) {
                    Console.WriteLine (" 1º maior");
                    }
                    else {
                        Console.WriteLine ("Igual"); 
                    }
        }
    }
}
        
        
    
