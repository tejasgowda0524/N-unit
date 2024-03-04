
using a1;
namespace demo12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 32;
            double y = 0;
           double res =  a1.convert.f2c(x);
            Assert.AreEqual(y,res);
            Assert.AreEqual(100,a1.convert.f2c(212));
        }
    }
}