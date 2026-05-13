namespace DeWereld;

class ProjectPerson
{
    public string? First { get; set; }
    public string  Last { get; set; }
}


internal class Program
{
    static void Main(string[] args)
    {
        var people = GenerateList(1000);
        var filtered = people.Where(p=>p.Voornaam.StartsWith("S"));

        var project = people.Select(p => new { First = p.Voornaam, Last = p.Achternaam });
        foreach(var pp in project)
        {
            Console.WriteLine($"{pp.First} {pp.Last}");
        }



        foreach (Persoon p in filtered)
        {
            //Console.WriteLine(p);
        }
    }

    static bool VoornaamBeginnendMetP(Persoon p)
    {
        return p.Voornaam.StartsWith("P");
    }
    static bool AchternaamBeginnendMetK(Persoon p)
    {
        return p.Achternaam.StartsWith("K");
    }

    static List<Persoon> GenerateList(int amount)
    {
        return new Bogus.Faker<Persoon>()
               .RuleFor(p => p.Id, (f, u) => f.UniqueIndex)
               .RuleFor(p => p.Voornaam, (f, u) => f.Name.FirstName())
               .RuleFor(p => p.Achternaam, (f, u) => f.Name.LastName())
               .RuleFor(p => p.Leeftijd, (f, u) => f.Random.Int(0, 123))
               .Generate(amount)
               .ToList();

    }
}
