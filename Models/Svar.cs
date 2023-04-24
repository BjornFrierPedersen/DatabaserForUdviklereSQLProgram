namespace Models;

public partial class Svar
{
    public Guid Id { get; set; }

    public string? Sporgsmaalsnummer { get; set; }

    public int? Svarnummer { get; set; }

    public string? Tekst { get; set; }

    public Svar(Guid id, string? sporgsmaalsnummer, int? svarnummer, string? tekst)
    {
        Id = id;
        Sporgsmaalsnummer = sporgsmaalsnummer;
        Svarnummer = svarnummer;
        Tekst = tekst;
    }
}
