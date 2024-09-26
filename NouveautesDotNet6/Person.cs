namespace NouveautesDotNet6;

public class Person
{
    public int Id { get; init; } = 1;
    public string? Nom { get; set; } // On peut indique si une chaine (string) est nullable ou pas.
    public string Prenom { get; set; } = null!; // Assign la valeur null à une valeur non-nullable.
    public int? Age { get; set; }

    public Adresse? Adresse { get; set; }

    public Compagnie? Compagnie { get; set; }
}

public class Compagnie
{
    public string Nom { get; set; } = null!;

    public Adresse? Adresse { get; set; }
}

public class Adresse
{
    public string? Ville { get; set; }
}