using System;
using System.Collections.Generic;

enum Species
{
    Human,
    Goblin,
    Unicorn,
    Dwarf,

}


abstract class Character
{
    public string Name { get; set; }

    public Species Species { get; set; }

    public string? Category { get; set; }

    public string? Occupation { get; set; }

    public Character(string name)
    {
        Name = name;
    }

    public virtual void SayName()
    {
        Console.WriteLine($"Jeg hedder {Name}. Jeg er en {Species} {Category} {Occupation}.");
    }

    public void TransformToUndead()
    {
        Category = "Undead";
        Console.WriteLine($"{Name} er blevet forvandlet til Undead!");
    }
}
class Wizard : Character
{
    public Wizard(string name, Species species) : base(name)
    {
        Species = species;      
        Category = "Magical";   
        Occupation = "Wizard";  
    }
}
class Thief : Character
{
    public Thief(string name, Species species) : base(name)
    {
        Species = species;
        Category = "Living";
        Occupation = "Thief";
    }
}
class Vampire : Character
{
    public Vampire(string name, Species species) : base(name)
    {
        Species = species;        
        Category = "Undead";
        Occupation = "Necromancer";
    }
}
class ClockworkPaladin : Character
{
    public ClockworkPaladin(string name, Species species) : base(name)
    {
        Species = species;
        Category = "Mechanical";
        Occupation = "Blacksmith";
    }
}
class Game
{
    private List<Character> characters = new List<Character>();

    public void AddCharacter(Character c)
    {
        characters.Add(c);
    }

    public void IntroduceAllCharacters()
    {
        foreach (Character c in characters)
        {
            c.SayName();
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Character Game:\n");

        Game game = new Game();

        game.AddCharacter(new Wizard("Merlin", Species.Human));
        game.AddCharacter(new Thief("Sneaky", Species.Goblin));
        game.AddCharacter(new Vampire("Dracula", Species.Human));
        game.AddCharacter(new ClockworkPaladin("IronKnight", Species.Dwarf));

        Console.WriteLine("Alle karakterer introducerer sig selv:\n");
        game.IntroduceAllCharacters();

        Console.WriteLine("\nDer er en der forvandler!:");

        Thief simpleThief = new Thief("Michael", Species.Human);
        simpleThief.SayName();
        simpleThief.TransformToUndead();
        simpleThief.SayName();

        Console.WriteLine("\nTak for at prøve mit character game.");
    }
}
