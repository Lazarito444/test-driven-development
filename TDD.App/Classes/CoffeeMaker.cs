namespace TDD.App.Classes;

public class CoffeeMaker
{
    private int _coffeeGramsAvailable;

    public CoffeeMaker(int coffeeGramsAvailable = 0)
    {
        _coffeeGramsAvailable = coffeeGramsAvailable;
    }

    public void SetCoffeeGramsAvailable(int coffeeGrams)
    {
        _coffeeGramsAvailable = coffeeGrams;
    }

    public int GetCoffeeGramsAvailable()
    {
        return _coffeeGramsAvailable;
    }

    public bool HasCoffeeGramsAvailable(int coffeeGrams)
    {
        return _coffeeGramsAvailable >= coffeeGrams;
    }

    public void GiveCoffeeGrams(int coffeeGrams)
    {
        if (!HasCoffeeGramsAvailable(coffeeGrams))
        {
            throw new InvalidOperationException("A coffee maker can't give more coffee than what it has");
        }

        _coffeeGramsAvailable -= coffeeGrams;
    }
}