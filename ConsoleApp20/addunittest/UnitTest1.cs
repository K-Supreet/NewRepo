using ConsoleApp20;
namespace addunittest
{
    [TestClass]
    public class Testcalculator
    {
        [TestMethod]
        public void TestAdd()
        {
           
            Calculator c = new Calculator();
            int result = c.Add(10, 20);
            Assert.AreEqual(30, result);


        }
    }
}