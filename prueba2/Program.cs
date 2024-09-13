using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

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

//ejercicio grads
// initialize variables - graded assignments 

Console.Clear();

var currentAssignments = 5;

string nameSophia = "Sophia";
var sophia1 = 93;
var sophia2 = 87;
var sophia3 = 98;
var sophia4 = 95;
var sophia5 = 100;
var Sophia = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5);

var mediaSophia = (decimal) Sophia / currentAssignments;

Console.WriteLine($"{nameSophia} {mediaSophia}");

string nameNicolas = "Nicolas";

var nicolas1 = 80;
var nicolas2 = 83;
var nicolas3 = 82;
var nicolas4 = 88;
var nicolas5 = 85;

var Nicolas  = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5);




string nameZahira = "Zahira";

var zahirah1 = 84;
var zahirah2 = 96;
var zahirah3 = 73;
var zahirah4 = 85;
var zahirah5 = 79;

var Zahira  = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5);

var mediaZahira = (decimal) Zahira / currentAssignments;

string nameJeong = "Jeong";
var jeong1 = 90;
var jeong2 = 92;
var jeong3 = 98;
var jeong4 = 100;
var jeong5 = 97;

var Jeong  = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5);

var mediaJeong = (decimal) Jeong / currentAssignments;

Console.Clear();

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

Console.WriteLine($"{totalGradePoints} {totalCreditHours}");
Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

Console.Clear();