namespace Models;

public partial class Institutionsoplysninger
{
    public Guid Id { get; set; }

    public int? Nummer { get; set; }

    public string? Navn { get; set; }

    public string? Adresse { get; set; }

    public string? Postnummer { get; set; }

    public string? Hjemmeside { get; set; }

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public decimal? GeoLaengde { get; set; }

    public decimal? GeoBredde { get; set; }

    public Institutionsoplysninger(Guid id, int? nummer, string? navn, string? adresse, string? postnummer, string? hjemmeside, string? email, string? telefon, decimal? geoLaengde, decimal? geoBredde)
    {
        Id = id;
        Nummer = nummer;
        Navn = navn;
        Adresse = adresse;
        Postnummer = postnummer;
        Hjemmeside = hjemmeside;
        Email = email;
        Telefon = telefon;
        GeoLaengde = geoLaengde;
        GeoBredde = geoBredde;
    }
}
