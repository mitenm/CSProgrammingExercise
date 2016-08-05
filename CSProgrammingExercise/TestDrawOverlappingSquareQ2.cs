using System;
using NUnit.Framework;

namespace CSProgrammingExercise
{
    [TestFixture]
    class TestDrawOverlappingSquareQ2
    {
        [Test]
        public void TestOverlappingSquareSizeOne()
        {
            DrawOverlappingSquares.DrawSquare(1,1);
        }

        [Test]
        public void TestOverlappingSquareThreeByFive()
        {
            DrawOverlappingSquares.DrawSquare(3,5);
        }

        [Test]
        public void TestOverlappingSquareFiveByNine()
        {
            DrawOverlappingSquares.DrawSquare(5,9);
        }

        [Test]
        public void TestOverlappingSquareTenByTwenty()
        {
            DrawOverlappingSquares.DrawSquare(10, 20);
        }

        [Test]
        public void TestOverlappingSquareExceptionWithNegativeInt()
        {
            try
            {
                DrawOverlappingSquares.DrawSquare(-5,3);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, DrawOverlappingSquares.InvalidNumberMessage);
            }
        }

        [Test]
        public void TestOverlappingSquareExceptionDoesNotMatch()
        {
            try
            {
                DrawOverlappingSquares.DrawSquare(3,-2);
            }
            catch (Exception e)
            {
                Assert.AreNotEqual(e.Message, "Please provide valid inputs");
            }
        }

        [Test]
        public void TestOverlappingSquareInnerBiggerThanOuter()
        {
            try
            {
                DrawOverlappingSquares.DrawSquare(3, 1);
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message,DrawOverlappingSquares.InvalidInnerSquareSizeMessage);
            }
        }

        [Test]
        public void TestOverlappingSquareInnerBiggerThanOuterExceptionDoesNotMatch()
        {
            try
            {
                DrawOverlappingSquares.DrawSquare(3, 1);
            }
            catch (Exception e)
            {
                Assert.AreNotEqual(e.Message, "Size of inner square is bigger then outer one. Please correct the inputs");
            }
        }
    }
}
