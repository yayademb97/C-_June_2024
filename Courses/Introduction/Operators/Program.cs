// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//? Operators:
//? Définition: Les opératuers sont tous simplement des symboles qu'on utilisera dans notre programme , qui nous permettront de faire 
//?             (du calcul des expréssions , de faire des comparaisons, es affectations de valeurs, ou des opérations logiques).
//?             Les opérateurs sont fondamentaux pour manipuler les données et contrôler le flux d'exécution dans un programme.






/*
    I) Types d'Opérateurs Usuels dans nos programmes:
    *    1)Opérateurs d'affectation (=): Il permette tout simplement de mémoriser ou stocker une information dans une variable.
    *                                    Il est identifié par le signe d'affectation " = "
    *    2) Opérateurs arithmétiques (+, -, *, /, %): sont des symboles spéciaux utilisés pour effectuer des calculs mathématiques sur les données numériques. 
    *                                                 Ils sont utilisés pour effectuer des opérations mathématiques de base sur les nombres.
    *                                                 Ils permettent d'additionner, soustraire, multiplier, diviser, 
    *                                                 et obtenir le reste d'une division entière entre deux valeurs numériques.
    *                                                 Ils sont identifiés par les symboles suivants:
    *                                                 " + ", " - ", " * ", " / ", " % "
    *    3) Opérateurs de comparaison (==,!=, <, >, <=, >=):  sont des symboles qui permettent de comparer deux valeurs et de produire un résultat booléen
    *                                                         (true ou false) selon la relation entre ces valeurs.
    *                                                        " == ": Vérifie si deux valeurs sont égales. 
    *                                                        " != ": Vérifie si deux valeurs sont différentes.
    *                                                        " < ": Vérifie si la première valeur est inférieure à la seconde.
    *                                                        " > ": Vérifie si la première valeur est supérieure à la seconde.
    *                                                        " <= ": Vérifie si la première valeur est inférieure ou égale à la seconde.
    *                                                        " >= ": Vérifie si la première valeur est supérieure ou égale à la seconde.


    
*/

int a = 3;
int b = 2;

int result = a / b;
int resultSum = a + b;
int resultSub = a - b;
int resultTimes = a * b;
int resultMod = a % b;


float resultFloatValue = (float)a / b;;
Console.WriteLine(resultFloatValue);   //? Output : 1.5
Console.WriteLine(resultMod);   //? Output : 1.5
