using Helpers;

namespace TestProject1
{
    [TestClass]
    public sealed class AdditionTests
    {
        [TestMethod]
        public void Addition_ValidateValue_ReturnsCorrectResult()
        {
            var result = Addition.ValidateValue(null);
            Assert.IsNull(result);
        }
    }
}
