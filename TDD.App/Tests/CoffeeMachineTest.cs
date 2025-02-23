using TDD.App.Classes;
using Xunit;

namespace TDD.App.Tests;

public class CoffeeMachineTest
{
    private CoffeeMachine _coffeeMachine;
    
    public CoffeeMachineTest()
    {
        _coffeeMachine = new CoffeeMachine(
            new CoffeeMaker(20),
            new PlasticCup(10, 0),
            new PlasticCup(5, 1),
            new PlasticCup(10, 2),
            new SugarBowl(15)
        );
    }
    
    [Fact]
    public void ShouldReturnASmallPlasticCup()
    {
        PlasticCup plasticCup = _coffeeMachine.GetPlasticCupSize(0);
        
        Assert.Equal(_coffeeMachine.SmallPlasticCup, plasticCup);
    }
    
    [Fact]
    public void ShouldReturnAMediumPlasticCup()
    {
        PlasticCup plasticCup = _coffeeMachine.GetPlasticCupSize(1);
        
        Assert.Equal(_coffeeMachine.MediumPlasticCup, plasticCup);
    }
    
    [Fact]
    public void ShouldReturnALargePlasticCup()
    {
        PlasticCup plasticCup = _coffeeMachine.GetPlasticCupSize(2);
        
        Assert.Equal(_coffeeMachine.LargePlasticCup, plasticCup);
    }
    
    [Fact]
    public void ShouldThrowAnExceptionIfThereIsNoCoffee()
    {
        Assert.Throws<InvalidOperationException>(() => _coffeeMachine.GetCoffeeCup(2, 15, 10));
    }
    
    [Fact]
    public void ShouldThrowAnExceptionIfThereIsNoSugar()
    {
        Assert.Throws<InvalidOperationException>(() => _coffeeMachine.GetCoffeeCup(2, 15, 10));
    }
    
    [Fact]
    public void ShouldSubstractSugar()
    {
        int sugarBeforeMakingCoffee = _coffeeMachine.SugarBowl.GetSugarGramsAvailable();
        
        _coffeeMachine.GetCoffeeCup(1, 1, 2);

        int sugarAfterMakingCoffee = _coffeeMachine.SugarBowl.GetSugarGramsAvailable();

        bool result = sugarAfterMakingCoffee != sugarBeforeMakingCoffee;
        
        Assert.True(result);
    }
    
    [Fact]
    public void ShouldSubstractPlasticCups()
    {
        int mediumCupsBeforeMakingCoffee = _coffeeMachine.MediumPlasticCup.GetPlasticCupAmount();
        
        _coffeeMachine.GetCoffeeCup(1, 2, 2);

        int mediumCupsAfterMakingCoffee = _coffeeMachine.MediumPlasticCup.GetPlasticCupAmount();

        bool result = mediumCupsBeforeMakingCoffee != mediumCupsAfterMakingCoffee;
        
        Assert.True(result);
    }
    
    [Fact]
    public void ShouldSubstractCoffee()
    {
        int coffeeGramsAvailableBeforeMakingCoffee = _coffeeMachine.CoffeeMaker.GetCoffeeGramsAvailable();
        
        _coffeeMachine.GetCoffeeCup(1, 2, 2);

        int coffeeGramsAvailableAfterMakingCoffee = _coffeeMachine.CoffeeMaker.GetCoffeeGramsAvailable();

        bool result = coffeeGramsAvailableAfterMakingCoffee != coffeeGramsAvailableBeforeMakingCoffee;
        
        Assert.True(result);
    }
    
    [Fact]
    public void ShouldReturnCongratulations()
    {
        Assert.True(_coffeeMachine.GetCoffeeCup(1, 1, 1));
    }
}