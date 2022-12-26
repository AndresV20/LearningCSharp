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