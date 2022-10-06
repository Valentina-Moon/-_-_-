// Выяснить, кратно ли число заданному, если нет, вывести остаток.
double numberA = 668;
double numberB = 17;
if(numberA%numberB  == 0)
{
    Console.WriteLine("нет остатка, число кратно");
}
else
{
    Console.Write("число не кратно, остаток:");
    Console.WriteLine(numberA%numberB );
}
