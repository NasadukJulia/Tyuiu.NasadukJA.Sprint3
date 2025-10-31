using Tyuiu.NasadukJA.Sprint3.Task5.V19.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в цикле                 *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #19                                                              *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
Console.WriteLine("* функции y=(x/sin(x))+0.5. При х = 0 прервать цикл.                      *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 2;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 6;

Console.WriteLine("Переменная X = " + x);
Console.WriteLine("Старт шага первой суммы ряда - " + startValue1);
Console.WriteLine("Конец шага первой суммы ряда - " + stopValue1);
Console.WriteLine("Старт шага второй суммы ряда - " + startValue2);
Console.WriteLine("Конец шага второй суммы ряда - " + stopValue2);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

Console.ReadKey();