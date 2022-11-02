//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//// Console.WriteLine("Hello World!");

//Console.Write("Congratulations!");
//Console.Write(" ");
//Console.Write("You wrote your first lines of code!");

//Console.Write("This is the first line.");
//Console.WriteLine("");
//Console.Write("This is the second line.");

//-------------------------------------------------------------------//
//  Store and retrieve data using literal and variable values in C#  //
//-------------------------------------------------------------------//

//Console.WriteLine(123.30);
//Console.WriteLine(123.30m);
//Console.WriteLine(true);
//Console.WriteLine(false);
//Console.WriteLine("123");
//Console.WriteLine(123);
//Console.WriteLine("true");
//Console.WriteLine(true);

//----------------------//
//  What is a variable  //
//----------------------//

//string firstName;
//firstName = "Tim";
//Console.WriteLine(firstName);

//var secondName = "Tim";
//Console.WriteLine(secondName);

//string firstNameA;
//int someNumber = 1;
//firstNameA = someNumber.ToString();
//Console.WriteLine(firstNameA);
//Console.WriteLine(firstNameA + "1");
//Console.WriteLine(someNumber.ToString());

//var someValue1 = "Tim";
//var someValue2 = "Bob";
//var someValue3 = 123;
//Console.WriteLine(secondName);

//var name = "Bob";
//var messages = 3;
//var temp = 34.4;

//Console.WriteLine("Hello, " + name + " Bob! You have " + messages + " messages in your inbox. The temperature is " + temp + " celsius.");
//Console.WriteLine($"Hello, {name}! You have {messages} messages in your inbox. The temperature is {temp} celsius.");
//Console.WriteLine("Hello, {0}! You have {1} messages in your inbox. The temperature is {2} celsius.", name, messages, temp);


//-------------------------------------------------------------------//
//  Formatting Literal Strings in C#								//
//-------------------------------------------------------------------//

//Console.WriteLine("Hello\nWorld!");
//Console.WriteLine("Hello\tWorld!");

//Console.WriteLine("Hello \"World\"!");

//Console.WriteLine("c:\\source\\repos");

//Console.WriteLine(@"   c:\source\repos   
//      (""this is where your code goes"")");


//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data");

// Exercise:
string projectName = "ACME";
string russianMessage = "041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output: \n\t c:\\Exercise\\{projectName}\\data.txt \n");
Console.WriteLine($"{russianMessage}: \n\t c:\\Exercise\\{projectName}\\ru-RU\\data.txt ");

