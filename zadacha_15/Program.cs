/* Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 - да
7 - да
1 -нет*/
 
bool IsWeekend(int weekday)
{
    if(weekday > 5)
    {
        return true;
    }
    return false;
}
bool dateWeekday(int number)
{
    if(number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

Console.WriteLine("Введите день недели:");
int weekday = int.Parse(Console.ReadLine());
if(dateWeekday(weekday))
{
    if(IsWeekend(weekday))
    {
        Console.WriteLine("Наконец-то выходной!");
    }else{
        Console.WriteLine("Придется поработать(");
    }
}


