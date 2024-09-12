Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Bob";
Console.WriteLine(firstName);

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write( messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.WriteLine(" celsius. ");

//Operaciones matematicas
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// en vez de como esta escrito se podria poner asi: int FirstNumber = 12, secondNumber = 7;

int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

Console.WriteLine();
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

//int first = 7; int second = 5; decimal quotient = (decimal)first / (decimal)second; Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

var fahrenheit = 94;
var celsius = ((94-32)*(5.0/9.0));
celsius = Math.Round(celsius, 2);

Console.Clear();
Console.WriteLine(fahrenheit);
Console.WriteLine(celsius);

Console.WriteLine($"The temperature is {celsius} celsius");