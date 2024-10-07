using Tyuiu.PuzinaDA.Sprint5.Task1.V4.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fl = new FileInfo(path);
            bool res = fl.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}