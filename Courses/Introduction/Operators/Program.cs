// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//? Operators:
//? Définition: Operators are simply symbols used in our program that allow us to perform
//?             calculations of expressions, comparisons, value assignments, or logical operations.
//?             Operators are fundamental for manipulating data and controlling the flow of execution in a program.






/*
*    I) Types of Common Operators in Our Programs:
    *    1)Assignment Operators (=): These simply allow us to store or save information in a variable.
    *                                They are identified by the assignment sign "="


    *    2) Arithmetics Operators (+, -, *, /, %):  are special symbols used to perform mathematical calculations on numerical data.
    *                                               They are used to perform basic mathematical operations on numbers.
    *                                                 
    
    *    3) Comparison Operators (==,!=, <, >, <=, >=):  They are used to perform basic mathematical operations on numbers.
    *                                                    (true or false) according to the relationship between these values.
    


    *     4)Conditional Binary Operators or Ternary Operator: A conditional binary operator, also known as a ternary operator,
    *                                                         is an operator used in programming to evaluate a condition and return one of two values 
    *                                                         based on that condition.   
    *                                                         They are identified by the following symbols:
    *                                                         condition ? true_value : false_value;



    *    5) Conditional logical operators (&&, ||): They are used to evaluate logical expressions and return a boolean value (true or false).
    *                                                    " && " is the conditional AND logical operator. It returns true only if both operands are true.
    *                                                    " || " is the conditional OR logical operator. It returns true if at least one of the operands is true.

    *NB : Cet opérateur " ! " exprime la négation d'une variable de type value " boolean "

    
*/

int a = 3;
int b = 2;

int result = a + b;
int resultSum = a + b;
int resultSub = a - b;
int resultTimes = a * b;
int resultMod = a % b;


float resultFloatValue = (float)a / b;;
Console.WriteLine(resultFloatValue);   //? Output : 1.5
Console.WriteLine(resultMod);   //? Output : 1.5




bool resultBool = (5 == 6);

Console.WriteLine(resultBool);   //? Output : False


string resultString = "Yaya Dembele";
string otherString = "Coding Dojo";


// bool resultStringComparison = (resultString == otherString);

// bool resultStringComparison = (resultString != otherString);


int integerValue = 11;
int otherIntegerValue = -11;


bool isLaunched = true;


bool test = !isLaunched;



int age = 18;
string type = (age >= 18) ? "Adulte" : "Mineur";
Console.WriteLine(type); // //? Output :Adulte


bool c = true;
bool d = false;

// Utilisation de l'opérateur &&
bool resultAnd = c && d; // false, car d est faux
Console.WriteLine("Result of c && d: " + resultAnd);

// Utilisation de l'opérateur ||
bool resultOr = c || d; // true, car c est vrai
Console.WriteLine("Result of c || d: " + resultOr);

bool resultIntegerComparison = (integerValue > otherIntegerValue);
Console.WriteLine(resultIntegerComparison); //? Output :True