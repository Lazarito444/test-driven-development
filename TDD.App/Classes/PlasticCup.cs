namespace TDD.App.Classes;

public class PlasticCup
{
    private int _plasticCupAmount;
    private int _content;

    public PlasticCup(int plasticCupAmount = 0, int content = 0)
    {
        _plasticCupAmount = plasticCupAmount;
        _content = content;
    }

    public void SetPlasticCupAmount(int amount)
    {
        _plasticCupAmount = amount;
    }

    public int GetPlasticCupAmount()
    {
        return _plasticCupAmount;
    }

    public void SetContent(int content)
    {
        _content = content;
    }

    public int GetContent()
    {
        return _content;
    }

    public bool HasPlasticCups(int amount)
    {
        return _plasticCupAmount >= amount;
    }

    public void GivePlasticCups(int plasticCupsAmount)
    {
        if (!HasPlasticCups(plasticCupsAmount))
        {
            throw new InvalidOperationException("Can't give more plastic cups than the class has");
        }

        _plasticCupAmount -= plasticCupsAmount;
    }
}