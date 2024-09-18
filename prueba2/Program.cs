/* 1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
.
.
.
*/

for (int i = 1; i < 101; i++) 
{
    if ((i % 3 == 0) && (i % 5 == 0))
    Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
    Console.WriteLine($"{i} - Fizz");
    else if ((i % 5 == 0)) 
    Console.WriteLine($"{i} - Buzz");
    else
    Console.WriteLine($"{i}");
}