using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PuzinaDA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string file = Path.GetTempFileName();
            File.WriteAllText(file, "ПРИВЕТ, World! This МОЯ ПЕРВАЯ ПРОГРАММА.");
            string saveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V8.txt");
            FileInfo fl = new FileInfo(saveFile);
            if (fl.Exists)
            {
                fl.Delete();
            }

            string str = "";
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsUpper(line[i]) && line[i] >= 'А' && line[i] <= 'Я')
                        {
                            
                            str = str + char.ToLower(line[i]);
                        }
                        else
                        {
                            str = str + line[i];
                        }
                    }
                    File.AppendAllText(saveFile, str);
                }
            }
            return saveFile;
            throw new NotImplementedException();
        }
    }
}
