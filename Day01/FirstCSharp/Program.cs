// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello from my first project");

// JavaScript
// var varName = "hello";

// Python
// name = "hello"

// These languages tend to look a lot more verbose but it's for a reason!
string name = "hello";
// I needed the word string
// We have to declare data types at the start of EVERY variable
// Languages like JS and Python do not care for data type at the moment of creation - this means the memory used to store that data is arbitrary 
// In C# since we declare the data type from the beginning we take EXACTLY how much space we need for the variable
// Less memory used means smaller file sizes which means things load and download quicker
name = "7";


// JS function
// function functionName() {}

// C# function
// You need to specify what will be returned by the function
static void functionName()
{
    // void is the term we use when there is NO return statement
}

static string Hello()
{
    return "Hello";
}