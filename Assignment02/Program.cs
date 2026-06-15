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
        }
    }
}
