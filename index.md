## About

This document serves as a quick reference for beginning C# programmers.

## Contents

- [About](#about)
- [Contents](#contents)
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
