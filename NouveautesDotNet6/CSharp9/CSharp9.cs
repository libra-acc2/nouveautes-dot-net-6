namespace NouveautesDotNet6.CSharp9;

public class CSharp9
{
    enum Touche
    {
        Numerique = 0, Lettre = 1, Speciale = 2, Fonction = 3, action = 4
    }

    enum Feu
    {
        Vert, Orange, Rouge, Clignotant, Eteint
    }

    public static void Test()
    {
        #region Création d'une instance

        Person p1 = new Person();
        var p2 = new Person();
        Person p3 = new();
        Person p4 = new() { Id = 4 };

        #endregion

        #region Pattern matching

        int random = Random.Shared.Next(1, 1000);

        if (random % 2 == 0 && random < 500)
        {
            Console.WriteLine($"Pair et inférieur à 500 => {random}");
        }
        if (random % 2 is 0 && random < 500)
        {
            Console.WriteLine($"Pair et inférieur à 500 => {random}");
        }

        if (random >= 333 && random <= 666)
        {
            Console.WriteLine($"Entre 333 et 666 => {random}");
        }
        if (random is >= 333 and <= 666)
        {
            Console.WriteLine($"Entre 333 et 666 => {random}");
        }

        if (random < 100 || random > 900)
        {
            Console.WriteLine($"Inférieur à 100 ou superieur à 900 => {random}");
        }
        if (random is < 100 or > 900)
        {
            Console.WriteLine($"Inférieur à 100 ou superieur à 900 => {random}");
        }
        Console.WriteLine();

        // Fonctionne uniquement si la valeur est constante, le code suivant ne fonctionne pas.
        // const int min = 100;
        // int max = 100; // Pas constante => Erreur de compilation
        // if (random is < min or > max)
        // {
        //     Console.WriteLine($"Inférieur à 100 ou superieur à 900 => {random}");
        // }

        #endregion

        #region Pattern matching avec le "switch"

        var t1 = Touche.Fonction;
        if (t1 is Touche.Numerique or Touche.Lettre)
        {
            Console.WriteLine("Ecriture");
        }

        Feu f1 = Feu.Vert;
        string queFaire = f1 switch
        {
            Feu.Vert => "On passe",
            Feu.Rouge or Feu.Orange => "On s'arrete",
            Feu.Clignotant or Feu.Eteint => "On fait attention",
            _ => throw new Exception("Pas une valeur cohérence") // Default case
        };
        Console.WriteLine($"Feu : {queFaire}");
        Console.WriteLine();

        #endregion

        #region Record

        VoitureClass vc1 = new VoitureClass(1, "Peugeot", "208", 10000);
        VoitureClass vc2 = new VoitureClass(1, "Peugeot", "208", 10000);
        Console.WriteLine($"vc1 => {vc1}"); // Le ToString affiche le nom de la classe
        Console.WriteLine($"vc2 => {vc2}");
        Console.WriteLine($"vc1 == vc2 ? {vc1 == vc2}"); // Va retourner faux
        Console.WriteLine($"vc1 != vc2 ? {vc1 != vc2}"); // Va retourner vrai
        Console.WriteLine($"vc1 Equals vc2 ? {vc1.Equals(vc2)}"); // Va retourner faux
        Console.WriteLine($"vc1 HashCode ? {vc1.GetHashCode()}");
        Console.WriteLine($"vc2 HashCode ? {vc2.GetHashCode()}");
        Console.WriteLine($"vc1 ReferenceEquals vc2 ? {ReferenceEquals(vc1, vc2)}"); // Va retourner faux
        Console.WriteLine();

        VoitureRecord vr1 = new VoitureRecord(1, "Peugeot", "208", 10000);
        VoitureRecord vr2 = new VoitureRecord(1, "Peugeot", "208", 10000);
        Console.WriteLine($"vr1 => {vr1}"); // Le ToString affiche les valeurs des propriétés
        Console.WriteLine($"vr2 => {vr2}");
        Console.WriteLine($"vr1 == vr2 ? {vr1 == vr2}"); // Va retourner vrai, il compare les valeurs de chaque propriété
        Console.WriteLine($"vr1 != vr2 ? {vr1 != vr2}"); // Va retourner faux
        Console.WriteLine($"vr1 Equals vr2 ? {vr1.Equals(vr2)}"); // Va retourner vrai
        Console.WriteLine($"vr1 HasCode ? {vr1.GetHashCode()}");
        Console.WriteLine($"vr2 HasCode ? {vr2.GetHashCode()}");
        Console.WriteLine($"vr1 ReferenceEquals vr2 ? {ReferenceEquals(vr1, vr2)}"); // Va retourner faux, différente référence

        VoitureRecord vr3 = vr1 with { Id = 2, Prix = 12000 };
        Console.WriteLine($"vr3 => {vr3}");
        VoitureRecord vr4 = vr3 with { }; // Avec le "with" cela crée un clone, logiquement c'est similaire mais avec une référence différente,
                                          // sans le "with" cela aura aussi la même référence

        Console.WriteLine($"vr3 HasCode ? {vr3.GetHashCode()}");
        Console.WriteLine($"vr4 HasCode ? {vr4.GetHashCode()}");
        Console.WriteLine($"vr3 ReferenceEquals vr4 ? {ReferenceEquals(vr3, vr4)}"); // Va retourner faux

        #endregion
    }
}
