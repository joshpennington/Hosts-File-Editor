using NUnit.Framework;

using OCaff.Framework.Extensions;

namespace OCaff.Framework.Tests.Extensions
{
    /// <summary>
    /// Test fixture for the <see cref="NumericHelper"/>.
    /// </summary>
    [TestFixture]
    public sealed class Test_NumericHelper
    {
        #region --------------- Tests --------------

        /// <summary>
        /// Tests to make sure that <see cref="NumericHelper.Between"/> returns <see langword="true"/> when the number
        /// is between (inclusive) the two numbers provided.
        /// </summary>
        [Test]
        public void Between()
        {
            Assert.That(2.Between(2, 2));
            Assert.That(2.Between(1, 3));
            Assert.That(2.Between(3, 1), Is.False);
            Assert.That(2.Between(3, 5), Is.False);
        }

        /// <summary>
        /// Tests to make sure that <see cref="NumericHelper.Compare"/> returns results as expected by framework compare methods.
        /// </summary>
        [Test]
        public void Compare()
        {
            Assert.That(1.Compare(2), Is.EqualTo(-1));
            Assert.That(2.Compare(1), Is.EqualTo(1));
            Assert.That(1.Compare(1), Is.EqualTo(0));
        }

        /// <summary>
        /// Tests to make sure that <see cref="NumericHelper.Maximum"/> always returns a value less than or equal to the maximum value passed.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="expected"></param>
        [Test]
        [Sequential]
        public void Maximum([Values(1, 2, 3)] int original, [Values(1, 2, 2)] int expected)
        {
            Assert.That(original.Maximum(2), Is.EqualTo(expected));
        }

        /// <summary>
        /// Tests to make sure that <see cref="NumericHelper.Minimum(int,int)"/> always returns a value greater than or
        /// equal to the minimum value passed.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="expected"></param>
        [Test]
        [Sequential]
        public void Minimum([Values(1, 2, 3)] int original, [Values(2, 2, 3)] int expected)
        {
            Assert.That(original.Minimum(2), Is.AtLeast(expected));
        }

        /// <summary>
        /// Tests to make sure that <see cref="NumericHelper.Minimum(double,double)"/> always returns a value greater than or
        /// equal to the minimum value passed.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="expected"></param>
        [Test]
        [Sequential]
        public void Minimum([Values(1, 2, 3)] double original, [Values(2, 2, 3)] double expected)
        {
            Assert.That(original.Minimum(2), Is.AtLeast(expected));
        }

        #endregion
    }
}