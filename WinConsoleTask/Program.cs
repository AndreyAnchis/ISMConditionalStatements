using System;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            try { 
            Console.Write("X = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Z = ");
            double z = Convert.ToDouble(Console.ReadLine());
            double s;
            s = (2 * Math.Cos(Math.Pow(x, 2)) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, 2 - z))) + (Math.Pow(z, 2) / (7 - z / 3));
            Console.WriteLine("S = {0:F3} ", s);
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Помилка вводу даних");
            }
            Console.ReadKey();
        }
    }
}
