
// ! 1ère méthode:
// using System;


// class App

// {
//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Welcome Ninjas 🥷🥷🥷 in the C# Stack!!!");
//     }
// }


// ! 2ème méthode: mais elle est pas trop pratique
// using System;    // * par contre ici ça sous-entend qu'on inclut seulement que la classe "Console" de cet environnement "System".
//                          // * Alors si on veut utiliser d'autres classes dans l'environnement "System", il faudrait alors faire d'autres inclusions.

// using static System.Console; //* Cette ligne permet d'utiliser directement les méthodes statiques telles que "WriteLine" de la classe Console.

// class App

// {
//     static void Main(string[] args)
//     {
//         // WriteLine("Welcome Ninjas 🥷🥷🥷 in the C# Stack!!!");    //* "WriteLine" est une methode permettant d'afficher du texte avec une instruction "retour à la ligne."
//                                                                     //* Output : Welcome Ninjas 🥷🥷🥷 in the C# Stack!!!  
//     }

// }

// ! D'autres méthodes statiques de cette classe Console de cet environnement "System"

using System;

class App

{
    static void Main(string[] args)
    {
        Console.Write("Welcome Ninjas!!!");
        Console.Clear();
        Console.Beep();
        Console.Write("Welcome Ninjas!!!");   //* "Write" est une autre méthode statique de la classe "Console" permettant d'afficher du texte avec une instruction sur une ligne.
                                    //* Output : Welcome Ninjas!!!Welcome Ninjas!!!   
    }

}


// ! Commentaire: Il sert aux développeurs tout simplement, pour celui qui lit le code ou celui qui l'écrit pour avoir un tas d'indication
// Mono Line Comment: Il se fait par un double " // " (commentaire s'écrivant sur une seule ligne)
//  Multi Line Comment: Il se fait par :" /**/ "

/*
Voici mon commentaire multi line
Donc c'était juste un exemple pour vous montrer.
*/ 