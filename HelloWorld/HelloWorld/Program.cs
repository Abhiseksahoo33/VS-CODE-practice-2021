using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    class Data
    {
        public void m1()
        {
            Console.WriteLine("hii i m in  public method 1 - ");
        }
        internal void m2()
        {
            Console.WriteLine("hii i m in internal  method 2 - ");
        }
        private void m3()
        {
            Console.WriteLine("hii i m in  private method 3 - ");
        }
        protected  void m4()
        {
            Console.WriteLine("hii i m in  protected  method 4 - ");
        }
        protected internal void m5()
        {
            Console.WriteLine("hii i m in  protected internal  method 5 - ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to . net framework ...-c  .  example of access modifier ");
            Data obj = new Data();
            obj.m1(); // public method can accessable
            obj.m2();// internal can access in all classes of current namespace .
            //obj.m3(); // can't access
            //obj.m4(); // can't access
            obj.m5(); // protected internal can 
            //  private and protected can't be access from outside the class 

        }
    }
}


