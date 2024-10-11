using System.Globalization;
using Tyuiu.PuzinaDA.Sprint5.Task4.V18.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt, в котором есть      *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* Х в формуле                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask4V18.txt");
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
