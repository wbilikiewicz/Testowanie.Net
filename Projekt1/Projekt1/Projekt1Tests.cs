using System;
using NUnit.Framework;

namespace Projekt1
{
    public class Projekt1Tests
    {
        [TestFixture]
        public class UnitTest1
        {
            private TestCollection Test;

            [Test]
            public void TestMethod1()
            {
                Test topkek = new Test();

                Assert.AreEqual(topkek.daj(4), 9);
            }
            [Test]
            public void TestString()
            {
                TestDane toplel = new TestDane();
                StringAssert.Contains(toplel.poloncz("Kowalska"), "KowalskaAnna");
            }
            [Test]
            public void TestCollection()
            {
                Test = new TestCollection();
                System.Collections.Generic.List<int> expected = new System.Collections.Generic.List<int>();
                expected.Add(10);
                expected.Add(20);
                expected.Add(30);

                CollectionAssert.AreEqual(Test.actual, expected);
            }
        }
    }
}
