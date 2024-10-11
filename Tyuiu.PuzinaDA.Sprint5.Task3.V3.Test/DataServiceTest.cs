using Tyuiu.PuzinaDA.Sprint5.Task3.V3.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fl = new FileInfo(path);
            Assert.IsTrue(fl.Exists);
        }
    }
}