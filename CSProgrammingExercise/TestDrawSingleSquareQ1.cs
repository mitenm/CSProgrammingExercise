using System;
using NUnit.Framework;

namespace CSProgrammingExercise
{
    [TestFixture]
    class TestDrawSingleSquareQ1
    {
        [Test]
        public void TestSingleSquareSizeOne()
        {
            DrawSingleSquare.DrawSquare(1);
        }

        [Test]
        public void TestSingleSquareSizeThree()
        {
            DrawSingleSquare.DrawSquare(3);
        }

        [Test]
        public void TestSingleSquareSizeFour()
        {
            DrawSingleSquare.DrawSquare(4);
        }

        [Test]
        public void TestSingleSquareSizeEight()
        {
            DrawSingleSquare.DrawSquare(8);
        }

        [Test]
        public void TestSingleSquareSizeSixteen()
        {
            DrawSingleSquare.DrawSquare(16);
        }

        [Test]
        public void TestSingleSquareExceptionWithNegativeInt()
        {
            try
            {
                DrawSingleSquare.DrawSquare(-5);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, DrawSingleSquare.InvalidNumberMessage);   
            }
        }

        [Test]
        public void TestSingleSquareExceptionWithZero()
        {
            try
            {
                DrawSingleSquare.DrawSquare(0);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, DrawSingleSquare.InvalidNumberMessage);
            }
        }

        [Test]
        public void TestSingleSquareExceptionDoesNotMatch()
        {
            try
            {
                DrawSingleSquare.DrawSquare(0);
            }
            catch (Exception e)
            {
                Assert.AreNotEqual(e.Message, "Please provide valid inputs");
            }
        }
    }
}