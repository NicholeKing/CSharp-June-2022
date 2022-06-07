class Animal 
{
    // Establish the attributes of the class
    // Words you used to describe an item
    public string Species;
    public double Weight;
    public string Diet;
    public bool isFriendly;

    // This is our constructor
    public Animal(string species, double weight, string diet)
    {
        Species = species;
        Weight = weight;
        Diet = diet;
        isFriendly = false;
    }

    public Animal(string species, double weight, string diet, bool isFr)
    {
        Species = species;
        Weight = weight;
        Diet = diet;
        isFriendly = isFr;
    }
    // A second constructor that takes only 2 attributes and auto fills the last one
    public Animal(string species, double weight)
    {
        Species = species;
        Weight = weight;
        Diet = "Omnivore";
    }

    // Methods (function) these are the things an animal can do

    public void makeNoise(string sound)
    {
        Console.WriteLine($"The {Species} made the sound: {sound}");
    }
}