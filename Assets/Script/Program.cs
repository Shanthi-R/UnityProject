using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    class Program
    {
        delegate int twoParamMethods(int a, int b);
        public static int add(int a, int b)
        {
            Console.WriteLine("Add called");
            return a + b;
        }
        public int subtract(int a,int b)
        {
            Console.WriteLine("Subtract called");
            return a - b;
        }
        static void main(string[]args)
        {
            twoParamMethods delobj = new twoParamMethods(add);
           // twoParamMethods delobj = add;
            delobj.Invoke(20, 30);
            delobj(10, 20);
            Program pgmobj = new Program();
            delobj = pgmobj.subtract;
            int SubTotal = delobj(10, 5);
            Console.ReadKey();

 
        }
    }
}