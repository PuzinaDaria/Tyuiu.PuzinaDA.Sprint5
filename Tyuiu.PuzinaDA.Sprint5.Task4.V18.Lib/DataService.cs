using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PuzinaDA.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string file = Path.GetTempFileName();
            File.WriteAllText(file, "1,79");
            string strX = File.ReadAllText(file);
            double x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Cos(x) + (Math.Pow(x, 2) / 2)), 3);
            return res;
        }
    }
}
