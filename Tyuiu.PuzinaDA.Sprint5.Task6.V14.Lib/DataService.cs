using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PuzinaDA.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            string file = Path.GetTempFileName();
            File.WriteAllText(file, "54*634/6*==-+-596594030*/45+-+3-*/==0--+8*5884546433214343545444+44*/45(894-" +
                "3+769*438-93-45+240+95=7+4*95939(045)749/05*8-49+58+34*095820*0485");
            int count = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line =  sr.ReadLine()) != null)
                {
                    
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '*')
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
