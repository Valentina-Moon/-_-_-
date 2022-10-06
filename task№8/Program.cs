int numberA = 48;
int numberB = numberA/10;
int numberC = numberA%10;
if(numberB == numberC)
{
    Console.WriteLine(numberA);
    Console.WriteLine(numberB);
    Console.WriteLine("все наибольшие");
}
else if(numberB > numberC)
{
    Console.WriteLine(numberA);
    Console.WriteLine(numberB);
    Console.WriteLine("первое значение больше");
}
else
{
    Console.WriteLine(numberA);
    Console.WriteLine(numberC);
    Console.WriteLine("второе значенте больше");
}