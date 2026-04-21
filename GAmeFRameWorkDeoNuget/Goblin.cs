using GameFrameWorkMA.Modle;
using GameFrameWorkMA.Modle.CreatureFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAmeFRameWorkDeoNuget
{
    public class Goblin : creature
    {
        public override string Name { get; set; } = "Goblin";
        public override int Health { get; set; } = 100;
        public override int BaseDamage { get; set; } = 12;
        public override Cordinate Position { get; set; }
        public Goblin(string name, int health, int baseDamage, Cordinate cordinate, bool isAlive, double maxCarryWeight) : base(name, health, baseDamage, cordinate, isAlive, maxCarryWeight)
        {
        }
        public Goblin()
        {

        }
    }
}
