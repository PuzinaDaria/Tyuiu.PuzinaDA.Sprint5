using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PuzinaDA.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double count;
            string strc;
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            if (fle)
            {
                File.Delete(path);
            }
            for (int i = startValue; i <= stopValue; i++)
            {
                

                count = Math.Round((((Math.Cos(i))/(i+1)) - Math.Cos(i) * 1.3 + 3*i), 2);
                strc = Convert.ToString(count);
                if (i == -1)
                {
                    File.AppendAllText(path, "0" + "\t");
                }
                else if (i != stopValue)
                {
                    File.AppendAllText(path, strc + "\t");
                }
                else
                {
                    File.AppendAllText(path, strc);
                }
            }
            return path;
        }
    }
}
