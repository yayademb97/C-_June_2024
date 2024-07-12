/*
    *   1Create variables of the following data types (it does not matter what the exact data is, 
    *   as long as it's the correct type): string, int, bool, double, char
*/
string myString = "Hello, World!";
int myInt = 42;
bool myBool = true;
double myDouble = 3.14;
char myChar = 'A';

/*
   * 2. What did you have to do to distinguish a string from a char?

   * To distinguish a string from a char, you use double quotes (") for strings and single quotes (') for characters. For example:

    *   string myString = "Hello";
    *   char myChar = 'H';
*/


/*
    * 3. Change the value of your boolean into a double.

    *    Attempting to change the value of a boolean into a double directly will result in a compilation error. Here is an example:
*/

bool myBool = true;
// double myDouble = myBool; // This line will cause a compilation error
/*
    *   The error occurs because C# is a strongly-typed language, and you cannot implicitly convert a boolean to a double. 
    *   This teaches us to be cautious about data types and conversions.   
*/


/*
    * 4.Use string interpolation to print all your values to the terminal
*/
Console.WriteLine($"This is my string: {myString}, this is my int: {myInt}, this is my boolean: {myBool}, this is my double: {myDouble}, and this is my char: {myChar}");