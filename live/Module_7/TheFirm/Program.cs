namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        ACME comp = new ACME();
        Janine janine = new Janine();   
        Wim wim = new Wim();
        Jaco jaco = new();
        Bokito bok = new Bokito();

        comp.Hire(bok);
        comp.Hire(janine);
        comp.Hire(wim);
        comp.Hire(jaco);
        comp.StartProduction();


        (bok as IContract2)?.DoWork();
    }
}
