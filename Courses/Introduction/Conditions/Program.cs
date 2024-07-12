// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//? Condiions: Une condition est une instruction qui évalue une expression booléenne (vraie ou fausse),
//?            pour déterminer quel bloc de code doit être exécuté.
//?            Elle est souvent utilisée avec des structures de contrôle comme if, else if, et else.


//*  Exemple 1:

int age = 15;

if (age >= 18)
{
    Console.WriteLine("You are of legal age.");
}

else if (age >= 21)

{
    Console.WriteLine("You are an adult.");
}

else 
{
    Console.WriteLine("You are a child.");
}


//* Exemple 2:
 int number = 10;

// Condition to check if the number is positive
if (number > 0)
 {
     Console.WriteLine("The number is positive.");
}
else
{
    Console.WriteLine("The number is zero or negative.");
}


//* Exemple 3:

int numberTest = 14;

if(numberTest > 0)
{
    if(numberTest > 10)
    {
        if(numberTest == 14)
        {
            Console.WriteLine("BINGOOO !!!!");
        }
        else
        {
            Console.WriteLine("LOST !!!");
        }
    }

}


//* Exemple 4:
// Coefficients of the quadratic function ax^2 + bx + c = 0
        double a = 1;
        double b = -2;
        double c = 1;

        // Calculate the discriminant
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            // Two distinct real roots
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The roots are real and distinct:");
            Console.WriteLine("Δ 1 = " + root1);
            Console.WriteLine("Δ 2 = " + root2);
        }
        else if (discriminant == 0)
        {
            // One double real root
            double root = -b / (2 * a);
            Console.WriteLine("The roots are real and equal:");
            Console.WriteLine("Double root Δ0 = Δ1 = Δ2 = " + root);
        }
        else
        {
            // Imaginary roots (non-real)
            Console.WriteLine($"The quadratic function has no real solutions because its value is negative, which is:  Δ={discriminant}");
        }


//* Exemple 5:

int number1 = -1;
int number2 = -13;


if(number1 > 0 && number1 < number2)
{
    Console.WriteLine("number1 is greater than 0 and less than number2.");
}

else if(number1 > number2)
{
    Console.WriteLine("number1 is greater than number2.");
}

else if(number1 < 0)
{
    Console.WriteLine("number1 is less than 0.");
}

//? ` Switch ` Conditional: En C#, l'instruction switch est utilisée lorsque vous avez une valeur à comparer avec plusieurs cas différents.
//? C'est une alternative plus claire et souvent plus efficace que l'utilisation de multiples instructions ` if-else ` 



//! Conditions d'utilisation courantes pour switch en C#:

//* 1. Comparaison de valeurs discrètes : Utilisez switch lorsque vous avez une variable dont la valeur doit être comparée avec plusieurs valeurs distinctes.
//* 2. Simplicité de lecture et de maintenance : Lorsque vous avez plusieurs cas à traiter et que chaque cas est basé sur une valeur unique, 
//*    ` switch ` peut rendre le code plus lisible et plus facile à maintenir par rapport à une série d'instructions if-else.


//* Exemple:
 int dayOfWeek = 2; // Suppose we want to find out which day corresponds to this number

switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        if (dayOfWeek == 1)
        {
            Console.WriteLine("Today is day-off");
        }
        break;
    case 2:
        Console.WriteLine("Monday");
        if (dayOfWeek == 2)
        {
            Console.WriteLine("Today is Q&A Session Day with me , @TA_Yaya!!!");
        }
        break;
    case 3:
        Console.WriteLine("Tuesday");
        if (dayOfWeek == 3)
        {
            Console.WriteLine("Today is Lecture Day With Instructor Wael!!!");
        }
        break;
    case 4:
        Console.WriteLine("Wednesday");
        if (dayOfWeek == 4)
        {
            Console.WriteLine("You should take advantage of today to work on your assignments, as there are no lectures or code reviews scheduled.");
            Console.WriteLine("Feel free to reach out if you need any assistance.");
        }
        break;
    case 5:
        Console.WriteLine("Thursday");
        if (dayOfWeek == 5)
        {
            Console.WriteLine("Today is Lecture Day With Instructor Wael!!!");
        }
        break;
    case 6:
        Console.WriteLine("Friday");
        if (dayOfWeek == 6)
        {
            Console.WriteLine("Today is Code Review Day With me, @TA_Yaya!!!");
        }
        break;
    case 7:
        Console.WriteLine("Saturday");
        if (dayOfWeek == 7)
        {
            Console.WriteLine("Today is a day-off!!!");
        }
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}