using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //practice code by rahul
        Console.WriteLine("welcome C# practice page");
        //hello console
        string aFriend = "Rahul";
        Console.WriteLine(aFriend);
        Console.WriteLine("Hello " + aFriend);
        Console.WriteLine($"hello {aFriend}"); // best way 

        string firstFriend = "satyam";
        string secondFriend = "rushi";
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");//My friends are satyam and rushi
        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");//The name satyam has 6 letters.
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");//The name rushi has 5 letters.

        //do more woth string
        string greeting = "      Hello there!       ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart();//start trim()
        Console.WriteLine($"[{trimmedGreeting}]");
        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");// end trim()
        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");// trim()

        //replace
        string sayHello = "Hello aarjaycreation!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "changed");
        Console.WriteLine(sayHello);
        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello.ToLower());
        //search
        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.Contains("goodbye")); //True
        Console.WriteLine(songLyrics.Contains("greetings"));


        Console.WriteLine(songLyrics.StartsWith("You"));// True
        Console.WriteLine(songLyrics.StartsWith("goodbye")); //False

        Console.WriteLine(songLyrics.EndsWith("hello"));//True
        Console.WriteLine(songLyrics.EndsWith("goodbye")); //False









        Console.WriteLine("Welcome number practice ");
        //int a = 18;
        //int b = 6;
        //int c = a + b;
        //Console.WriteLine(c);
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine($"quotient: {d}");//3
        Console.WriteLine($"remainder: {e}");//2
        int max = int.MaxValue; // -2147483648
        int min = int.MinValue; // 2147483647
        Console.WriteLine($"The range of integers is {min} to {max}");








        Console.WriteLine("branch and loop statements");
        int a1 = 5;
        int b1 = 3;
        int c1 = a1 + b1;
        if (a1 + b1 > 10)
        {
            Console.WriteLine($"The answer is{c} greater than 10");
        }
        else
        {
            Console.WriteLine($"The answer is{c} not greater than 10");
        }
        //while
        int counter = 0;
        while (counter <= 10)
        {
            Console.WriteLine($"while! The counter is {counter}");
            //Hello World!The counter is 0
            //Hello World!The counter is 1
            //Hello World!The counter is 2
            //Hello World!The counter is 3
            //Hello World!The counter is 4
            //Hello World!The counter is 5
            //Hello World!The counter is 6
            //Hello World!The counter is 7
            //Hello World!The counter is 8
            //Hello World!The counter is 9
            //Hello World!The counter is 10
            counter++;
        }

        //do while

        do
                {
                    Console.WriteLine($"do while ! The counter is {counter}");
                    counter++;
                } while (counter <= 10);

         //for loop
        for (int counter1 = 0; counter1 < 10; counter1++)
            {
                Console.WriteLine($"Hello World! The counter is {counter1}");
            }










        //  Create lists

        var names = new List<string> { "<name>", "rahul", "jangir" };
        names.Add("satyam");
        names.Add("rushi");
        names.Remove("<name>");
        foreach (var obj in names)
        {
            Console.WriteLine($"Hello {obj.ToUpper()}!");
            //Hello RAHUL!
            //Hello JANGIR!
            //Hello SATYAM!
            //Hello RUSHI!
        }
        Console.WriteLine($"My name is {names[0]}.");//My name is rahul.
        Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");//I've added satyam and rushi to the list.
        Console.WriteLine($"The list has {names.Count} friends in it");

        //Search and sort lists
        var index = names.IndexOf("rahul");
        if (index != -1)
            Console.WriteLine($"The name {names[index]} is at index {index}");

        var notFound = names.IndexOf("Not Found");
        Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
    }
}
