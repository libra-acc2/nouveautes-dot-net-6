namespace NouveautesDotNet6;

public class Person
{
    public int Id { get; init; } = 1;
    public string? Lastname { get; set; } // On peut indique si une chaine (string) est nullable ou pas.
    public string Firstname { get; set; } = null!; // Assign la valeur null à une valeur non-nullable.
    public int? Age { get; set; }

    public Adresse? Adresse { get; set; }

    public Person()
    {
        Id = 1;
        Firstname = "";
    }
}

public class Adresse
{
    public string? Ville { get; set; }
}
