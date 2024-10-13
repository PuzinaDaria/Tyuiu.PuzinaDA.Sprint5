using Tyuiu.PuzinaDA.Sprint5.Task6.V14.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask6V14.txt");
            int res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void Checked2()
        {
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask6V14.txt");
            FileInfo fl = new FileInfo(path);
            Assert.IsTrue(fl.Exists);
        }
    }
}