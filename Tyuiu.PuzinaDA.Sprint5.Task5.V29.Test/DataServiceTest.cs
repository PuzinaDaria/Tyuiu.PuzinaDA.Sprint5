using Tyuiu.PuzinaDA.Sprint5.Task5.V29.Lib;
namespace Tyuiu.PuzinaDA.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            string path = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask5V29.txt");
            FileInfo fl = new FileInfo(path);
            Assert.IsTrue(fl.Exists);
        }
    }
}