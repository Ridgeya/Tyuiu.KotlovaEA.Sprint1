using Tyuiu.KotlovaEA.Sprint1.Task7.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Котлова Елизавета Алексеевна | АСОиУБ-26-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям, вводимым пользователем.                          *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*             2          3           2                                    *");
        Console.WriteLine("*      x     y  + 6 + cos x + xy - 2x                                     *");
        Console.WriteLine("* z = e  - ---------------------------                                    *");
        Console.WriteLine("*                4                                                        *");
        Console.WriteLine("*           sin(x  + 13) + 9y - 2                                         *");

        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("z = " +ds.Calculate(x, y));

        Console.WriteLine();
        Console.ReadLine();
    }
}