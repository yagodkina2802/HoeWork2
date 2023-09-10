// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);

void SecondDigit(int number)
{
   if(num>100 && num<1000)
   {
        int FirstDigit = num/10;
        int SecondDigit = FirstDigit%10;
        Console.WriteLine(SecondDigit);
   }
   else
   {
    Console.WriteLine("Это не трехзнаяное число");
   }

}

SecondDigit(num);
