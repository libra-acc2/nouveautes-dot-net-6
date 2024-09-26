#region Top level statement

//namespace NouveatesDotNet6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}

// Top level statement
Console.WriteLine($"Hello, World!, {args}");
//NouveautesDotNet6.CSharp9.CSharp9.Test();

#endregion

#region Directives "using" globales

// Versions précédentes de C# :
// - Nécessité de déclarer les "using" dans chaque fichier.

// C# 10 (avec "usings" globales)
// Dans un fichier séparé comme GlobalUsings.cs:
// - Simplifie les "usings" dans C#​
// - Pas besoin de déclarer à plusieurs reprises les "usings" dans chaque fichier.
// - Définit les utilisations globales dans un seul fichier pour l’ensemble du projet.
// - Code plus propre et moins de répétitions.

var collections = new Collection<string>();

#endregion

#region File-scoped namespaces

// Versions précédentes de C# :
// - Requiert des accolades {} pour encapsuler les namespaces.

// C# 10 (avec le File-scoped namespace)
// - Syntax​e plus propre
// - Simplifie les déclarations des namespaces avec moins d'indentation.​
// - Élimine le besoin d’encapsuler le code à l’intérieur des accolades.

#endregion

#region Améliorations des expressions lambda

// Versions précédentes de C# :
// Types de délégués explicites requis pour les expressions lambda.
Func<int, int> square2 = x => x * x;

// C# 10 (Lambdas simplifiées):
// Pas besoin de types de délégués ou de paramètres explicites lorsqu’ils peuvent être déduits.
// - Syntaxe simplifié, code concis
var square1 = (int x) => x * x; // Désormais possible sans spécifier de type de délégué

#endregion

#region Chaînes interpolées constantes

// Versions précédentes de C# :
// Pas de support pour les chaînes interpolées dans les constantes.
const string name2 = "John";
const string greeting2 = "Hello, " + name2; // Concatenation
Console.WriteLine(greeting2);

// C# 10 (Chaînes interpolées constantes):
// - Permet des définitions de constantes plus lisibles, en utilisant l’interpolation de chaînes dans les "compile-time constants".
const string name1 = "John";
const string greeting1 = $"Hello, {name1}";
Console.WriteLine(greeting1);
Console.WriteLine();

#endregion

#region Modèles de propriété étendus

// Versions précédentes de C# :
// Pas de "pattern matching".
var person = new Person()
{
    Id = 1,
    Prenom = "Prénom",
    Nom = "Nom",
    Adresse = new Adresse() { Ville = "Paris" },
    Compagnie = new Compagnie() { Nom = "Infomil", Adresse = new Adresse() { Ville = "Paris" } },
    Age = 26
};

if (person.Prenom == "Prénom"
    && person.Adresse.Ville == "Paris"
    && person.Compagnie.Adresse.Ville == "Paris")
{
    Console.WriteLine("person.Prenom est \"Prénom\"");
}

// C# 9 (Modèles de propriété basiques):
if (person is { Prenom: "Prénom", Adresse: { Ville: "Paris" }, Compagnie: { Adresse: { Ville: "Paris" } } })
{
    Console.WriteLine("person.Prenom est \"Prénom\"");
}

// C# 10 (Modèles de propriété étendus):
// - Simplifie la syntaxe des propriétés imbriquées, améliorant ainsi la lisibilité et la facilité d’utilisation lors du "pattern matching".
if (person is { Prenom: "Prénom", Adresse.Ville: "Paris", Compagnie.Adresse.Ville: "Paris" })
{
    Console.WriteLine("person.Prenom est \"Prénom\"");
}
Console.WriteLine();

#endregion

#region Record (C# 9)

MyRecordExample myRecordExample = new(X: 1, Y: 2);
//myRecordExample.X = 10; => Syntaxe invalide car on peut uniquement initiliser la valeur mais pas la modifier.
Console.WriteLine($"myRecordExample: {myRecordExample}"); // => Affiche les valeurs de chaque propriété

MyRecordExample myRecordExample2 = new(X: 1, Y: 2);
Console.WriteLine($"myRecordExample == myRecordExample2 : {myRecordExample == myRecordExample2}"); // => Affiche vrai car on fait la comparaison avec les valeurs et pas avec la référence

MyRecordExample myRecordExample3 = myRecordExample with { X = 10 }; // => Créer un clone du "record" avec les mêmes valeurs mais différente référence
Console.WriteLine($"myRecordExample3: {myRecordExample3}");
Console.WriteLine();

#endregion

#region Expressions "with"

// Versions précédentes de C# :
// Pas d'expression "with".

// C# 9 (Expressions "with" pour les records uniquement):
var myRecord = new MyRecord(1, 2); // MyRecord => record
var myRecordCopy = myRecord with { X = 5 };
Console.WriteLine($"myRecord: {myRecord}");
Console.WriteLine($"myRecordCopy: {myRecordCopy}");

// C# 10 (Expressions "with" pour les structs):
// - Permet l’utilisation d’expressions "with" pour les enregistrements et les structures,
//   améliorant ainsi la réutilisation du code et l’immuabilité dans les structures de données.
var point = new Point(1, 2); // Point => struct
//var pointCopy = new Point(5, point.Y);
var pointCopy = point with { X = 5 };
Console.WriteLine($"point: {point}");
Console.WriteLine($"pointCopy: {pointCopy}");
Console.WriteLine();

#endregion

#region "record struct"

// Versions précédentes de C# :
// Pas de support pour les records.

// C# 9 (record sans struct):
public record MyRecord(int X, int Y); // Uniquement les types référence, pas les types valeur

// C# 10 (record struct):
// - Combine l’immuabilité avec les avantages (en terme de perf) des types valeur (structs).
public readonly record struct MyRecordStruct(int X, int Y);

#endregion

#region Record (C# 9)

// Déclaration simplifié
public record MyRecordExample(int X, int Y);

// Déclaration par défaut
//public record MyRecordExample
//{
//    public int X { get; init; }

//    public int Y { get; init; }
//}

#endregion
