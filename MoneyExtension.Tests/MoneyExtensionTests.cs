namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        var valor = 279.98M;
        var cents = valor.ToCents();
        Assert.AreEqual(27998, cents);
    }
}