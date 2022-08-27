namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        public InvoiceGenarator invoiveGenerator;
        [TestMethod]
        public void TestMethod1()
        {
            invoiveGenerator = new InvoiceGenarator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenrator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare); 
        }
    }

   