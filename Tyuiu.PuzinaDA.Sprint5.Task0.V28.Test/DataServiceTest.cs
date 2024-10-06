using Tyuiu.PuzinaDA.Sprint5.Task0.V28.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            //string path = C:\Users\daria\AppData\Local\Temp\OutPutFileTask0.txt
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fle);


        }
    }
}