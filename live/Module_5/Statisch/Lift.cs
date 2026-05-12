namespace Statisch;

public class Lift
{
    private int _huidigeVerdieping;
    public int HuidigeVerdieping
    {
        private set
        {
            _huidigeVerdieping = value;
        }
        get
        {
            return _huidigeVerdieping;
        }
    }

    public void Call(int waarheen)
    {
        Console.WriteLine($"Lift zoemt naar de {waarheen} verdieping");
        HuidigeVerdieping = waarheen;
    }
    
}