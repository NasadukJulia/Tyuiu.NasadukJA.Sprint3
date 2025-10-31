using Tyuiu.NasadukJA.Sprint3.Task6.V1.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
Console.WriteLine("* числовому отрезку [11, 17] сумму всех делителей.                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = 11;
int stopValue = 17;

Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма всех делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadKey();