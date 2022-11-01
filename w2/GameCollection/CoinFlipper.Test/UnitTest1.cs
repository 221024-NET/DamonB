namespace CoinFlipperTests;
using CoinFlipper;

public class UnitTest1
{
    [Fact]
    public void flipsTails()
    {
        Assert.Equal(expected: "Heads",actual: CoinFlipper.HoT(0));
    }
}