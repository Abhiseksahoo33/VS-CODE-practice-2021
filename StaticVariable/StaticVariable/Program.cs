using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    class Program
    {

        static int score;
        int record;

        public  void count (int x)
        {
            score += x;  // retain value irrespective of the type of object 
            // get the memory only once and share it among all the objects 
            record += x;

        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program();
            Program obj3 = new Program();
            obj1.count(14);
            obj2.count(18);
            obj3.count(15);

            Console.WriteLine("score is " +score ); // output 47 
            Console.WriteLine("score is " +obj1.record ); // output 14 object reference is required for non static variables 
        }
    }
}
