class Mammal : Animal
{
    public bool hasFur = true;

    public Mammal(string species, double weight, string diet, bool isFriendly) : base(species, weight, diet, isFriendly)
    {}

    public Mammal(string sp, double w, string d) : base(sp, w, d) {}
}