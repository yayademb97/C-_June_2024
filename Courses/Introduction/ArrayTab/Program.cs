

//? Array "Tableau": Un tableau en C# est une structure de données qui permet de stocker une collection d'éléments de meme type.
//?                  Les tableaux ont une taille fixe qui est déterminée lors de sa création
//? Syntaxe: Type [] nameOfArray;
//?                  Les données ou informations peuvent etre de plusieurs types natifs.


//! Types de Tableau "Array":

    //! I)Tableau Unidimensionnel:

int [] numbers = new int [2];
//* ou cette écriture aussi:
int [] numbers = new int [] {0, 1};
//$ ou une dernière écriture
int [] numbers = {0,1};

//! NB: Après avoir initialiser notre tableau, on peut noter qu'en C# , chaque valeur de l'élément par défut du tableau vaut zéro "0".
//!     On peut aussi initialiser dès le départ notre tableau par les valeurs qui doivent etre mises dans le tableau
//!     ça correspond à notre 3ème écriture: int [] numbers = {0,1};


//!Résumé: Une fois que notre tableau créé, on va pouvoir afficher différents éléments du tableau, en utilisant un système d'indices ,
//!        c'est à dire un " accès dirrect ".


//* Exemple:
int [] myArr = {0,-1,2,4};
Console.WriteLine(myArr[1]);    //? Output: -1


//! NB: Comme on peut accéder à un élément spécifique du tableau , alors on peut donc le modifier (le changer) , mais en s'assurant qu'il soit de meme type 
//!     que le type d'élément que nous avons déclaré en créant notre tableau

//* Exemple: 
int [] myNewArr = {0,1,2,3};
myNewArr[3] = 11;
Console.WriteLine(myNewArr[3]);    //? Output: 11

//! Itérabilité d'un tableau: Parcourir un tableau et accéder aux éléments du tableau.
        //! Parcours et Lecture: Pour ce fait , on peut utiliser la boucle ` foreach `

//* Exemple:

int [] myItterableArr = new int [] {13,0,4,8};
foreach (var item in myItterableArr)
{
    Consol.WriteLine(item);
}


//? Output: 13 0 4 8

//! NB: On ne peut modifier par la boucle ` foreach ` dans cet exemple, un élément du tableau e faisant le parcours ou l'itération.

//!     Alors on parle de notion de " lecture seule ".

//! Modification en faisant le parcours et l'itération: Pour ce fait, on va dévoir utiliser la boucle ` for `, en déclarant un compteur et en l'initialisant à zéro "0",
//!                                                     ensuite on conditionne le parcours jusqu'à la taille du tableau, qui correspond au dernier élément en utilisant 
//!                                                     la propriété " length " et incrémentant enfin.

//* Exemple:
int [] arr = {0,1,2};
for (int i = 0; i < arr.length; i++)
{
    Console.WriteLine(arr[i]);
}

//? Output: 0 1 2


//! NB: L'affichage sera de meme , mais là on est pas en lecture seule, donc on peut faire une modification.

//* Exemple:
int [] newArr = {0,1,5};

for (int i = 0; i < newArr.length; i++)
{
    if (newArr[i] == 5)
    {
        newArr[i] = 12;
    }

    foreach (var item in newArr)
    {
        Console.WriteLine(item)
    }
}

//? Output: 0 1 12


//! II)Tableau Multidimensionnel: est une structure de données qui permet de stocker des éléments dans un format à plusierus dimensions, 
//!                               comme un tableau à deux dimensions (matrice) ou plus
//! Syntaxe: type [,] nameOfArray = new type[size1, size2];   //* Déclaration et initialisation d'un tableau à deux "2" dimensions.


//* Exemple:
int [,] matrice = new int [3,4]   //* matrice de 3 lignes et 4 colonnes
//! Initialisation avec des valeurs:
/*
    type [,] nameOfArray = {
                                {value1, value2, value3, ...},
                                {value1, value2, value3, ...},
                                ...
                            };
*/  
//* Exemple:
int [,] newMatrice = {
                        {1,2,3,4},
                        {5,6,7,8},
                        {9,10,11,12}
                    };

    //! a)Accéder à un élément:  type element = nameOfArray[indice1, indice2];
//* Exemple:
int myValue = newMatrice[1,2]; //* accéder à l'élément de la deuxième ligne, troisième colonne
//? Ouput:

    //! b)Modifier un élément à un index spécique: nameOfArray[indece1, indice2] = newValue:

//* Exemple:
newMatrice[1,2] = 42;   //* Modifie l'élément de la deuxièm ligne , troisième colonne en 42


    //! c) Itérer sur les éléments: On utlisera dans ce cas des boucles imbriquées ` for `

//* Exemple:

for (int i = 0; i < newMatrice.GetLength(0); i++)
{
    for (int j = 0; j < newMatrice.GetLength(1); j++)
    {
        Console.WriteLine(newMatrice[i,j]);
    }
}

//* Exemple Complet de tableau à deux dimensions:

//* Initialisation d'une matrice avec des valeurs
int [,] myFirstMatrice = {
                        {1,2,3,4},
                        {5,6,7,8},
                        {9,10,11,12}
                    };
//* Accéder et efficher un élément
int value = myFirstMatrice[1,2];
Console.WriteLine("L'élément à la deuxième ligne, troisième coloenn est:" +value);

//* Modifier un élément
myFirstMatrice[1,2] = 42;

//* Itérer sur les éléments avec une boucle impbriquée
for (int i = 0; i < myFirstMatrice.GetLength(0); i++)
{
    for (int j = 0; j < myFirstMatrice.GetLength(1); j++)
    {
        Console.WriteLine(myFirstMatrice[i, j] + " ");
    }

    Console.WriteLine();
}

//! III)Tableau dans un Tableau: est juste un tableau qui va contenir un ou plusieurs tableaux.
//!     Syntaxe : int [][] nameOfArray = new int [][]


//* Exemple:
int [][] mySecondArr = new int [][];

//* Initialisation
mySecondArr[0] = new int [] {0,1,2,3};
mySecondArr[1] = new int [] {4,5,6,7};

//* Affichage des éléments des tableaux 1 et 2
foreach (var subItem in mySecondArr)
{
    foreach (var item in subItem)
    {
        Console.WriteLine(item);
    }
}