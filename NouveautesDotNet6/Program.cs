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
NouveautesDotNet6.CSharp9.CSharp9.Test();

#endregion

#region Directives "using" globales

// C# 10 (avec "usings" globales)
// Dans un fichier séparé comme GlobalUsings.cs:
// global using System;
// global using System.Linq;

var collections = new Collection<string>();

// - Simplifie les "usings" dans C#​
// - Pas besoin de déclarer à plusieurs reprises les "usings" dans chaque fichier.
// - Définit les utilisations globales dans un seul fichier pour l’ensemble du projet.
// - Code plus propre et moins de répétitions.

// Versions précédentes de C# :
// - Nécessité de déclarer les "using" dans chaque fichier.

#endregion

#region File-scoped namespaces

// C# 10 (avec le File-scoped namespace)
// - Syntax​e plus propre
// - Simplifie les déclarations des namespaces avec moins d'indentation.​
// - Élimine le besoin d’encapsuler le code à l’intérieur des accolades.

// Versions précédentes de C# :
// - Requiert des accolades {} pour encapsuler les namespaces.

#endregion

#region Améliorations des expressions lambda

// C# 10 (Lambdas simplifiées):
// Pas besoin de types de délégués ou de paramètres explicites lorsqu’ils peuvent être déduits.
// - Syntaxe simplifié, code concis
var square1 = (int x) => x * x; // Désormais possible sans spécifier de type de délégué

// Versions précédentes de C# :
// Types de délégués explicites requis pour les expressions lambda.
Func<int, int> square2 = x => x * x;

#endregion

#region Chaînes interpolées constantes

// C# 10 (Chaînes interpolées constantes):
// - Permet des définitions de constantes plus lisibles, en utilisant l’interpolation de chaînes dans les "compile-time constants".
const string name1 = "John";
const string greeting1 = $"Hello, {name1}";
Console.WriteLine(greeting1);

// Versions précédentes de C# :
// Pas de support pour les chaînes interpolées dans les constantes.
const string name2 = "John";
const string greeting2 = "Hello, " + name2; // Concatenation
Console.WriteLine(greeting2);
Console.WriteLine();

#endregion

#region Modèles de propriété étendus

// C# 10 (Modèles de propriété étendus):
// - Simplifie la syntaxe des propriétés imbriquées, améliorant ainsi la lisibilité et la facilité d’utilisation lors du "pattern matching".
var person = new Person() { Adresse = new Adresse() { Ville = "Paris" } };
if (person is { Adresse.Ville: "Paris" })
{
    Console.WriteLine("Adresse.Ville est Paris");
}

// C# 9 (Modèles de propriété basiques):
if (person is { Adresse: { Ville: "Paris" } })
{
    Console.WriteLine("Adresse.Ville est Paris");
}

// Versions précédentes de C# :
// Pas de "pattern matching".

#endregion

#region Expressions "with"

// C# 10 (Expressions "with" pour les structs):
// - Permet l’utilisation d’expressions "with" pour les enregistrements et les structures, améliorant ainsi la réutilisation du code et l’immuabilité dans les structures de données.
var point1 = new Point(1, 2); // Point => struct
var point2 = point1 with { X = 5 };

// C# 9 (Expressions "with" pour les records uniquement):
var point3 = new Point2(1, 2); // Point => record
var point4 = point1 with { X = 5 };

// Versions précédentes de C# :
// Pas d'expression "with".

#endregion

#region "record struct"

// C# 10 (record struct):
// - Combine l’immuabilité avec les avantages (en terme de perf) des types valeur (structs).
public readonly record struct Point1(int X, int Y);

// C# 9 (record sans struct):
public record Point2(int X, int Y); // Uniquement les types référence, pas les types valeur

// Versions précédentes de C# :
// Pas de support pour les records.

#endregion
