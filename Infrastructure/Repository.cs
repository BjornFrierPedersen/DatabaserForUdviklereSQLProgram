using Models;

namespace Infrastructure;

public class Repository
{
    private SkoleinfoContext _dbContext;
    public Repository(SkoleinfoContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void CreateRandomDataset(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            var random = new Random();
            var koen = random.Next(1, 2);
            // Kommune
            var maxKommuneNummer = _dbContext.Kommuners.Max(kommune => kommune.Nummer) + 1;
            var kommune = new Kommuner(Guid.NewGuid(), maxKommuneNummer, $"kommune_{maxKommuneNummer}");
            _dbContext.Kommuners.Add(kommune);

            // Institution
            var maxInstitutionsNummer = _dbContext.Institutioners.Max(institution => institution.Nummer) + 1;
            var newInstitutionNavn = $"Institution_{maxInstitutionsNummer}";
            var institution =
                new Institutioner(Guid.NewGuid(), maxInstitutionsNummer, newInstitutionNavn, kommune.Nummer);
            _dbContext.Institutioners.Add(institution);

            // Institutionsoplysninger
            var institutionsoplysninger = new Institutionsoplysninger(Guid.NewGuid(), institution.Nummer,
                newInstitutionNavn, $"{newInstitutionNavn}_adresse", "0000", string.Empty, string.Empty, string.Empty,
                null,
                null);
            _dbContext.Institutionsoplysningers.Add(institutionsoplysninger);

            // Karakterer
            var karakter = new Karakterer(Guid.NewGuid(), institution.Nummer, koen, "2022/2023",
                random.Next(1, 10), random.Next(1, 12));
            _dbContext.Karakterers.Add(karakter);

            for (int y = 0; y < 3; y++)
            {
                // Spoergsmaal
                var spoergsmaal = _dbContext.Sporgsmaals.ToList()[random.Next(1, 50)];

                // Svar
                var maxSvarnummer = _dbContext.Svars.Max(svar => svar.Svarnummer) + 1;
                var svarTexts = _dbContext.Svars.Select(svar => svar.Tekst).ToList();
                var svar = new Svar(Guid.NewGuid(), spoergsmaal.Nummer, maxSvarnummer,
                    svarTexts.OrderBy(s => Guid.NewGuid()).First());
                _dbContext.Svars.Add(svar);
                
                // Trivsel
                var trivsel = new Trivsel(Guid.NewGuid(), institution.Nummer, spoergsmaal.Nummer, svar.Svarnummer, koen,
                    random.Next(1, 100));
                _dbContext.Trivsels.Add(trivsel);
            }
            _dbContext.SaveChanges();
        }
    }
}