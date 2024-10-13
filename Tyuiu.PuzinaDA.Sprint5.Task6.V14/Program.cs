using Tyuiu.PuzinaDA.Sprint5.Task6.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask6V14.txt");
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
