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
- [Operators](#operators)
  - [Math operators](#math-operators)
    - [Math operator examples](#math-operator-examples)
  - [Relational operators](#relational-operators)
    - [Relational operators examples](#relational-operators-examples)
  - [Unary and binary operators](#unary-and-binary-operators)
    - [Example unary and binary operators](#example-unary-and-binary-operators)

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
