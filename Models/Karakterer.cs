namespace Models;

public partial class Karakterer
{
    public Guid Id { get; set; }

    public int? Institutionsnummer { get; set; }

    public int? Koen { get; set; }

    public string? Skoleaar { get; set; }

    public int? Klassetrin { get; set; }

    public decimal? Gennemsnit { get; set; }

    public Karakterer(Guid id, int? institutionsnummer, int? koen, string? skoleaar, int? klassetrin, decimal? gennemsnit)
    {
        Id = id;
        Institutionsnummer = institutionsnummer;
        Koen = koen;
        Skoleaar = skoleaar;
        Klassetrin = klassetrin;
        Gennemsnit = gennemsnit;
    }
}
