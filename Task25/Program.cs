
Console.Write("Insert number A: ");
int numA = int.Parse (Console.ReadLine());

Console.Write("Insert number B: ");
int numB = int.Parse (Console.ReadLine());

void degree (int firstNumber, int secondNumber)
{
    if (secondNumber <= 0){ // Честно не знал, является ли 0 натуральным числом. Полез в гугл и прочитал, что в РФ принято считать 0 ненатуральным числом.
        Console.WriteLine ("Please, insert natural number!");
        return;
        
}
    else{
    int acc = 1;
    for (int i = 0; i < secondNumber; i++)
    {
        acc *= firstNumber;
    }
    Console.WriteLine ($"The number {firstNumber} to the {secondNumber} power is {acc}");
}
}
degree (numA, numB);