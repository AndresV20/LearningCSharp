// 1 Teaches you about printing 
Console.WriteLine("Welcome to C#!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This is a print statement");
    }
}
using System;

{
    public static void multStatements(string[] args)
    {
        Console.WriteLine("Name:Andres");
        Console.WriteLine("Surname:Villalobos");
        Console.WriteLine("age:" 500)
    }
}
//2 One of the tasks is to fix code
using System;

public class Program
{
    public static void print(string[] args)
    {
        Console.WriteLine("My first C# Code Coach!");
    }
}
// the error here is that WriteLine was missing, therefore the code wasn't printing anything

//3 Namespaces lesson

// using can be the equivalent to import 
//teaches about comments 
/* and the two ways to add them 
to your code*/

//4 Variables lesson
string name;
int age;
boolean isMan = true;

char label = 'A';
double income = 100.75;
name = "Andres";
float height = 1.82f;
decimal weight = 92.8m;

//other way to declare variable
string lastName = "Villalobos";
Console.WriteLine(lastName);
//5 doing math
Console.WriteLine(5+4);
Console.WriteLine(6-3);
// When you run this it does the addition
int x = 5;
int y = 4;

Console.WriteLine(x+y);
// output = 9
int beatsPerMinute = 80*60; // multiplication
double divide = 20/50;
//combined operations
int a = 2;
int b = 3;
int c = 4;

Console.WriteLine(a+b-c);
// output = 1

int balls = 100;
int ballsInBox = 3;
balls++;
int result = balls%ballsInBox;

Console.WriteLine(result);

        int items = 200;
        int itemInBox = 9;

        //your code goes here
        int total = items %  itemInBox;
        Console.WriteLine(total);

// 6 Assignment operators
// basic one
int myAge = 19;
myAge += 20;
//mutliple assignments on one line
int id = 1122554, totalAge = 20, myIncome = 1000;
//Correction excercises.
        int balance = 416500;
        int withdraw = 160000;

        //your code goes here
        balance-=withdraw;
        Console.WriteLine(balance);

//7. user input 
string Nickname;
Nickname = Console.ReadLine();

string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

//converting to int
int number1 = Convert.ToInt32(input1);
int number2 = Convert.ToInt32(input2);

//calculating the sum
int Myresult = number1 + number2;
//8 More on strings.
//This line creates a tab space when the text is printed.
 Console.WriteLine("\t hey \t there");

/* 9. Concatenation and interpolation 
Concatenate*/
Console.WriteLine("Hel" + "lo");
// interpolation
string city = "Berlin";
Console.WriteLine($"{city} is the capital of Germany");

//10 the if statement 
if (true){
    console.WriteLine("It was true")
}else
{
    Console.WriteLine("It was false")
}

int purchase = 1700;
if (purchase>=1500)
{
    Console.WriteLine("Discount!");
}

string exampleName = Console.ReadLine();
int points = 144;
int minPoints = 100;

if (points>=minPoints){
    Console.WriteLine($"Well done,{name}!")
}
//code problem from the if lesson
int age = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        if (age<= 19){
         Console.WriteLine("Take your kindle");
        }else if

// 11 the switch statement
int choice = 2;

switch(choice)
{
    case 1:
        Console.WriteLine("Sports");
        break;
            
    case 2:
        //match!
        Console.WriteLine("Business");
        break;
            
    case 3:
        Console.WriteLine("Technology");
        break;
    default: 
        Console.WriteLine("Invalid input")
}
// 12 ternary operator
int age = 42;
string isAdult = age<18 ? "Too young": "Old enough";

Console.WriteLine(isAdult);
//code exercise 
        int hour = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        string result = (hour<13)? "AM": "PM";
        Console.WriteLine(result);

//13 Loops
//13.1 For loop
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Value of i: {i}");
}