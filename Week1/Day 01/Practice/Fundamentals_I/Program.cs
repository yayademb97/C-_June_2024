


// //? Practice Assignment: Fundamentals I
// /*

// *   Learning Objectives:
// *   Implement programming logic such as loops and conditionals to solve problems using C# syntax in a console application.


// *   Directions
// *   Create a new .NET console project and complete the exercises outlined below. For the entirety of this course, 
// *   you will be expected to submit GitHub links or zip files of your entire project folder!

// */ 


// //!  1.Create a loop that prints all values from 1-255.

// Console.WriteLine("With Foor Loop:");
// for (int i=0; i <=255;  i++)
// {
//     Console.WriteLine($"{i}");
// }

// Console.WriteLine("****************************************************************");

// Console.WriteLine("With While Loop:");

// int j = 0;
// while (j<256)
// {
//     Console.WriteLine($"{j}");
//     j++;
// }


// Console.WriteLine("****************************************************************");


// //!  2.Create a new loop that generates 5 random numbers between 10 and 20.

// Random random = new Random();    //! Here we create a new instance of the Random class, which is used to generate random numbers.
//                                 //! Random: This is the type of the variable 'random'. 
//                                 //! The Random class is part of the System namespace and is used to generate pseudo-random numbers.

// Console.WriteLine("With For Loop:");

// for (int z=0; z < 5; z++)
// {
//     int randomNumber = random.Next(10, 21);
//     Console.WriteLine("This is 5 random numbers generate between 10 and 20 by for loop: " +randomNumber);

// }


// Console.WriteLine("**********************************************************");

// Random random = new Random();   //! Here we create a new instance of the Random class, which is used to generate random numbers.

// //                                 //! Random: This is the type of the variable 'random'. 
// //                                 //! The Random class is part of the System namespace and is used to generate pseudo-random numbers.

// Console.WriteLine("With While Loop:");

// int count = 0;
// while (count < 5)
// {
//     int randomNumber = random.Next(10, 21);
//     Console.WriteLine(randomNumber);
//     count++;
// }


// Console.WriteLine("**********************************************************");

// Random random = new Random();   //! Here we create a new instance of the Random class, which is used to generate random numbers.

//                                 //! Random: This is the type of the variable 'random'. 
//                                 //! The Random class is part of the System namespace and is used to generate pseudo-random numbers.

// Console.WriteLine("With Foreach Loop:");

// int[] randomNumbers = new int[5];   //! We are creating an array of type 'int' to store our random values in this array.

// for (int p = 0; p < 5; p++)
// {
//     randomNumbers[p] = random.Next(10, 21);   //! Next is a method of the Random class in C#, used to generate a random integer.
// }

// foreach (int number in randomNumbers)
// {
//     Console.WriteLine(number);
// }


// Console.WriteLine("**********************************************************");

// // //!  3. Modify the previous loop to add the random values together and print the sum after the loop finishes

// Random random = new Random();
// int sum = 0;  //* We will create sum and  is a variable used to accumulate the random values.

// Console.WriteLine("Generating random numbers and calculating sum:");

// for (int k = 0; k < 5; k++)
// {
//     int randomNumber = random.Next(10, 21);
//     Console.WriteLine(randomNumber);
//     sum += randomNumber; //* Add the random number to the current sum
// }

// Console.WriteLine($"Sum of random numbers: {sum}");   //* After the loop, the accumulated sum (sum) is printed to display the final result.



//!     5.Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.

Console.WriteLine("*************************************************************************");
Console.WriteLine("Printing numbers divisible by 3 or 5 but not both:");


for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 || i % 5 == 0) 
    {
        Console.WriteLine($"{i}"); 
    }
}


Console.WriteLine("*************************************************************************");


Console.WriteLine("With While loop:");
int y = 1;
while (y < 101)
{
    if (y % 3 == 0 || y % 5 == 0)
    {
        Console.WriteLine($"{y}");
    }
    y++;
}

Console.WriteLine("*************************************************************************");

Console.WriteLine("With foreach loop:");

List<int> numbers = new List<int>();
for (int n = 1; n <= 100; n++)
{
    numbers.Add(n);
}

Console.WriteLine("Numbers divisible by 3 or 5 using foreach:");

foreach (int number in numbers)
{
    if (number % 3 == 0 || number % 5 == 0)
    {
        Console.WriteLine(number);
    }
}


//!     5. Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.

Console.WriteLine("************************************************************");

Console.WriteLine("Printing numbers divisible by 3 or 5 using FizzBuzz:");


for (int b = 1; b < 101; b++)
{
    if (b % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (b % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(b);
    }
}


Console.WriteLine("************************************************************");


//!    6. Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.


for (int num = 1; num <= 100; num++)
{
    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(num);
    }
}



Console.WriteLine("****************************************************");

//!    7. (Optional) If you used for loops for your solutions, try doing the same with while loops. Vice versa if you used while loops!

int counter = 1;
while (counter <= 100)
{
    if (counter % 3 == 0 && counter % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (counter % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (counter % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(counter);
    }
    
    counter++;
}
