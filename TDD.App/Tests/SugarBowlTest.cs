using TDD.App.Classes;
using Xunit;

namespace TDD.App.Tests;

public class SugarBowlTest
{
    [Fact]
    public void ShouldReturnTrueIfThereIsEnoughSugar()
    {
        SugarBowl sugarBowl = new SugarBowl(10);
        bool result = sugarBowl.HasSugarGramsAvailable(2);
        
        Assert.True(result);
    }
    
    [Fact]
    public void ShouldReturnFalseIfThereIsNotEnoughSugar()
    {
        SugarBowl sugarBowl = new SugarBowl(1);
        bool result = sugarBowl.HasSugarGramsAvailable(2);
        
        Assert.False(result);
    }
    
    [Fact]
    public void ShouldSubstractSugarToTheSugarBowl()
    {
        SugarBowl sugarBowl = new SugarBowl(10);
        sugarBowl.GiveSugarGrams(2);
        
        Assert.Equal(8, sugarBowl.GetSugarGramsAvailable());
    }
}