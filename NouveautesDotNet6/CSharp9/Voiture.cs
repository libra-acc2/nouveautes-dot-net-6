namespace NouveautesDotNet6.CSharp9;

public class VoitureClass
{
    public int Id { get; init; }
    public string Marque { get; init; }
    public string Modele { get; init; }
    public double Prix { get; set; }

    public VoitureClass(int id, string marque, string modele, int prix)
    {
        Id = id;
        Marque = marque;
        Modele = modele;
        Prix = prix;
    }
}

// Par référence    => class, interface, delegate, record
// Par valeur       => struct, enum, record struct (C# 10)

public record VoitureRecord(int Id, string Marque, string Modele, double Prix)
{
    // public int Id { get; init; }
    // public string Marque { get; init; }
    // public string Modele { get; init; }
    public double Prix { get; set; } = Prix;

    // public VoitureRecord(int id, string marque, string modele, int prix)
    // {
    //     Id = id;
    //     Marque = marque;
    //     Modele = modele;
    //     Prix = prix;
    // }

    // ToString autogénéré
    // => entre chaque propriétés
}
