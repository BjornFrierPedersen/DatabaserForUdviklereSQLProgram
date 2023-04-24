namespace Models;

public partial class Institutioner
{
    public Guid Id { get; set; }

    public int Nummer { get; set; }

    public string Navn { get; set; } = null!;

    public int Kommunenummer { get; set; }

    public Institutioner(Guid id, int nummer, string navn, int kommunenummer)
    {
        Id = id;
        Nummer = nummer;
        Navn = navn;
        Kommunenummer = kommunenummer;
    } 
}
