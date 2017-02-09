namespace Solution
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTest1()
        {
            object[][] a = new object[9][];
            a[0] = new object[0] { }; a[1] = new object[0] { }; a[2] = new object[0] { }; a[3] = new object[0] { };
            a[4] = new object[0] { }; a[5] = new object[0] { }; a[6] = new object[0] { }; a[7] = new object[0] { };
            a[8] = new object[0] { };
            long expected = 0;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
        [Test]
        public void BasicTest2()
        {
            object[][] a = new object[9][];
            a[0] = new object[9] { 4, 3, 7, 8, 9, 2, 1, 5, 'c' };
            a[1] = new object[9] { 6, 5, 6, 1, 'v', 1, 0, 5, 1 };
            a[2] = new object[9] { 4, 4, 'c', 7, 6, 6, 3, 6, 7 };
            a[3] = new object[9] { 1, 7, 7, 'l', 5, 8, 9, 5, 9 };
            a[4] = new object[9] { 0, 't', 8, 2, 8, 9, 0, 8, 0 };
            a[5] = new object[9] { 4, 6, 2, 6, 'o', 8, 4, 2, 4 };
            a[6] = new object[9] { 3, 6, 9, 2, 0, 8, 2, 3, 'u' };
            a[7] = new object[9] { 9, 3, 1, 9, 4, 4, 'u', 7, 7 };
            a[8] = new object[9] { 0, 'n', 9, 0, 0, 0, 9, 2, 2 };
            long expected = 0;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
        [Test]
        public void BasicTest3()
        {
            object[][] a = new object[9][];
            a[0] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[1] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[2] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[3] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[4] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[5] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[6] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[7] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            a[8] = new object[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            long expected = 25;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
        [Test]
        public void BasicTest4()
        {
            object[][] a = new object[9][];
            a[0] = new object[9] { 1, 1, 5, 4, 4, 2, 5, 1, 5 };
            a[1] = new object[9] { 4, 2, 3, 5, 1, 4, 4, 2, 5 };
            a[2] = new object[9] { 4, 2, 1, 4, 5, 5, 4, 3, 3 };
            a[3] = new object[9] { 2, 1, 5, 1, 1, 1, 1, 2, 4 };
            a[4] = new object[9] { 5, 1, 3, 1, 3, 2, 4, 2, 1 };
            a[5] = new object[9] { 3, 1, 1, 2, 4, 2, 5, 3, 5 };
            a[6] = new object[9] { 5, 2, 5, 3, 3, 4, 3, 4, 1 };
            a[7] = new object[9] { 3, 4, 4, 5, 5, 5, 5, 4, 5 };
            a[8] = new object[9] { 3, 3, 5, 5, 3, 3, 3, 5, 2 };
            long expected = 21420;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
        [Test]
        public void BasicTest5()
        {
            object[][] a = new object[9][];
            a[0] = new object[9] { 9, 4, 5, 8, 0, 9, 1, 1, 3 };
            a[1] = new object[9] { 5, 0, 8, 5, 4, 3, 4, 5, 5 };
            a[2] = new object[9] { 9, 5, 1, 6, 7, 8, 8, 9, 5 };
            a[3] = new object[9] { 9, 9, 7, 8, 6, 2, 0, 2, 9 };
            a[4] = new object[9] { 4, 7, 9, 3, 6, 6, 2, 6, 1 };
            a[5] = new object[9] { 0, 3, 5, 7, 0, 5, 1, 6, 2 };
            a[6] = new object[9] { 7, 8, 4, 1, 0, 1, 6, 0, 0 };
            a[7] = new object[9] { 0, 2, 1, 8, 8, 7, 6, 0, 1 };
            a[8] = new object[9] { 4, 3, 5, 6, 5, 4, 0, 3, 6 };
            long expected = 1970640;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
        [Test]
        public void BasicTest6()
        {
            object[][] a = new object[9][];
            a[0] = new object[9] { 1, 7, 6, 6, 'm', 5, 1, 8, 0 };
            a[1] = new object[9] { 6, 2, 8, 'h', 0, 4, 6, 7, 3 };
            a[2] = new object[9] { 5, 5, 5, 7, 2, 1, 4, 'c', 3 };
            a[3] = new object[9] { 7, 0, 7, 1, 1, 1, 't', 9, 3 };
            a[4] = new object[9] { 8, 9, 2, 4, 4, 'v', 6, 2, 4 };
            a[5] = new object[9] { 'o', 1, 5, 1, 7, 6, 2, 4, 6 };
            a[6] = new object[9] { 8, 8, 8, 9, 4, 8, 9, 9, 'j' };
            a[7] = new object[9] { 4, 9, 8, 'v', 3, 3, 5, 0, 6 };
            a[8] = new object[9] { 1, 8, 6, 8, 7, 'e', 8, 9, 0 };
            long expected = 24226020;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
        [Test]
        public void BasicTest7()
        {
            object[][] a = new object[9][];
            a[0] = new object[9] { 6, 7, 2, 5, 1, 6, 9, 1, 4 };
            a[1] = new object[9] { 4, 4, 7, 1, 2, 9, 7, 6, 7 };
            a[2] = new object[9] { 8, 2, 7, 4, 5, 7, 1, 5, 4 };
            a[3] = new object[9] { 1, 9, 4, 8, 7, 7, 3, 1, 7 };
            a[4] = new object[9] { 9, 3, 9, 8, 1, 1, 5, 6, 7 };
            a[5] = new object[9] { 7, 4, 4, 1, 5, 8, 4, 1, 5 };
            a[6] = new object[9] { 8, 5, 5, 6, 1, 3, 7, 8, 4 };
            a[7] = new object[9] { 7, 2, 8, 6, 5, 7, 9, 5, 7 };
            a[8] = new object[9] { 9, 1, 1, 7, 9, 5, 7, 1, 9 };
            long expected = 398281800;
            Assert.AreEqual(expected, Kata.KiyoLCM(a));
        }
    }
}

