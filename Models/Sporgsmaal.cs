namespace Models;

public partial class Sporgsmaal
{
    public Guid Id { get; set; }

    public string? Nummer { get; set; }

    public string? Tekst { get; set; }

    public Sporgsmaal(Guid id, string? nummer, string? tekst)
    {
        Id = id;
        Nummer = nummer;
        Tekst = tekst;
    }
}
