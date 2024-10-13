using Tyuiu.PuzinaDA.Sprint5.Task5.V29.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask4V18.txt");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
