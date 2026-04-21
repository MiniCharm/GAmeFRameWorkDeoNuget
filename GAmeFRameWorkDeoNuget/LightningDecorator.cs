using GameFrameWorkMA.Modle.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAmeFRameWorkDeoNuget
{
    public class LightningDecorator : AttackItemDecorator
    {
        public LightningDecorator(AttackItem _innerAttackItem) : base(_innerAttackItem)
        {
        }
        public override string Name => _innerAttackItem.Name + " with Lightning";
        public override Damage AttackDamage => new Damage(_innerAttackItem.AttackDamage.Damagepoint + 15);
    }
}
