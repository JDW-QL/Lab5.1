using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber;

        public Wizard(int spellNumber, string name, int strength, int intelligence, int magicalEnergy) : base(magicalEnergy, name, strength, intelligence)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($") {SpellNumber} spells");

        }
    }
}
