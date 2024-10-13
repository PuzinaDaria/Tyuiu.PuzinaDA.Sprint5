using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PuzinaDA.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            string file = Path.GetTempFileName();
            File.WriteAllText(file, "54*634/9==+59659.4030/45++3/==0-+8*588,4546433214343545444+44/4:5(894=3+76438934" +
                "5+240+95=7+495939(045)749/05*849+58+34095820*0485");
            int count = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line =  sr.ReadLine()) != null)
                {
                    
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '.' || line[i] == ',' || line[i] == '-' || line[i] == ':' || line[i] == '?' || line[i] == '!')
                        {
                            count++;
                        }
                    }
                }
                
                
            }
            return count;
            throw new NotImplementedException();
        }
    }
}
