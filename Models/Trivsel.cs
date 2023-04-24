namespace Models;

public partial class Trivsel
{
    public Guid Id { get; set; }

    public int? Institutionsnummer { get; set; }

    public string? Sporgsmaalsnummer { get; set; }

    public int? Svarnummer { get; set; }

    public int? Koen { get; set; }

    public decimal? Vaerdi { get; set; }

    public Trivsel(Guid id, int? institutionsnummer, string? sporgsmaalsnummer, int? svarnummer, int? koen, decimal? vaerdi)
    {
        Id = id;
        Institutionsnummer = institutionsnummer;
        Sporgsmaalsnummer = sporgsmaalsnummer;
        Svarnummer = svarnummer;
        Koen = koen;
        Vaerdi = vaerdi;
    }
}
