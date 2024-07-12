

//? Chaine de Caratères " string ": Une chaine de caractère de type value, a une certaine particularité particularité importante :


    //! I) Particularité Immuable: Célà signifie qe qu'une fois qu'une chaîne est créée, elle ne peut pas être modifiée. 
    //!                            Toute opération qui semble modifier une chaîne de caractères en réalité crée une nouvelle chaîne avec les modifications souhaitées, 
    //!                            tandis que l'ancienne chaîne reste inchangée.


    //* Exemple:
    string myWord = "Hello, World !!!";
    myWord = "Hi I am Yaya";

    Console.WriteLine(myWord);    //? Output : Hi I am Yaya


    /*
        Explication:
        j'ai créé une chaine de caractère en mettant mon texte dedans " Hello, World !!! "
        Par la suite , j'ai fait ne modification de cette chaine de caratère qui est myWord en affectant une nouvelle valeur qui est" Hi I am Yaya ".

        On constate qu'on a la meme variable, mais on a pas le meme objet.

        Notre premier objet de type string myWord a été instancié avec une valeur " hello, World!!! "

        Apès avoir fait une affectation à ce meme objet, il y aura un nouvel objet de la meme chaine de caractère qui va etre créer dont on va placer notre ensemble
        de caratère (char) qui est " Hi I am Yaya " qui sera retourné à ce niveau.

        On aura ensuite le meme identifiant qui est le nom de la variable " myWord " de type string , mais l'objet a changé.

    */ 


    //! I) Particularité Séquentielle: La particularité séquentielle des chaînes de caractères en C#, 
    //!                                fait référence au fait que les chaînes sont constituées d'une séquence ordonnée de caractères. 
    //!                                Chaque caractère dans une chaîne a une position spécifique (index), commençant à zéro et allant jusqu'à la longueur de la chaîne moins un.
    //!                                Cette particularité permet de parcourir, d'accéder et de manipuler les caractères individuellement au sein de la chaîne.


//* Exemple:
string exampleString = "Hello, C#";

// Accéder au premier caractère
char firstCharacter = exampleString[0]; // 'H'

// Accéder au cinquième caractère
char fifthCharacter = exampleString[4]; // 'o'

// Parcourir tous les caractères de la chaîne
foreach (char c in exampleString)
{
    Console.WriteLine(c);
}


/*
    Output:
    H
    e
    l
    l
    o
    ,
    
    C
    #
*/


    //! III) Common mistake: 
            //! a) Unassigned value:

//* Example:
// string myString;
// Console.WriteLine(myString);

/*
    Output:
    C:\Users\yayad\OneDrive\Bureau\C#\StringNotions\Program.cs(76,19): 
    error CS0165: Utilisation d'une variable locale non assignée 'myString' [C:\Users\yayad\OneDrive\Bureau\C#\StringNotions\String
    Notions.csproj]

    La build a échoué. Corrigez les erreurs de la build et réexécutez-la.   

*/ 


string myString1= null;

Console.WriteLine(myString1);

/*
    Output: On aura une chaine qui est nulle.


*/ 