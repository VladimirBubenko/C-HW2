// Домашнее задание 2 - C#

// Задача 10. Программа, принимает трехзначное значение, и на выходе показывает вторую цифру этого числа

int findsecond(int number)
{
    int num = (number/10)%10;
    return num; 
}
Console.Write("Введите число: ");
int newnumber = Convert.ToInt32(Console.ReadLine());
int result = findsecond(newnumber);
Console.WriteLine(result);

