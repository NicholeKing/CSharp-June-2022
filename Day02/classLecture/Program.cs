// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// First instance of an animal
Animal Dog = new Animal("Dog", 60.2, "Omnivore", true);
Animal Cat = new Animal("Cat", 18.3, "Omnivore", true);
Animal Bear = new Animal("Bear", 160.2, "Omnivore");
Animal Coyote = new Animal("Coyote", 56.2);

Console.WriteLine(Dog.Species);
Console.WriteLine(Bear.isFriendly);
Console.WriteLine(Dog.isFriendly);
Console.WriteLine(Coyote.Diet);

Dog.makeNoise("Bark");

Mammal lion = new Mammal("Lion", 120.5, "Carnivore");

Console.WriteLine(lion.Species);
Console.WriteLine(lion.hasFur);
Console.WriteLine(lion.isFriendly);
lion.makeNoise("Roar");


Aquatic fish = new Aquatic("Shark", 1000.0, "Carnviore", false, 8);

Console.WriteLine(fish.numFins);
fish.makeNoise();