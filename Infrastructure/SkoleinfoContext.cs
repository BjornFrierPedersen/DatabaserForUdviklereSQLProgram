using Microsoft.EntityFrameworkCore;
using Models;

namespace Infrastructure;

public partial class SkoleinfoContext : DbContext
{
    public SkoleinfoContext(DbContextOptions<SkoleinfoContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=tcp:127.0.0.1;Database=skoleinfo;User Id=sa;Password=<YourStrong@Passw0rd>;TrustServerCertificate=True;");
    }

    public virtual DbSet<Institutioner> Institutioners { get; set; }

    public virtual DbSet<Institutionsoplysninger> Institutionsoplysningers { get; set; }

    public virtual DbSet<Karakterer> Karakterers { get; set; }

    public virtual DbSet<Koen> Koens { get; set; }

    public virtual DbSet<Kommuner> Kommuners { get; set; }

    public virtual DbSet<Sporgsmaal> Sporgsmaals { get; set; }

    public virtual DbSet<Svar> Svars { get; set; }

    public virtual DbSet<Trivsel> Trivsels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Institutioner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__institut__3213E83FB7A84B31");

            entity.ToTable("institutioner");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Kommunenummer).HasColumnName("kommunenummer");
            entity.Property(e => e.Navn)
                .HasMaxLength(255)
                .HasColumnName("navn");
            entity.Property(e => e.Nummer).HasColumnName("nummer");
        });

        modelBuilder.Entity<Institutionsoplysninger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__institut__3213E83FFA00B175");

            entity.ToTable("institutionsoplysninger");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(200)
                .HasColumnName("adresse");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.GeoBredde)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("geo_bredde");
            entity.Property(e => e.GeoLaengde)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("geo_laengde");
            entity.Property(e => e.Hjemmeside)
                .HasMaxLength(100)
                .HasColumnName("hjemmeside");
            entity.Property(e => e.Navn)
                .HasMaxLength(200)
                .HasColumnName("navn");
            entity.Property(e => e.Nummer).HasColumnName("nummer");
            entity.Property(e => e.Postnummer)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("postnummer");
            entity.Property(e => e.Telefon)
                .HasMaxLength(10)
                .HasColumnName("telefon");
        });

        modelBuilder.Entity<Karakterer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__karakter__3213E83F2AF8DC88");

            entity.ToTable("karakterer");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Gennemsnit)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("gennemsnit");
            entity.Property(e => e.Institutionsnummer).HasColumnName("institutionsnummer");
            entity.Property(e => e.Klassetrin).HasColumnName("klassetrin");
            entity.Property(e => e.Koen).HasColumnName("koen");
            entity.Property(e => e.Skoleaar)
                .HasMaxLength(9)
                .IsFixedLength()
                .HasColumnName("skoleaar");
        });

        modelBuilder.Entity<Koen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__koen__3213E83FF32E2762");

            entity.ToTable("koen");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Navn)
                .HasMaxLength(10)
                .HasColumnName("navn");
        });

        modelBuilder.Entity<Kommuner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kommuner__3213E83F8C266198");

            entity.ToTable("kommuner");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Navn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("navn");
            entity.Property(e => e.Nummer).HasColumnName("nummer");
        });

        modelBuilder.Entity<Sporgsmaal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sporgsma__3213E83FC80B6A8E");

            entity.ToTable("sporgsmaal");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Nummer)
                .HasMaxLength(5)
                .HasColumnName("nummer");
            entity.Property(e => e.Tekst)
                .HasColumnType("ntext")
                .HasColumnName("tekst");
        });

        modelBuilder.Entity<Svar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__svar__3213E83F3D7D08AB");

            entity.ToTable("svar");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Sporgsmaalsnummer)
                .HasMaxLength(5)
                .HasColumnName("sporgsmaalsnummer");
            entity.Property(e => e.Svarnummer).HasColumnName("svarnummer");
            entity.Property(e => e.Tekst)
                .HasColumnType("ntext")
                .HasColumnName("tekst");
        });

        modelBuilder.Entity<Trivsel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__trivsel__3213E83F1AC8CD03");

            entity.ToTable("trivsel");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.Institutionsnummer).HasColumnName("institutionsnummer");
            entity.Property(e => e.Koen).HasColumnName("koen");
            entity.Property(e => e.Sporgsmaalsnummer)
                .HasMaxLength(5)
                .HasColumnName("sporgsmaalsnummer");
            entity.Property(e => e.Svarnummer).HasColumnName("svarnummer");
            entity.Property(e => e.Vaerdi)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("vaerdi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
