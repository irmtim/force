using Force.Ddd;
using Xunit;

namespace Force.Tests.Ddd
{
    public class ValueObjectTests
    {
        private static TestValueObject vo1 = new TestValueObject("vo1");
        private static TestValueObject vo2 = new TestValueObject("vo2");
        private static TestValueObject vo3 = new TestValueObject("vo1");

        [Fact]
        public void Equals_()
        {
            Assert.False(vo1.Equals(vo2));
            Assert.False(vo1 == vo2);
            Assert.True(vo1 != vo2);

            Assert.False(vo2.Equals(vo3));
            Assert.False(vo2 == vo3);
            Assert.True(vo2 != vo3);

            Assert.False(vo1.Equals(vo3));
        }

        [Fact]
        public void GetHashCode_()
        {
            Assert.Equal(vo1.GetHashCode(), vo3.GetHashCode());
            Assert.NotEqual(vo1.GetHashCode(), vo2.GetHashCode());
        }
    }
}