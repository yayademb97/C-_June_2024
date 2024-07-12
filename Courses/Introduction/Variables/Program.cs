﻿
//? Variable:
//! Défintion d'une Variable : Une Variable est un conteneur qui permette de stocker des informations, 
//!                            de la conserver en mémoire tout au long de l'exécution du programme.


//* Comment se fasse la déclaration? : Elle se fasse de telle sorte que:
//*                                    On veut une information à stocker de "type", qui pourrait par la suite etre réservée en mémoire.


//* Exemple:
//          int        age;
//*          v          v
//*         type  nameOfVariable       
            int        age      =   27;   //* In C#, naming conventions typically use PascalCase.
//*          v          v            v
//*         type nameOfVariable = value  (Here we are talking about the declaration and assignment of the variable.)

Console.WriteLine(age);   //? Output : 27


//! Assigning a new value to the variable
//* Example: 
//* Declaration of my variable:
string FullName = "Yaya Dembele";

//* Displaying the current value of the variable:
Console.WriteLine(FullName);    //? Output : Yaya Dembele

//? Reassigning the variable: To do this, I don't need to indicate the variable type again that I want to reassign.
FullName = "Wael Hajji";

//* Displaying the newly reassigned value
// Console.WriteLine(FullName);     //? Output : Wael Hajji

//? Note: It's important to remember that you can reassign a new value to a variable of the same type. 
//? For example, in my previous example, 
//? I reassigned 'FullName' to a new value 'Wael Hajji' (which is of the same type, a 'string'

//? NB: À ne pas oublier, et qui est très important qu'on ne peut réaffecter une nouvelle valeur à une variable de même type
//?     c'est à dire d'après mon eexemple précédent , j'ai réaffecté à "FullName" une nouvelle valeur "Wael Hajji"
//?     (qui est de même type que l'ancien soit un "string")



string UserName = "Houssem";
string OtherName = "Narimene";


//! Affichage avec de l'interpolation :
Console.WriteLine($"Hello {UserName} and {OtherName}");  //? Output : Hello Houssem and Narimene

UserName = OtherName;

Console.WriteLine($"Hi {OtherName}");    //? Output : Hi Narimene
Console.WriteLine($"Hi {UserName}");     //? Output : Hi Narimene


//! Convert Type

//? a) Conversion d'un "int" to "string" :

//* Example
int number  = 10;

//? Let's convert "number " to string

//* 1ère méthode:

string StringNumber  = number.ToString();

Console.WriteLine($"This is my variable number converted to string: {StringNumber}");  //? Output : 10


//* 2ème méthode:
string stringNumber = Convert.ToString(number);
Console.WriteLine($"This is my variable number converted to string: {stringNumber}"); 


//? b) Conversion d'un "string" to "float" :

//* Example

string floatString = "3.14";


//? Let's convert "floatString" to float

//* 1ère méthode:

float FloatNumber  = float.Parse(floatString);


Console.WriteLine($"This is my variable floatNumber converted to float: {FloatNumber}");  //? Output : 3.14

//* 2ème méthode:

float floatNumber = Convert.ToSingle(floatString);

Console.WriteLine($"This is my variable floatNumber converted to float: {floatNumber}");


//! NB: Généralement, eviter de passer par des intermédiares pour la conversion , comme exemple, quand je veux une grande valeur , du coup si je choisis
//!     le type value "decimal" , après faire une conversion vers "int".
//!     Autant prendre directement une information (data) pour la mémoriser dans une variable de type vale "int"




//? Casting:
//? Définition: En C#, le "casting" (ou transtypage en français) est l'opération qui permet de convertir une variable 
//?             d'un type de données à un autre type. 
//?             Cette opération peut être explicite ou implicite, en fonction de la compatibilité des types de données, 
//?             et des risques potentiels de perte de données.


//* 1) Casting implicite : Le casting implicite se produit automatiquement lorsque la conversion est sûre et qu'il n'y a pas de perte de données.
//*    Exemple : conversion d'un type plus petit à un type plus grand (par exemple, de int à long).

int intNumber = 10;
long longNumber = intNumber; //* Casting implicite

Console.WriteLine(longNumber); //? Output: 10

//* 2) Casting explicite :  Le casting explicite est nécessaire lorsque la conversion peut entraîner une perte de données,
//*                         ou lorsqu'il y a un risque d'échec de la conversion.
//*                         Cela se fait en utilisant une syntaxe spéciale avec des parenthèses " () ".

double doubleNumber = 9.78;
int anotherIntNumber = (int)doubleNumber; // Casting explicite

Console.WriteLine(anotherIntNumber); // Output: 9

//* Autre exemple:
float numberFloat = 3.14f;
Console.WriteLine($"My Float variable with his value: {numberFloat}");

// * Je peux tout simplement changer de type:
//* Je vais déclarer une nouvelle variable et l'initialiser à "0"
int nb = 0;

// * Alors affectons-lui la valeur de numberFlaot :
// nb = numberFloat;
// Console.WriteLine(nb);   //? Output: error CS0266: Cannot implicitly convert type 'float' to 'int'. 
//?                                     An explicit conversion exists (are you missing a cast?)


// * Pour corriger, je peux utiliser un "casting explicite" :
nb = (int)numberFloat;
Console.WriteLine(nb);   //? Output: 3


//! Valabilité de Casting:
/*
*  Le casting en C# est principalement utilisé pour deux types de conversions :
   * 1) Conversion Numérique :

    *    a)Objectif : Convertir entre différents types numériques, tels que int, double, long, etc.
    *    b)Exemple : Convertir un int en double pour effectuer des calculs impliquant des nombres décimaux.

  *  2) Conversion de Types de Référence :
    *    a)Objectif : Convertir entre une classe de base et une classe dérivée, ou entre un type d'interface et son implémentation concrète.
    *    b)Exemple : Convertir une référence de type Animal vers Dog pour accéder aux méthodes spécifiques à Dog
    
 *   Résumé :
        *    Le casting est utilisé principalement pour ces deux types de conversion afin de manipuler efficacement les données numériques, 
        *    et d'accéder aux fonctionnalités spécifiques des classes dérivées ou des implémentations d'interface. 
        *    Cela permet de rendre le code plus flexible et de répondre aux besoins spécifiques des opérations, 
        *    et des fonctionnalités requises dans une application C#.
*/

/*
* (Anglais)

*Casting in C# is primarily used for two types of conversions:

* Numeric Conversion:
* a) Goal: Convert between different numeric types, such as int, double, long, etc.
* b) Example: Convert an int to double to perform calculations involving decimal numbers.
* Reference Type Conversion:
* a) Goal: Convert between a base class and a derived class, or between an interface type and its concrete implementation.
* b) Example: Convert a reference of type Animal to Dog to access Dog-specific methods.
* Summary:

* Casting is primarily used for these two types of conversions to effectively manipulate numeric data
* and access specific functionalities of derived classes or interface implementations.
* This makes the code more flexible and meets the specific needs of operations
* and functionalities required in a C# application.
*/