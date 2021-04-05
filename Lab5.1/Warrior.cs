using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior( string weaponType, string name, int strength, int intelligence) : base (name, strength, intelligence )
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($") {WeaponType}");

        }
    }
}
