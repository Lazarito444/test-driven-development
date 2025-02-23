namespace TDD.App.Classes;

public class CoffeeMachine
{
    public CoffeeMaker CoffeeMaker;
    public PlasticCup SmallPlasticCup;
    public PlasticCup MediumPlasticCup;
    public PlasticCup LargePlasticCup;
    public SugarBowl SugarBowl;

    public CoffeeMachine(CoffeeMaker coffeeMaker, PlasticCup smallPlasticCup, PlasticCup mediumPlasticCup, PlasticCup largePlasticCup, SugarBowl sugarBowl)
    {
        CoffeeMaker = coffeeMaker;
        SmallPlasticCup = smallPlasticCup;
        MediumPlasticCup = mediumPlasticCup;
        LargePlasticCup = largePlasticCup;
        SugarBowl = sugarBowl;
    }

    public PlasticCup GetPlasticCupSize(int cupSize)
    {
        if (cupSize >= 2) return LargePlasticCup;
        if (cupSize == 1) return MediumPlasticCup;
        return SmallPlasticCup;
    }

    public bool GetCoffeeCup(int cupSize, int cupAmount, int sugarAmount)
    {
        PlasticCup cup = GetPlasticCupSize(cupSize);
        cup.GivePlasticCups(cupAmount);
        SugarBowl.GiveSugarGrams(sugarAmount * cupAmount);
        CoffeeMaker.GiveCoffeeGrams(2 * cupAmount);

        return true;
    }
}