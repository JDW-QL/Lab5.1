using System;
using System.Collections.Generic;
namespace Lab5._1
{
    class Progran
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            Console.WriteLine("Welcome to the world of Dev.BuildCraft");

            // Tnargthe Barbarian(int 9, strength 16)Axe
            gameCharacters.Add(new Warrior("Axe", "Tnarg the Barbarian", 16, 9));
            gameCharacters.Add(new Warrior("Longsword", "Kincaid the Fighter", 15, 16));
            gameCharacters.Add(new Warrior("Spear", "Grant the Viking", 15, 16));
            gameCharacters.Add(new Wizard(5, "Lady Witherelle the Wizard", 11, 18, 10));
            gameCharacters.Add(new Wizard(4, "Pearl the Magician", 12, 17, 9));

            Console.WriteLine();
            foreach (var gameCharacter in gameCharacters)
            {
                gameCharacter.Play();
            }
            Console.WriteLine();



        }
    }
}
