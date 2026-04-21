using GameFrameWorkMA.Modle;
using GameFrameWorkMA.Modle.CreatureFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAmeFRameWorkDeoNuget
{
    public class Orc : creature
    {
        public override string Name { get; set; } = "Orc";

        public Orc(string name, int health, int baseDamage, Cordinate cordinate, bool isAlive, double maxCarryWeight) : base(name, health, baseDamage, new Cordinate(0, 0), isAlive, maxCarryWeight)
        {
        }
        public Orc()
        {

        }
    }
}
