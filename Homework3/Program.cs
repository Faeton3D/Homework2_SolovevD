int number = -1408; 

number = Math.Abs(number);

if (number <=99)
{
    Console.WriteLine($"Третьей цифры в заданном числе нет.");
}
else
{
    while (number >= 1000)
{
    number /= 10;
}
    Console.WriteLine(number % 10);
}    