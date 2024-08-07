using System.ComponentModel;
using System.Data;
using System.Xml.Linq;

Console.WriteLine(Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }));


//                                      Problem one
// Complete the solution so that it reverses the string passed into it.

//                                      Solution
static string Solution(string str)
{
    char[] arr = str.ToCharArray();
    string reverse = "";
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        reverse += arr[i];
    }
    return reverse;
}


//                                  Problem two
/* Write a function that takes an array of words and smashes them together into
    a sentence and returns the sentence.
    You can ignore any need to sanitize words or add punctuation,
    but you should add spaces between each word */


//                              solution
static string Smash(string[] words)
{
    string statement = words[0];
    for (int i = 1; i < words.Length; i++)
    {
        statement += $" {words[i]}";
    }
    return statement;
}




//                              Problem three
/*
 The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.
 */

//                              Solution
static double basicOp(char op, double a, double b)
{
    return Convert.ToDouble(new DataTable().Compute($"{a}{op}{b}", ""));
}



//                                  Problem four
/*
 Create a method that takes as input a name, city, and state to welcome a person.
Note that name will be an array consisting of one or more values
that should be joined together with one space between each,
and the length of the name array in test cases will vary.
 */

//                                          Solution 
static string SayHello(string[] name, string city, string state)
{
    return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
}
