namespace Models;

public partial class Kommuner
{
    public Guid Id { get; set; }

    public int Nummer { get; set; }

    public string Navn { get; set; }

    public Kommuner(Guid id, int nummer, string navn)
    {
        Id = id;
        Nummer = nummer;
        Navn = navn;
    }
}
