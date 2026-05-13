using System.Collections;
using System.Threading.Channels;

namespace Generieken;

internal class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10;i++) ;
        {
            Console.WriteLine("oops");
        }

        ArrayList list = new ArrayList();
       //List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add("4");

        foreach (object i in list)
        {
            if (i is int)  Console.WriteLine(i);
            if (i is string)  Console.WriteLine(i);
        }



        Complex<int, float> complex = new Complex<int, float> { Real = 100, Imaginary = 200 };

        Console.WriteLine(complex);

        decimal a = 10;
        decimal  b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    private static void Swap<T>(ref T a, ref T b) where T : struct, IFormattable
    {
        T c = a;
        a = b;
        b = c;
    }
    //private static void Swap(ref float a, ref float b)
    //{
    //    float c = a;
    //    a = b;
    //    b = c;
    //}
    //private static void Swap(ref int a, ref int b)
    //{
    //   int c = a;
    //    a= b;
    //    b= c;
    //}
    //private static void Swap(ref long a, ref long b)
    //{
    //    long c = a;
    //    a = b;
    //    b = c;
    //}
}
