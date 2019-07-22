using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdileneHello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*suma
            // variable initalization

            int a = 5, b = 3, c;

            //variables reassignament
            a = 10;
            b = 20;
            c = a + b;
            //usamos llaves para dividir los parametros
            Console.Write(" a = {0} , b={1}, c= {2}" , a,b,c);
            Console.ReadLine();
            */


            /***************OPERADORES ************************************/

            //int a = 10, b = 20;
            //Console.WriteLine("a == b is {0} \n", a == b); /*equals*/
            //Console.WriteLine("a != b is {0} \n", a != b); /*Not equals*/
            //Console.WriteLine("a > b is {0} \n", a > b); /*greater*/
            //Console.WriteLine("a < b is {0} \n", a < b); /*less*/
            //Console.WriteLine("a >= b is {0} \n", a >= b); /*greater or equals*/
            //Console.WriteLine("a <= b is {0} \n", a <= b); /*less or equals*/
            //Console.ReadLine();
            /*********************************************************************/


            /***************OPERADORES LOGICOS***********************************/

            //int a = 10, b = 20;
            //Console.WriteLine("a == b is {0} \n", a == b); /*equals*/
            //Console.WriteLine("a != b is {0} \n", a != b); /*Not equals*/
            //Console.WriteLine("a > b is {0} \n", a > b); /*greater*/
            //Console.WriteLine("a < b is {0} \n", a < b); /*less*/
            //Console.WriteLine("a >= b is {0} \n", a >= b); /*greater or equals*/
            //Console.WriteLine("a <= b is {0} \n", a <= b); /*less or equals*/
            //Console.ReadLine();
            /*********************************************************************/


            /* bool p, q;

             Console.WriteLine("p\t Q\t and \t OR \t XOR \t NOT(P) \n");

             p = true; q = true;
             Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

             p = true; q = false;
             Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

             p = true; q = true;
             Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

             p = true; q = false;
             Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));
             Console.ReadLine();


             //*****************+OPERACIONES***************+**\
             bool p, q;

             /* table header */
            /* Console.WriteLine("P \t Q \t AND \t OR \t XOR \t NOT(P) \n");


            p = true; q = true;
            Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));
           
            p = true; q = false;
            Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

            p = false; q = true;
            Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

            p = false; q = false;
            Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

            Console.ReadLine();
        }
    }
    
            /* example 2 assignment operators */


            double a = 5, b = 6, c;

            /* standard assignment */
            c = a + b;
            Console.WriteLine("standard assignment c = a+b " + c + "\n");

            /* and assign a += b is equivalent to a = a + b */
            Console.WriteLine("And assign a += b " + (a += b) + "\n");

            a = 5;
            /* subtract assign a -= b is equivalent to a = a - b */
            Console.WriteLine("Subtract assign a -= b " + (a -= b) + " \n");

            a = 5;
            /* multiply assign a *= b is equivalent to a = a * b */
            Console.WriteLine("Multiply assign a *= b " + (a *= b) + "\n");

            a = 5;
            /* divide assign a /= b is equivalent to a = a / b */
            Console.WriteLine("Divide assign a /= b " + (a /= b) + "\n");

            a = 5;
            /* Mod assign a %= b is equivalent to a = a % b */
            Console.WriteLine("Mod assign a %= b " + (a %= b) + "\n");

            Console.ReadLine();
        }
    }
}
