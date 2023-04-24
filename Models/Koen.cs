namespace Models;

public partial class Koen
{
    public int Id { get; set; }

    public string Navn { get; set; }

    public Koen(int id, string navn)
    {
        Id = id;
        Navn = navn;
    }
}
