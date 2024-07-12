
//? List : concise way to organize and manage collections of data.
//?        A list in C# is a data structure that allows storing 
//?        and manipulating a sequence of elements in a specific order.


//?        It provides methods for adding, removing, and accessing elements, 
//?        making it versatile for managing collections of data.


        // Create a list of strings
        List<string> fruits = new List<string>();

        // Add elements to the list
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Strawberry");

        // Display the number of elements in the list
        Console.WriteLine("Number of fruits in the list: " + fruits.Count);

        // Iterate through and display the elements of the list
        Console.WriteLine("Fruits in the list are:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Remove an element from the list
        fruits.Remove("Banana");

        // Display the list after removal
        Console.WriteLine("\nAfter removing 'Banana', the fruits are:");
        foreach (string remainingFruit in fruits) // Changed variable name to avoid conflict
        {
            Console.WriteLine(remainingFruit);
        }

        // Access an element by index if the list is not empty
        if (fruits.Count > 0)
        {
            string firstRemainingFruit = fruits[0]; // Changed variable name to avoid conflict
            Console.WriteLine("\nThe first remaining fruit in the list is: " + firstRemainingFruit);
        }
        else
        {
            Console.WriteLine("\nThe list is empty after removal.");
        }
    