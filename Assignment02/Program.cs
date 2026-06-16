using System.Diagnostics;
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
            //object o = 10;
            //long x;
            //if (o is int)
            //{
            //    x = (int)o;
            //}
            //else {
            //    x = -1;
            //        }
            //    Console.WriteLine(x);
            #endregion
            #region Question09
            //string? name = null;
            //Console.WriteLine(name?.Length);
            //It prints nothing (null) because ?. checks if the value is null before accessing .
            //Without ?,its throw NullReferenceException 
            #endregion
            #region Question10
            //string ? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);
            // It prints 0 because name2 is null.The (null-conditional operator ?) prevents accessing Length when the value is null.
            //name2?.Length becomes null.Then the (null-coalescing operator ??) replaces the null value with 0.
            #endregion
            #region Question11
            //string? s = null;
            //int x = int.Parse(s ?? "0");
            //Console.WriteLine(x);
            //TryParse is better because it does not throw a FormatException if the input contains characters.
            //If the value is null or not a number,returns 0.
            //string? s = null;
            //int x;
            //if (int.TryParse(s, out x))
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}
            #endregion
            #region Question12
            //string? s = null;
            //Console.WriteLine(s!.Length);
            //! -> its null forgive "I know this is not null." but this is null
            //string? s = null;
            //Console.WriteLine(s?.Length??0);
            #endregion
            #region Question13
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);
            //It prints 0 because `Convert.ToInt32(null)` returns 0 instead of throwing an exception.
            #endregion
            #region Question14
            //string? s = null;
            //int a = int.Parse(s);
            //Console.WriteLine(a);
            //throws a FormatException because int.Parse cannot handle null or strings
            //int b = Convert.ToInt32(s);
            //Console.WriteLine(b);
            //returns 0 because Convert.ToInt32 handles null values and returns the default integer value = 0
            #endregion
            #region Question15
            //string? user = null;
            //Console.WriteLine((user ?? "Guest").ToUpper());
            #endregion
        }
    }
}
