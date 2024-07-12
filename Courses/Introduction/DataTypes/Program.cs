// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// // ! Data Types


// // ? What is a statistically typed language ? 
// // ? You have to specify the type of variables or function you want to create

// // ! JavScript
// // ? var name = "Yaya"

// // ! C#
// string name = "Yaya";
// Console.WriteLine(name);  // Affiche: Yaya
// Console.WriteLine(name.GetType()); // Affiche: System.String


// int number = 7;
// Console.WriteLine(number); // Affiche: 7
// Console.WriteLine(number.GetType()); // Affiche: System.Int32


// double dec = 3.14;
// Console.WriteLine(dec);  // Affiche: 3.14
// Console.WriteLine(dec.GetType()); // Affiche: System.Double


// float FloatValue = 1.2f;
// Console.WriteLine(FloatValue); // Affiche: 1.2
// Console.WriteLine(FloatValue.GetType()); // Affiche: System.Single



// * Il y'en a beaucoup comme type de données avec C#, on va juste s'intéresser aux types qui nous interesse
//* Définition: Un tyoe de données est un type de données qui représente un obbjet de manière générale en C#.
//*             C'est à dire , tous ces types que nous allons utilisés en C# héritent de la classe "Object"

//! En C#, les types de données se divisent principalement en deux (02) catégories :
//! 1) Les Types Valeur (Value Type)
//! 2) Les Types Référence (Reference Type)


//* Voici un apperçu de chaque catégorie et les principaux types de données inclues :


//! A) Value Type: (Types Valeur) : Les types valeur contiennent directement leurs données. Lorsqu'une variable de type valeur est 
//!                                 affectée à une autre, une copie de la valeur est faite. Les types valeur incluent :


//*  Types numériques intégrés :
            //* byte : 8 bits, non signé, de 0 à 255.
            //* sbyte : 8 bits, signé, de -128 à 127.
            //* short : 16 bits, signé, de -32,768 à 32,767.
            //* ushort : 16 bits, non signé, de 0 à 65,535.
            //* int : 32 bits, non signé, de -2,147,483,648 à 2,147,483,647.
            //* uint : 32 bits, non signé, de 0 à 4,294,967,295.
            //* long : 64 bits, signé, de -9,223,372,036,854,775,808 à 9,223,372,036,854,775,807.
            //* ulong : 64 bits, non signé, de 0 à 18,446,744,073,709,551,615.



//* Types à virgule flottante :
            //* float : 32 bits, décimal, de 1.5 × 10^-45 à 3.4 × 10^38.
            //* double : 64 bits, décimal, de 5.0 × 10^-324 à 1.7 × 10^308.

//* Type décimal :
            //* decimal : 128 bits, utilisé pour les valeurs monétaires et financières.

//* Types Boolean : 
            //* bool : 1 bit, peut "True" ou "False".


//* Type caractère :
            //* char : 16 bits, représente un caractère Unicode.

//* Structures et énumérations : 
            //* struct : créé pour encapsuler des données et des méthodes dans une unité logique et définie par l'utilisateur, peut contenir des champs de différents types.
            //* enum : créé pour déclarer une série de constantes qui ont un sens commun (ensemble de constantes nommées).




//! B) Types Référence (Reference Types): Les types référence stockent une référence à leurs données. Lorsqu'une variable de type référence 
//!                                       est affectée à une autre, elles partagent la même référence. Les types référence incluent :



//* Type chaîne : 
            //* string : stocke une séquence de caractères Unicode.

//* Tableaux :
            //* Array : stocke une collection de valeurs de même type ou (collections de types de données du même type).

//* Classes :
            //* class : créé pour déclarer des objets qui ont des propriétés et des méthodes ou (définie par l'utilisateur, peut contenir des champs, des propriétés, des méthodes, etc).

//* Interface :
            //* interface : créé pour déclarer des méthodes et des propriétés qui doivent être implémentées par des classes ou des autres interfaces ou 
            //*             (définit un contrat que les classes ou les structures doivent suivre).

//* Délégués :
            //* delegate : créé pour encapsuler une fonction qui peut être appelée à l'aide d'un autre type ou (fait  référence à des méthodes).

//* Objects:
            //* object : est la base de toutes les classes et interfaces en C#. 
            //* C'est un type spécial qui ne peut pas être créé directement, mais peut être créé à l'aide de la méthode "new".


//! B) Types Nullables (Nullable Types): Les types valeur peuvent être rendus nullable, ce qui signifie qu'ils peuvent représenter toutes les 
//!                                      valeurs normales de leur type sous-jacent plus une valeur spéciale null.


//* Exemple : int? : peut contenir n'importe quelle valeur int ou null

//! Code Pratique:
using System;

class Program
{
    static void Main()
    {
        // Types valeur
        int integer = 42;
        float floatingPoint = 3.14f;
        bool boolean = true;
        char character = 'A';

        // Types référence
        string text = "Hello, World!";
        int[] numbers = { 1, 2, 3, 4, 5 };
        object obj = new object();

        // Type nullable
        int? nullableInteger = null;

        Console.WriteLine($"Integer: {integer}");
        Console.WriteLine($"Floating Point: {floatingPoint}");
        Console.WriteLine($"Boolean: {boolean}");
        Console.WriteLine($"Character: {character}");
        Console.WriteLine($"String: {text}");
        Console.WriteLine($"Array: {string.Join(", ", numbers)}");
        Console.WriteLine($"Object: {obj}");
        Console.WriteLine($"Nullable Integer: {nullableInteger}");
    }
}
