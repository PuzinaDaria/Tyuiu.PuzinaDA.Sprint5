using Tyuiu.PuzinaDA.Sprint5.Task4.V18.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V18.txt");
            FileInfo fl = new FileInfo(path);
            Assert.IsTrue(fl.Exists);
        }
    }
}