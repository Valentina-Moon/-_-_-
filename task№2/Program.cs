﻿//1.Понедельник 2.Вторник 3.Среда 4.Четверг 5.Пятница 6.Суббота 7.Воскресение
Console.Write("введите номер дня недели: ");
string username = Console.ReadLine();

if(username.ToLower() == "1")

{
     Console.WriteLine("Бедный понедельник, его ж никто не любит! 03.10.2022");
}

if(username.ToLower() == "2")
{
     Console.WriteLine("Вторник. В небе тучки. Солнца по чуть-чуть…. Хочется на ручки, Водки и уснуть. 04.10.2022");
}

if(username.ToLower() == "3")
{
     Console.WriteLine("По народным поверьям среда и пятница — два Ангела, которые проведут человека в рай, если он соблюдал пост в эти дни. 05.10.2022");
}

if(username.ToLower() == "4")
{
     Console.WriteLine("Четверг давно переименовать в «завтра пятница! 06.10.2022");
}

if(username.ToLower() == "5")
{
     Console.WriteLine(" Пятница - это друг человека! 07.10.2022");
}

if(username.ToLower() == "6")
{
     Console.WriteLine("Суббота - любимы праздник народа! 08.10.2022");

}

if(username.ToLower() == "7")
{
     Console.WriteLine("В каждом яйце-воскресенье настойчиво долбит клювом скорлупу изнутри злобный птенец-понедельник.! 09.10.2022");
}

else
{
    Console.WriteLine("выбирете значение дня недели из 1, 2, 3, 4, 5, 6, 7 ");
    
}











