/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 - 5
78 - третьей цифры нет*/

int number3(int number)
{
    int result = -1;
    if(number >=100)
    {
        while(number>999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}
Console.WriteLine("Введите число:");
int number1 = int.Parse(Console.ReadLine());

if(number3(number1) == -1)
{
    Console.WriteLine("третьей цифры нет");
}else{
    Console.WriteLine($"{number3(number1)}");
}

