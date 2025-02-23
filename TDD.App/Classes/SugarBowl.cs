namespace TDD.App.Classes;

public class SugarBowl
{
    private int _sugarGramsAvailable;

    public SugarBowl(int sugarGramsAvailable = 0)
    {
        _sugarGramsAvailable = sugarGramsAvailable;
    }

    public void SetSugarGramsAvailable(int sugarGramsAvailable)
    {
        _sugarGramsAvailable = sugarGramsAvailable;
    }

    public int GetSugarGramsAvailable()
    {
        return _sugarGramsAvailable;
    }

    public bool HasSugarGramsAvailable(int sugarGrams)
    {
        return _sugarGramsAvailable >= sugarGrams;
    }

    public void GiveSugarGrams(int sugarGrams)
    {
        if (!HasSugarGramsAvailable(sugarGrams))
        {
            throw new InvalidOperationException("A sugar bowl can't give more sugar than what it has");
        }

        _sugarGramsAvailable -= sugarGrams;
    }
}