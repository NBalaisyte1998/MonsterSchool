using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsterschool
{
    class Program
    {
        static void Main(string[] args)
        {
            Monsters monsterA = new Monsters("NB1", 5, new Eyes(), new Hair(), new SpecialAbility());
            monsterA.Jump();
            monsterA.Scare();
            Console.Read();
        }
    }
    class Monsters
    {
        private string id; // an id of the monster
        private int scaryLevel; // how scary the monster will be
        private Eyes eyes; // as an object because it will be like an attribute of the monster
        private Hair hair; // the hair of the monster
        private SpecialAbility ability; // the special ability of the monster

        public Monsters(string id, int scaryLevel, Eyes eyes, Hair hair, SpecialAbility ability)
        {
            this.id = id;
            this.scaryLevel = scaryLevel;
            this.eyes = eyes;
            this.hair = hair;
            this.ability = ability;

        }

        public void Jump()
        {
            Console.WriteLine("The monster with id : {0} jumps!",id);
            // Makes the monster jump
        }

        public void Scare()
        {
            Console.WriteLine("The monster with the id : {0} scares!", id);
            //Makes the monster with that id to scare
        }
    }
    class Monstercohort
    {
    }
    class Eyes
    {
    }
    class Hair
    { }
    class SpecialAbility
    { }
}
