// Возможно, неправильно понял задание, если это так - прошу Вас, верните на доработку с комментариями.
// Не совсем понятно, каким образом числа в массиве должны появляться, поэтому сделал 2 варианта на выбор.
// 1 вариант - рандом, 2 вариант - пользователь сам вводит цифры, какие ему нравятся.


// int [] randomArray (int size, int minValue, int maxValue)
// {
//     int [] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

int [] randomArray (int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write ($"Please, insert {i + 1} number: ");
        res[i] = int.Parse (Console.ReadLine());
    }
    return res;
}
System.Console.Write("Enter the number of digits in the array: "); // Предположительно, 8
int input = int.Parse (Console.ReadLine());

int [] Array = randomArray(input, 0, 20);
Console.WriteLine(String.Join(" ", Array));

Console.Write("[");
for (int i = 0; i < Array.Length - 1; i++){
    
    Console.Write(Array[i] + ", ");
}
Console.Write(Array[Array.Length - 1]); // Раздражала запятая в конце, поэтому сделал в 35 строке "- 1" и добавил строку 39. Возможно, не совсем правильно, но додумался только до такого пока что)
Console.Write("]");