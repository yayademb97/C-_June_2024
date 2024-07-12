//? Loops: En C#, une boucle est une structure de contrôle qui permet d'exécuter un bloc de code plusieurs fois de manière répétée, 
//?        jusqu'à ce qu'une condition spécifiée soit remplie.

// * ********* Anglais ******************

//? Loops: In C#, a loop is a control structure that allows executing 
//?         a block of code repeatedly until a specified condition is met


//* Exemple pratique: Essayons d'afficher un texte plusieurs fois, comme exemple, affichons "Hello Ninjas, Welcome to C# Stack!!!" 5fois.
//* La manière simple est de le faire de cette façon :


// * ********* Anglais ******************
//* Practical Example: Let's try to display a text multiple times. For instance, 
//* let's display 'Hello Ninjas, Welcome to C# Stack!!!' 5 times. The straightforward way to do this is:

//* 1 st méthod: Utilize the Console method to display our text multiple times.

Console.WriteLine("Hello Ninjas, Welcome to C# Stack!!!");
Console.WriteLine("Hello Ninjas, Welcome to C# Stack!!!");
Console.WriteLine("Hello Ninjas, Welcome to C# Stack!!!");
Console.WriteLine("Hello Ninjas, Welcome to C# Stack!!!");
Console.WriteLine("Hello Ninjas, Welcome to C# Stack!!!");
Console.WriteLine("Hello Ninjas, Welcome to C# Stack!!!");



Console.WriteLine(new string('-', 40));

//* 2nd method: I will store the string 'Hello Ninjas, Welcome to C# Stack!!!' in a variable and display the text 5 times.

string textToDisplay = "Hello Ninjas, Welcome to C# Stack!!!";

Console.WriteLine(textToDisplay);
Console.WriteLine(textToDisplay);
Console.WriteLine(textToDisplay);
Console.WriteLine(textToDisplay);
Console.WriteLine(textToDisplay);
Console.WriteLine(textToDisplay);

//! NB: Un bon dévéloppeur et un bon programmer doit toujours eviter d'écrire trop de code et éviter la répétition, puisqu'il peut rendre le programme rédondant.
//* DRY (Don't repeat Yourself) : est une des plus grands principes ou qualités (ou règle d'or) qui définisse un bon dévéloppeur.


Console.WriteLine(new string('-', 50));

//?  
To do this, we will introduce the concept of loops.


//? I) ` For Loop `: is used when the number of iterations is known in advance.
string textToDisplay1 = "Hello Ninjas, Welcome to C# Stack!!!";

Console.WriteLine("With For Loop:");
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}: Coding Dojo");
    }
    else
    {
        Console.WriteLine($"{i}: Ninjas");
    }
}

//* Exemple 2 : Write a C# program that uses a for loop to iterate through the numbers from 1 to 20.
//*             And for each number, the program should check whether it is even or odd. 
//*             If the number is even, display 'Coding Dojo'. If the number is odd, display 'Ninjas'.




Console.WriteLine(new string('-', 80));


//? II) ` While Loop `: Execute the block of code as long as a condition is true.



string textToDisplay2 = "Hello Ninjas, Welcome to C# Stack!!!";

int p = 0; 

// while (p < 6) //? or
while(p <= 5)
{
    Console.WriteLine(textToDisplay2);
    p++; 
}



Console.WriteLine(new string('-', 70));

Console.WriteLine("With While Loop:");
int j = 1;


while (j <= 20)
{
    if (j % 2 == 0)
    {
        Console.WriteLine($"{j}: Coding Dojo");
    }
    else
    {
        Console.WriteLine($"{j}: Ninjas");
    }
    j++;
}


//? III) ` Do ... While Loop `: Similar to while, but ensures that the block of code is executed at least once.
//?                             It means that we want the code to execute at least once (the absolute minimum).

Console.WriteLine(new string('-',70));

Console.WriteLine("With Do While Loop:");

string textToDisplay3 = "Hello Ninjas, Welcome to C# Stack!!!";

int k = 0;
//? If we want to ensure that the execution happens at least once, we simply need to:
// int k = 6; 

do
{
    Console.WriteLine(textToDisplay3);
    k++; 
} while (k < 6);






//? Loops: 


//? ` Foreach Loop `:  allows you to iterate over the elements of a collection such as an array or a list.
//?                    It means that for each part we want to temporarily extract from this data, 
//?                    which is a collection (like an array or a list),
//?                    we could subsequently perform a number of instructions.



//* Exemple:
string myName = "Youssef";  //* Since we haven't covered collections like arrays or lists yet, 
                            //* let's take a simple example by declaring a variable of type value (string).
                            //* Later on, we can iterate over this string using our foreach loop.

                            //* So we can conclude that a string is like a structure that can be iterated over, 
                            //* which we will explore further when we start.
                            //* Object-Oriented Programming (OOP), including classes, interfaces, etc.,
foreach (char letter in myName)  //* We use our foreach loop, which allows us to iterate through each character of the string structure.
                                  //* which are "Y", "o", "u", "s", "s", "o", "u", "f" (which are of type "char").
                                  //* We take a variable of the same type as our characters, called "letter", which allows us to iterate through our string of characters.
                                  //* " char letter ": est aussi une variable temporaire qui n'existera que dans notre boucle, et elle est en lecture seule.
                                  //* We can read the information stored in char letter, but we cannot modify it unless we use the readonly keyword in C#, which we'll cover in OOP.
                                  //* So the loop will stop when we reach the last character of our structure myName (which is our stopping point).
{
    Console.WriteLine($"My differents letter in the string is: {letter}");
}

/*
Output: 
My differents letter in the string is: Y
My differents letter in the string is: o
My differents letter in the string is: u
My differents letter in the string is: s
My differents letter in the string is: s
My differents letter in the string is: e
My differents letter in the string is: f
*/ 


//! NB: Elle est une boucle qui nous permettra pratiquement de parcourir des structures

