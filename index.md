## About

This document serves as a quick reference for beginning C# programmers.

## Contents

- [About](#about)
- [Contents](#contents)
- [Conventions](#conventions)
- [Variables and basic data types](#variables-and-basic-data-types)
  - [Basic data types:](#basic-data-types)
  - [Declaring and defining variables](#declaring-and-defining-variables)
    - [Example, declaring and defining variables using basic data types](#example-declaring-and-defining-variables-using-basic-data-types)
- [Comments](#comments)
- [String interpolation](#string-interpolation)
  - [String concatenation with addition operator](#string-concatenation-with-addition-operator)
  - [String interpolation with brackets](#string-interpolation-with-brackets)
- [Operators](#operators)
  - [Math operators](#math-operators)
    - [Math operator examples](#math-operator-examples)
  - [Relational operators](#relational-operators)
    - [Relational operators examples](#relational-operators-examples)
  - [Unary and binary operators](#unary-and-binary-operators)
    - [Example unary and binary operators](#example-unary-and-binary-operators)
- [Console input and output](#console-input-and-output)
  - [Output](#output)
    - [Output example](#output-example)
  - [Input](#input)
    - [Parsing numeric values from console input](#parsing-numeric-values-from-console-input)
- [Conditional statements](#conditional-statements)
  - [If statements](#if-statements)
  - [If/else statements](#ifelse-statements)
  - [If/else-if statements](#ifelse-if-statements)
  - [Switch statements](#switch-statements)
    - [Switch statement example](#switch-statement-example)
- [Iteration](#iteration)
  - [While loop](#while-loop)
  - [Do-while loops](#do-while-loops)
  - [For loops](#for-loops)
- [Arrays](#arrays)
  - [Array indexing](#array-indexing)
  - [Multidimensional arrays](#multidimensional-arrays)
  - [Array lengths](#array-lengths)
  - [Array iteration](#array-iteration)
    - [Array iteration - for loop](#array-iteration---for-loop)
    - [Array iteration - foreach loop](#array-iteration---foreach-loop)
  - [Copying arrays](#copying-arrays)
- [Methods](#methods)
  - [Method signatures](#method-signatures)
  - [Method overloading](#method-overloading)
  - [Method scope and passing data](#method-scope-and-passing-data)
  - [Pass by value](#pass-by-value)
  - [Pass by ref](#pass-by-ref)
  - [Pass by ref out](#pass-by-ref-out)

## Conventions

In the code examples, `// ~>` is used to illustrate what would be output by the console:

```csharp
Console.WriteLine("hello!"); // ~> hello
```

## Variables and basic data types

Variables hold data in C#. Variables must have a type. The variable's type is the type of data the variable can hold.

### Basic data types:

- `int` - an integer. An integer is a positive or negative whole number. An int in C# can hold values between -2,147,483,648 and 2,147,483,647.
- `long` - a long integer. A long integer is the same as an integer but can hold a larger range of numbers. A long can contain integers between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807.
- `double` - a double precision floating point number. Doubles hold decimal numbers up to 15 decimal digits.
- `float` - a floating point number. Floats hold decimal numbers up to 6 decimal digits.
- `char`- a char. A char holds a single character.
- `string` - a string. A string holds a series of characters (like a word or a sentence).
- `bool` - a boolean. A boolean holds a true or false value.

### Declaring and defining variables

When a variable is declared in C#, it is given a name. When a variable is defined it is given a value.

#### Example, declaring and defining variables using basic data types

```csharp
int myInt;
long myLong;
double myDouble;
float myFloat;
char myChar;
string myString;
bool myBool;

myInt = 1;
myLong = 9223372036854775807;
myDouble = 1.333333333337;
myFloat = 1.34f;
myChar = 'a';
myString = "hello";
myBool = true;
```

Variables can also be declared and defined on the same line. For example:

```csharp
int myInt = 1;
```

## Comments

Comments are text in the program that is ignored by the compiler. Comments are typically used for documenting your code. There are two main ways to write comments:

```csharp
// This is a single line comment
/*
  This is a multiline comment.
  Multiline comments can take up multiple lines.
*/
```

## String interpolation

Interpolation means adding data to a string. C# has a few methods for interpolating strings.

### String concatenation with addition operator

```csharp
int i = 3;
Console.Writeline("The value of i is: " + i); // ~> The value of i is 3
```

### String interpolation with brackets

Data can be added to strings using brackets in two main ways:

Using a `$` character with brackets:

```csharp
int i = 3;
Console.WriteLine($"The value of i is {i}"); // ~> The value of i is 3
```

Using numbered arguments and brackets:

```csharp
int i = 3;
int j = 4;
Console.WriteLine("The values of i and j are {0} and {1}", i, j); // ~> The values of i and j are 3 and 4
```

## Operators

Operators perform actions on variables and return a value.

### Math operators

- `+` - addition
- `-` - subtraction
- `*` - multiplication
- `/` - division. When integer values divided, the remainder is omitted from the result.
- `%` - modulo. The modulo operator gives you the remainder value.

#### Math operator examples

```csharp
int myIntA = 5;
int myIntB = 2;

double myDoubleA = 5.0;
double myDoubleB = 2.0;

Console.WriteLine(myIntA + myIntB); // ~> 7
Console.WriteLine(myIntA - myIntB); // ~> 3
Console.WriteLine(myIntA / myIntB); // ~> 4 (NOTE, no remainder!)
Console.WriteLine(myIntA % myIntB); // ~> 1

Console.WriteLine();

Console.WriteLine(myDoubleA + myDoubleB); // ~> 7
Console.WriteLine(myDoubleA - myDoubleB); // ~> 3
Console.WriteLine(myDoubleA / myDoubleB); // ~> 2.5
Console.WriteLine(myDoubleA % myDoubleB); // ~> 1
```

### Relational operators

Relational operators compare two values and return a bool (true/false) value.

- `>` greater than
- `<` less than
- `>=` greater than or equal to
- `<=` less than or equal to
- `==` equal to
- `!=` not equal to

#### Relational operators examples

```csharp
int myIntA = 5;
int myIntB = 2;
int myIntC = 2;

Console.WriteLine(myIntA > myIntB); // ~> true
Console.WriteLine(myIntA < myIntB); // ~> false
Console.WriteLine(myIntB >= myIntC); // ~> true
Console.WriteLine(myIntB <= myIntC); // ~> true
Console.WriteLine(myIntB == myIntC); // ~> true
Console.WriteLine(myIntB != myIntC); // ~> false
```

### Unary and binary operators

Unary and binary are shorthand operators that perform an operation and assign a value in a single statement.

Unary and binary operators:

- `++` increments (increases) value by one
- `--` decrements (decreases) value by one
- `+=` adds a value and assigns it
- `-=` subtracts a value and assigns it
- `*=` multiples a value and assigns it
- `/=` divides a value and assigns it
- `%=` performs module operation and assigns it

#### Example unary and binary operators

```csharp
int x = 10;
x++; // x is 11
x--; // x is 10
x += 10; // x is 20
x -= 5; // x is 15
x *= 2; // x is 30
x /= 5; // x is 6
x %= 2; // x is 0
```

## Console input and output

For console applications, you can output text that the user can read and receive input text that the user writes.

### Output

The main methods to write output to the console are `Console.Write` and `Console.WriteLine`. The difference between the methods is that `Console.WriteLine` method will add a new line in the console.

#### Output example

```csharp
Console.Write("hello!"); // this will not create a new line
Console.WriteLine("hell again"); // this will add a new line of text to the console
```

### Input

To read text that the user enters use `Console.ReadLine`. Input is always returned as a `string`.

```csharp
string input = Console.ReadLine();
```

#### Parsing numeric values from console input

To change the type of the input string to a double, use `int.Parse()`:

```csharp
int number = int.Parse(Console.ReadLine());
```

To change the type of the input string to a double, use `double.Parse()`:

```csharp
double number = double.Parse(Console.ReadLine());
```

## Conditional statements

Conditional statements allow you to execute code only if certain conditions are true.

### If statements

An if statement gets executed only if a condition is true.

```csharp
int x = 3;
int y = 4;
if(x < 4){
    Console.WriteLine("x is less than y");
}
```

### If/else statements

If/else statements include a block of code that gets executed if they if condition is false.

```csharp
int x = 3;
int y = 4;
if(x < 4){
    Console.WriteLine("x is less than y");
} else {
    Console.WriteLine("y is less than x");
}
```

### If/else-if statements

If/else-if statements have an unlimited number of conditions that can be checked.

```csharp
int x = 3;
if(x == 1){
    Console.WriteLine("x is 1");
} else if (x == 2){
    Console.WriteLine("x is 2");
} else if (x == 3){
    Console.WriteLine("x is 3");
} else {
    // final else statement is optional
    Console.WriteLine("x is neither 1, 2, or 3");
}
```

### Switch statements

Switch statements check that a variable matches a condition. `break` should always be used inside a matching statement inside a switch condition. An optional `default` case can be used in case none of the conditions match.

#### Switch statement example

```csharp
int place = 2;
switch(place){
    case 1:
        Console.WriteLine("you receive a gold");
        break;
    case 2:
        Console.WriteLine("you receive a silver");
        break;
    case 3:
        Console.WriteLine("you receive a bronze");
        break;
    default:
        Console.WriteLine("you do not receive a meal");
}
```

## Iteration

Iteration involves looping over a block of code, typically multiple times.

### While loop

While loops get repeated _while_ a condition it true.

Example:

```csharp
int i = 0;
while(i < 3){
    Console.WriteLine($"The value of i is: {i}");
    i++;
}
```

### Do-while loops

Do-while loops work the same as while loops except, the condition gets checked after the loop runs once. Do-while loops are useful when you want your code to run at least once.

```csharp
string input;
do
{
    input = Console.ReadLine();
    Console.WriteLine($"You entered: input");
} while (input != "stop");
```

### For loops

For loops are typically used when you need a block of code to run a certain number of times. This loop will print the numbers from 1 to 10:

```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```

The for loop consists of three parts:

1. An initializing statement (`int i = 1;`). This initializes a variable used by the other parts of the for loop.
2. A condition (`i <= 10`). The loop will run while this condition is `true`.
3. An update (`i++`). This will run each loop and update the value of the main loop variable (`i` in this case).

## Arrays

An array is a collection of data. Unlike a variable that can hold only one item, an array can contain multiple items.

All items in an array must contain the same type of data.

A basic int array declaration example:

```csharp
int[] myNumbers;
```

To use an array, a size must be specified. This can either be done when the array is first declared:

```csharp
int[] myNumbers = new int[10];
```

or after:

```csharp
int[] myNumbers;
myNumbers = new int[10];
```

You usually must use the `new` keyword when setting the size of an array. The above array can hold 10 integers.

You do not need to use the `new` keyword if you immediately set the values of the array. You set the values using curly braces and commas between the values:

```csharp
int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
```

### Array indexing

You read and write values in an array based on the item's index. The item index goes inside the square brackets. Array indexes start at 0 instead of 1.

```csharp
int[] myNumbers;
myNumbers = new int[10];
myNumbers[0] = 111; // set the first item in the array
myNumbers[1] = 222; // set the second item in the array
// ...

// read the first number in the array
int firstNumber = myNumbers[0];
Console.WriteLine($"The first item in the array is {firstNumber}"); // ~> The first item in the array is 111
```

### Multidimensional arrays

So far, we have looked at single dimensional arrays. These are like a single row in spreadsheet. Arrays can have more dimensions. For instance, a two-dimensional instead of a single row of values, can be thought of as a spreadsheet with multiple rows and columns.

To declare a multidimensional array add a comma for each additional dimension the array has:

```csharp
int[,] myNumbers = new int[2,3]; // create a new two-dimensional array with 2 x 3 dimensions
```

When getting and settings values in a two-dimensional array, values for both dimensions need to be specified:

```csharp
int[,] myNumbers = new int[2,3]; // create a new 2 x 3 array
myNumbers[0,0] = 1;
myNumbers[0,1] = 2;
myNumbers[0,2] = 3;
myNumbers[1,0] = 4;
myNumbers[1,1] = 5;
// ...
```

The number of dimensions an array has can be accessed using the `.Rank` property:

```csharp
int[,] myNumbers = new int[2,3];
Console.WriteLinke(myNumbers.Rank); // ~> 2
```

### Array lengths

The `Array.Length` property will return the total number of elements in the array.

The `Array.GetLength()` method will return the total number of elements along the dimension of the array. You use `Array.GetLength(0)` to get the first dimension of the array, `Array.GetLength(1)` to get the second dimension, etc.

```csharp
int[] myNumbers = new int[10];
int[,] myOtherNumbers = new int[2, 3];

// .Length property
Console.WriteLine(myNumbers.Length); // ~> 10
Console.WriteLine(myOtherNumbers.Length); // ~> 6

// .GetLength() method
Console.WriteLine(myNumbers.GetLength(0)); // ~> 10
Console.WriteLine(myOtherNumbers.GetLength(0)); // ~> 2
Console.WriteLine(myOtherNumbers.GetLength(1)); // ~> 3
```

### Array iteration

Array iteration means looping through each element in an array. Typically a `for` or a `foreach` loop is used for this task.

#### Array iteration - for loop

A for loop starts at 0 and uses the array `.Length` property to loop through each element of the array:

```csharp
int[] myNumbers = new int[10];
for (int i = 0; i < myNumbers.Length; i++) {
    myNumbers[i] = i;
}
for (int i = 0; i < myNumbers.Length; i++)
{
    Console.WriteLine(myNumbers[i]); // ~> 0, 1, 2, 3...
}
```

#### Array iteration - foreach loop

A foreach loop automatically assigns the element of the array to a variable as you loop through the array:

```csharp
int[] myNumbers = { 2, 4, 6, 8, 10 };
foreach(int number in myNumbers)
{
    Console.WriteLine(number); // ~> 2, 4, 6...
}
```

### Copying arrays

Arrays are copied by reference. That means, when you assign one array to another array, they are both referencing the same data. If you change data in the first array, it will also change data in the copied array:

```csharp
int[] myNumbers = { 11, 22, 33, 44 };
int[] myOtherNumbers = myNumbers;

myNumbers[0] = 777;
Console.WriteLine(myOtherNumbers[0]); // ~> 777
```

## Methods

Methods contain code that can perform logic, actions and procedure in code. Methods can be called multiple times, can take data in and return data.

```csharp
namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = AddOne(1);
            Console.WriteLine(myNumber); // ~> 1
        }
        static int AddOne(int number) {
            return number + 1;
        }
    }
}
```

### Method signatures

```csharp
static int AddOne(int number) {
    return number + 1;
}
```

A method signature defines the method and its input and output data. In the above, example `static int AddOne(int number)` is the method signature. This is the meaning of each part of the signature:

- `static` - this means the method belongs to the class itself, instead of an instance of the class (more on that later).
- `int` is the return type. Methods can return data but they don't have to. For this method, an integer is returned. If nothing is returned from the method, `void` should be used.
- `AddOne` is the name of the method. You will use this when you are calling (using) the method.
- `int number` is a parameter. Parameters describe the data that gets passed into the method. The code in the method can access this data.

### Method overloading

Two methods can have the same name but accept a different number of arguments, this is referred to method overloading. The compiler automatically determines the correct method to call when the program is getting built.

In this example, the `SaySomething()` method is overloaded:

```csharp
namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaySomething("hip", "hip"); // ~> hip hip
            SaySomething("hooray!"); // ~> hooray!
        }
        static void SaySomething(string word, string secondWord)
        {
            Console.WriteLine($"{word} {secondWord}");
        }
        static void SaySomething(string word) {
            Console.WriteLine(word);
        }
    }
}
```

### Method scope and passing data

Data can get passed to methods in three main ways: pass by value, pass by ref, pass by ref out. Depending on how the data is passed, it will affect where and how variables are updated.

### Pass by value

By default, for simple data types (`int`, `double`, `string`, etc.) a copy of the data gets passed to the method. The changes that the method makes to the data only affect the copied variable. This is called passing data by value.

```csharp
namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            SquareNumber(5);
            Console.WriteLine(number); // ~> 5
        }
        static void SquareNumber(int number)
        {
            number = number * number;
        }
    }
}
```

In this example, the value of `number` inside the `Main()` method does not change since `SquareNumber()` only receives a copy of the `number` variable.

### Pass by ref

Unlike pass by value, when data is passed to a method using pass by ref, the actual variable gets passed to the method _not_ a copy of the data. When data is passed by ref, changes made inside the method will affect the original data. When a method uses pass by ref, the `ref` keyword must be used in the method signature _and_ on the argument that gets passed into the method.

```csharp
namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            SquareNumber(ref number); // `ref` is added here
            Console.WriteLine(number); // ~> 25
        }
        static void SquareNumber(ref int number) // `ref` is also added here
        {
            number = number * number;
        }
    }
}
```

### Pass by ref out

Pass by ref out works similar to pass by ref except, the variable does not need to have a value set _and_ the method _must_ set a value for the pass by ref out parameter inside the method.

```csharp
namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; // number has no initial value. This is allowed for `out` but not for `ref`.
            SetToThree(out number); // `out` must be used here
            Console.WriteLine(number); // ~> 3
        }
        static void SetToThree(out int number) // `out` must also be used here
        {
            number = 3; // out parameters _must_ be set inside the method
        }
    }
}
```
