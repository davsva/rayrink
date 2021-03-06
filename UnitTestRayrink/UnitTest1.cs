using Microsoft.VisualStudio.TestTools.UnitTesting;
using rayrink;

namespace UnitTestRayrink
{
    [TestClass]
    public class UnitTestBasics
    {

        [TestMethod]
        public void TestNormalization()
        {
            Vector v1 = new Vector(4f, 0f, 0f);
            Assert.AreEqual(new Vector(1f, 0f, 0f), v1.Normalize());

            Vector v2 = new Vector(1f, 2f, 3f);
            Assert.AreEqual(new Vector(0.26726f, 0.53452f, 0.80178f), v2.Normalize());

            Vector v3 = new Vector(1f, 2f, 3f);
            Assert.IsTrue(MathHelper.IsEqual(1f, v3.Normalize().Magnitude()));
        }

        [TestMethod]
        public void TestMagnitude()
        {
            Vector v1 = new Vector(1f, 0f, 0f);
            Assert.AreEqual(1f, v1.Magnitude());

            Vector v2 = new Vector(0f, 1f, 0f);
            Assert.AreEqual(1f, v2.Magnitude());

            Vector v3 = new Vector(0f, 0f, 1f);
            Assert.AreEqual(1f, v3.Magnitude());

            Vector v4 = new Vector(1f, 2f, 3f);
            Assert.AreEqual((float)System.Math.Sqrt(14), v4.Magnitude());

            Vector v5 = new Vector(-1f, -2f, -3f);
            Assert.AreEqual((float)System.Math.Sqrt(14), v5.Magnitude());
        }

        [TestMethod]
        public void TestDividingTupleByScalar()
        {
            Tuple a = new Tuple(1f, -2f, 3f, -4f);
            Assert.AreEqual(new Tuple(0.5f, -1f, 1.5f, -2f), a / 2f);
        }

        [TestMethod]
        public void TestMultyplyingTupleByFraction()
        {
            Tuple a = new Tuple(1f, -2f, 3f, -4f);
            Assert.AreEqual(new Tuple(0.5f, -1f, 1.5f, -2f), a * 0.5f);
        }

        [TestMethod]
        public void TestMultyplyingTupleByScalar()
        {
            Tuple a = new Tuple(1f, -2f, 3f, -4f);
            Assert.AreEqual(new Tuple(3.5f, -7f, 10.5f, -14f), a * 3.5f);
        }

        [TestMethod]
        public void TestNegatingTuple()
        {
            Tuple a = new Tuple(1f, -2f, 3f, -4f);
            Assert.AreEqual(new Tuple(-1f, 2f, -3f, 4f), -a);
        }

        [TestMethod]
        public void TestSubtractVectorFromZeroVector()
        {
            Vector zero = new Vector(0f, 0f, 0f);
            Vector v = new Vector(1f, -2f, 3f);
            Assert.AreEqual(new Vector(-1f, 2f, -3f), zero - v);
        }

        [TestMethod]
        public void TestTupleSubtractionTwoVectors()
        {
            Vector v1 = new Vector(3f, 2f, 1f);
            Vector v2 = new Vector(5f, 6f, 7f);
            Assert.AreEqual(new Vector(-2f, -4f, -6f), v1 - v2);
        }

        [TestMethod]
        public void TestTupleSubtractionVectorFromPoint()
        {
            Point p = new Point(3f, 2f, 1f);
            Vector v = new Vector(5f, 6f, 7f);
            Assert.AreEqual(new Point(-2f, -4f, -6f), p - v);
        }

        [TestMethod]
        public void TestTupleSubtractionTwoPoints()
        {
            Point p1 = new Point(3f, 2f, 1f);
            Point p2 = new Point(5f, 6f, 7f);
            Assert.AreEqual(new Vector(-2f, -4f, -6f), p1 - p2);
        }

        [TestMethod]
        public void TestTupleAddition()
        {
            Tuple a1 = new Tuple(3f, -2f, 5f, 1f);
            Tuple a2 = new Tuple(-2f, 3f, 1f, 0f);
            Assert.AreEqual(new Tuple(1f, 1f, 6f, 1f), a1 + a2);
        }

        [TestMethod]
        public void TestTupleEquality()
        {
            Point p1 = new Point(2f, -3f, 4f);
            Point p2 = new Point(2f, 6f, 4f);
            Point p3 = new Point(2f, -3f, 4f);
            Vector v1 = new Vector(2f, -3f, 4f);
            Tuple t1 = new Tuple(2f, -3f, 4f, 1.0f);
            Assert.AreEqual(p1, p3);
            Assert.AreNotEqual(p1, p2);
            Assert.AreNotEqual(p2, v1);
            Assert.AreEqual(p1, t1);
        }

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
