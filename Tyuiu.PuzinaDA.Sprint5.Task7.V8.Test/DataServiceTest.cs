using Tyuiu.PuzinaDA.Sprint5.Task7.V8.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask7V8.txt");
            FileInfo fl = new FileInfo(path);
            Assert.IsTrue(fl.Exists);
        }
    }
}