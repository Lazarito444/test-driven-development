using TDD.App.Classes;
using Xunit;

namespace TDD.App.Tests;

public class CoffeeMakerTest
{
    [Fact]
    public void ShouldReturnTrueIfThereAreCoffee()
    {
        CoffeeMaker coffeeMaker = new CoffeeMaker(10);
        bool result = coffeeMaker.HasCoffeeGramsAvailable(5);
        
        Assert.True(result);
    }
    
    [Fact]
    public void ShouldReturnFalseIfThereAreNoCoffee()
    {
        CoffeeMaker coffeeMaker = new CoffeeMaker(2);
        bool result = coffeeMaker.HasCoffeeGramsAvailable(5);
        
        Assert.False(result);
    }
    
    [Fact]
    public void ShouldSubstractCoffeeToTheCoffeeMaker()
    {
        CoffeeMaker coffeeMaker = new CoffeeMaker(10);
        coffeeMaker.GiveCoffeeGrams(5);
        
        Assert.Equal(5, coffeeMaker.GetCoffeeGramsAvailable());
    }
}