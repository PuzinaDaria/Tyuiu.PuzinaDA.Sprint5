using Tyuiu.PuzinaDA.Sprint5.Task7.V8.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask7V8.txt");
            string res = ds.LoadDataAndSave(path);

        }
    }
}
