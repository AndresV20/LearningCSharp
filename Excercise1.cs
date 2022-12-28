/*This code does not execute properly. Try to figure out why. */ 
//Code that was not working
public class CustomMath {
    public static int multiply(int a, int b) {
        return a b;
    }
}

//My solution (Correct according to codewars)
public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}

// It was missing the * in the return statement, this caused c# to think there was a missing ; in the code.


//Exercise 2
//This function should return an object, but it's not doing what's intended. What's wrong?

using System.Collections.Generic;
public class Kata
{
    public static Dictionary<string,string> Mystery()
    {
        Dictionary<string,
      string> results = new 
        Dictionary<string,
      string>();
        results.  Add("sanity","hello");
        return;
        results;
    }
}

//my solution
using System.Collections.Generic;
public class Kata
{
    public static Dictionary<string,string> Mystery()
    {
        Dictionary<string,
      string> results = new 
        Dictionary<string,
      string>();
        results.  Add("sanity","hello");
        return results;
    }
}

//Exercise 3
/* Inspired by the development team at Vooza, write the function that

accepts the name of a programmer, and
returns the number of lightsabers owned by that person.
The only person who owns lightsabers is Zach, by the way. He owns 18, which is an awesome number of lightsabers. Anyone else owns 0.

Note: your function should have a default parameter.

For example(Input --> Output):*/
// My solution:
using System;

public class Kata
{
  public static int HowManyLightsabersDoYouOwn(string result)
  {
    //Code goes here
      return result == "Zach" ? 18 : 0;
  }
}
//if the name is zach then it will output 18 as the number of lightsabers but ant other string will out put 0 lightsabers

//Exercise 4
/* You were camping with your friends far away from home, but when it's time to go back, you realize that your fuel is running out and the nearest pump is 50 miles away! You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left.

Considering these factors, write a function that tells you if it is possible to get to the pump or not.

Function should return true if it is possible and false if not. */ 
public static class fuel
{
  public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
  {
    uint enFuel= mpg * fuelLeft;
    bool result = distanceToPump <= enFuel? true: false;
    return result;
  }
}
// 27-12-22
//This code should store "codewa.rs" as a variable called name but it's not working. Can you figure out why?
public class Kata
{
  private int valor;
    static string a = "code";
    static string b = "wa.rs";
    public static string Name = a + b;
}

/* There were serveral issues to solve, one of them was that the variables were not declared properly,
and the Name needs to be public because one of the tests was calling Kata.Name directly*/


//Oh no! Timmy's evalObject function doesn't work. He uses Switch/Cases to evaluate the given properties of an object, can you fix timmy's function?
public class Kata
{
  public static double EvalObject(double value1, double value2, char operation)
  {
    double result = 0;
    switch(operation)
    {
      case '+': 
        result = value1 + value2; 
        break;
      case '-': 
        result = value1 - value2;
        break;
      case '/': 
        result = value1 / value2;
        break;
      case '*': 
        result = value1 * value2;
        break;
      case '%': 
        result = value1 % value2;
        break;
      case '^': 
        result = Math.Pow(value1, value2);
        break;
    }
    return result;
  }
}

/*This one was simpler to solve, the issue here was that the switch was missing the break statements,
this causes the result to be overwritten every time it reaches a new case, this would result in it having
the result of the final case every time.

