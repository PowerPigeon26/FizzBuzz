void FizzBuzz(int input)
{
    string fizzBuzz = "";
    if (input % 3 == 0)
    {
        fizzBuzz = fizzBuzz + "fizz";
    }
    if (input % 5 == 0)
    {
        fizzBuzz = fizzBuzz + "buzz";
    }
    Console.WriteLine(fizzBuzz);
}

Console.WriteLine("Give a positive integer: (Ex. 1, 3, 65) ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || !(number > 0))
{
    Console.WriteLine("Not a valid positive integer, try again.");
}

FizzBuzz(number);