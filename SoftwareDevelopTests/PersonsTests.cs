using SBeregovoy.SoftDevelop.Domain;

namespace SBeregovoy.SoftDevelop.SoftwareDevelopTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ManagerTotalPay()
        {
            //
            //10 000 + 11 000 + 8750 = 29 750 
            Manager manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord(DateTime.Now.AddDays(-3), "test", 8, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-2), "test", 9, "test message"),
                new TimeRecord(DateTime.Now.AddDays(-1), "test", 7, "test message"),

                //гдеяэ онксвюеряъ гю рпх дмъ
                
            });
            //Console.WriteLine(manager.TotalPay); //29750
            Assert.IsTrue(manager.TotalPay == 29750);
        }

        [Test]
        public void ManagerTotalPay2()
        {
            //
            //10 000
            Manager manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord(DateTime.Now.AddDays(-3), "test", 8, "test message"),

                //гдеяэ онксвюеряъ гю ндхм демэ
                
            });
            //Console.WriteLine(manager.TotalPay); //10000
            Assert.IsTrue(manager.TotalPay == 10000);
        }
    }
}