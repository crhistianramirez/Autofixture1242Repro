using AutoFixture;
using NUnit.Framework;

namespace Autofixture1242Repro
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, AutoNSubstituteDataAttribute]
        public void ThisTestFails(MyOrder myOrder)
        {
            System.Console.WriteLine("fails");
            Assert.NotNull(myOrder.xp.Color);
        }

        [Test]
        public void ThisTestSucceeds()
        {
            var fixture = new Fixture();
            var myOrder = fixture.Create<MyOrder>();
            myOrder.xp = fixture.Create<MyOrderXP>();
            Assert.NotNull(myOrder.xp.Color);
        }
    }
}