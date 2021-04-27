using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling_try_catch
{ 
  class Demo
{
    public void check(int n)

    {
        if (n < 0)
        {
            throw new DivideByZeroException("Negative number not allowed ..");
        }
        else if (n == 0)
        {
            throw new IndexOutOfRangeException("Zero is invalid ..");
        }
        else
        {
            Console.WriteLine("N's value is :  " + n);
        }
    }
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter the value of N : ");
        n = Convert.ToInt32(Console.ReadLine());

        Demo obj = new Demo();

        try
        {
            obj.check(n);
        }
        catch (DivideByZeroException e)

        {

            Console.WriteLine(e.Message);
        }
        catch (IndexOutOfRangeException e)

        {

            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
}
