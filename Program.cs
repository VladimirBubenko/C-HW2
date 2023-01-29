// Домашнее задание 2 - C#

// Задача 10. Программа, принимает трехзначное значение, и на выходе показывает вторую цифру этого числа

// int findsecond(int number)
// {
//     int num = (number/10)%10;
//     return num; 
// }
// Console.Write("Введите число: ");
// int newnumber = Convert.ToInt32(Console.ReadLine());
// int result = findsecond(newnumber);
// Console.WriteLine(result);

// Задача 13. Программа, которая выводит третью цифру заданного числа (любого)
/*
int findthird (int number)
{
    if (number >= 100 || number <= -100)
    {
        while(number/1000 > 0 || number/1000 < 0)
        {
            number = number/10;
        }
        int find= number%10;
        return find;
    }
    else
    {
        return -1;
    }
}
Console.Write("Введите число: ");
int newnumber = Convert.ToInt32(Console.ReadLine());
int result = findthird(newnumber);
Console.WriteLine(result);
*/

// Задача 15. Программа, которая принимает цифру (обозначающую день недели), и проверяет, является этот день выходным?

bool free(int day)
{
    if(day < 6)
    {
       return false;
    }
    else
    {
        return true;
    }

}
Console.Write("Введите день недели: ");
int newnumber = Convert.ToInt32(Console.ReadLine());
bool end = free(newnumber);
Console.WriteLine(end);