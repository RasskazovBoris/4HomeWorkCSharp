System.Console.Write("Insert the number: ");
int input = int.Parse (Console.ReadLine());

int Sum (int num)
{
    if (num < 0) num *= -1; // если я правильно понял задание, то нужно посчитать сумму цифр и неважно, отрицательное число или положительное.
    int acc = 0;
    for ( ; num > 0; num /= 10)
    {
        acc += num % 10;
    }
    return acc;
}
System.Console.WriteLine ($"The sum of the digits in a number {input} is a {Sum(input)}");
