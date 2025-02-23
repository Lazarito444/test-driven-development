using TDD.App.Classes;
using Xunit;

namespace TDD.App.Tests;

public class PlasticCupTest
{
    [Fact]
    public void ShouldReturnTrueIfThereArePlasticCups()
    {
        PlasticCup plasticCup = new PlasticCup(10, 2);
        bool result = plasticCup.HasPlasticCups(5);
        
        Assert.True(result);
    }
    
    [Fact]
    public void ShouldReturnFalseIfThereAreNoPlasticCups()
    {
        PlasticCup plasticCup = new PlasticCup(1, 2);
        bool result = plasticCup.HasPlasticCups(2);
        
        Assert.False(result);
    }
    
    [Fact]
    public void ShouldSubstractPlasticCupAmount()
    {
        PlasticCup plasticCup = new PlasticCup(10, 2);
        plasticCup.GivePlasticCups(2);
        
        Assert.Equal(8, plasticCup.GetPlasticCupAmount());
    }
}