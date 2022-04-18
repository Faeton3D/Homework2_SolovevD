int number = 14; int a = 0;

a = number % 10;
if (number / 100 != 0)
{    
    Console.WriteLine(a);
}
else 
    Console.WriteLine($"Третьей цифры в заданном числе нет.");