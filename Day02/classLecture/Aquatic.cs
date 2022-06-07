class Aquatic : Animal
{
    public bool hasFur = false;
    public int numFins;

    public Aquatic(string species, double weight, string diet, bool isFriendly, int numF) : base(species, weight, diet, isFriendly)
    {
        numFins = numF;
    }

    public Aquatic(string sp, double w, string d, int numF) : base(sp, w, d) {
        numFins = numF;
    }

    public void makeNoise()
    {
        Console.WriteLine("Fish don't make a sound");
    }
}