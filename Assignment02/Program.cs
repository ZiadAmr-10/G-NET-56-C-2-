using System.Drawing;
using System.Reflection.Metadata;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);
            //It prints 9 because the decimal part is removed when casting to int
            #endregion
            #region Question02
            //int n = 5;
            //double d2 = (float)n / 2;
            //Console.WriteLine(d2);
            #endregion
            #region Question03
            //int Age;
            //Console.WriteLine("Enter Age : ");
            //Age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Age : {Age}");
            #endregion
            #region Question04  
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            //It will be a FormatException because the string contains a character and cannot be converted to an int
            #endregion
            #region Question05
            //string s = "12a";
            //int x;
            //if (int.TryParse(s,out x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}  
            #endregion
            #region Question06
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            //It prints 11 because 10 is stored in an object(boxing).
            //Then it is converted to an int(unboxing), the value is 10 + 1=11
            #endregion
            #region Question07
            //object o = 10;
            //long x = (long)o;
            //Console.WriteLine(x);
            //Its an InvalidCastException because the object contains an int(boxeing int->obj),
            //Should unbox it to its original type(int) first, then convert it to long.
            //object o = 10; //Boxing int->obj
            //int a = (int)o; //Unboxing obj->int
            //long x = (long)a; //Casting(int->long)
            //Console.WriteLine(x);
            #endregion
            #region Question08
            object o = 10;
            long x;
            if (o is int)
            {
                x = (int)o;
            }
            else {
                x = -1;
                    }
                Console.WriteLine(x);
            #endregion
        }
    }
}
