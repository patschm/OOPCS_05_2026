namespace FunPro;


class Program
{
    static void Main(string[] args)
    {
        ToonWelkomsScherm();
        //int a = GeefGetal("A");
        //int b = GeefGetal("B");
        //int result = TelOp(a, b, 4);

        int result = TelOp(ccc:3, aaa:6);
        System.Console.WriteLine(result);

        int y = 10;
        DoeIets(out y);
        System.Console.WriteLine(y);
        int z;

        DoeIets(out z);
        System.Console.WriteLine(z);

        string snr = "x43";
       // int h;
        bool ok = int.TryParse(snr,  out int h );
        System.Console.WriteLine(h);

    }

    static void DoeIets(out int xxx)
    {
        xxx = 1000;
    }

    static void ToonWelkomsScherm()
    {
        System.Console.WriteLine("Welkom!!");
    }

    static int GeefGetal(string label)
    {
        System.Console.WriteLine($"Geef een getal {label}");
        var inp = Console.ReadLine();
        int a = int.Parse(inp!);
        return a;
    }
    static int TelOp(int aaa, int bbb)
    {
        return aaa+bbb;
    }
    
    static int TelOp(params int[] nummers)
    {
        return nummers.Sum();
    }

    static int TelOp(int aaa = 1, int bbb = 5, int ccc = 10)
    {
       System.Console.WriteLine("Drie");
        return aaa+bbb+ccc;
    }
}
