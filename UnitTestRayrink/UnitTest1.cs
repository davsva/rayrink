using Microsoft.VisualStudio.TestTools.UnitTesting;
using rayrink;

namespace UnitTestRayrink
{
    [TestClass]
    public class UnitTestBasics
    {
        [TestMethod]
        public void TestVector()
        {
            Vector v = new Vector(4f, -4f, 3f);
            Assert.IsInstanceOfType(v, typeof(Tuple));
            Assert.IsFalse(v.IsPoint());
            Assert.IsTrue(v.IsVector());
        }

        [TestMethod]
        public void TestPoint()
        {
            Point p = new Point(4f, -4f, 3f);
            Assert.IsInstanceOfType(p, typeof(Tuple));
            Assert.IsTrue(p.IsPoint());
            Assert.IsFalse(p.IsVector());
        }

        [TestMethod]
        public void TestTupleVector()
        {
            Tuple a = new Tuple(4.3f, -4.2f, 3.1f, 0.0f);
            Assert.AreEqual(4.3f, a.X);
            Assert.AreEqual(-4.2f, a.Y);
            Assert.AreEqual(3.1f, a.Z);
            Assert.AreEqual(0.0f, a.W);
            Assert.IsFalse(a.IsPoint());
            Assert.IsTrue(a.IsVector());
        }

        [TestMethod]
        public void TestTuplePoint()
        {
            Tuple a = new Tuple(4.3f, -4.2f, 3.1f, 1.0f);
            Assert.AreEqual(4.3f, a.X);
            Assert.AreEqual(-4.2f, a.Y);
            Assert.AreEqual(3.1f, a.Z);
            Assert.AreEqual(1.0f, a.W);
            Assert.IsTrue(a.IsPoint());
            Assert.IsFalse(a.IsVector());
        }
    }
}
