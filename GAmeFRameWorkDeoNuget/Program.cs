// See https://aka.ms/new-console-template for more information
using GAmeFRameWorkDeoNuget;
using GameFrameWorkMA.Modle;
using GameFrameWorkMA.Modle.CreatureFolder;
using GameFrameWorkMA.Modle.Weapons;
using GameFrameWorkMA.Service;

Console.WriteLine("Hello, World!");


MyLogger.Instance.LogInfo("Game started");
// Lav creatures
var orc = new Orc();
var elf = new Elf();
var goblin = new Goblin();

//Lav våben
var cHeavy = new AttackItem("Heavy club", new Damage(15), 2, 100.0, new Cordinate(1, 1));
var sword = new AttackItem("Sword", new Damage(10), 1, 6.2, new Cordinate(0, 3));

//Defence item
var shield = new DefenceItem("Shield", 5, new Cordinate(2, 2));
var helmet = new DefenceItem("Helmet", 10, new Cordinate(4, 3));
WorldObject Chest = new DefenceItem("Chest", 20, new Cordinate(5, 5));
Chest.IsLootable = true;
Chest.IsRemovable = false;

// Lav en verden
List<WorldObject> items = new List<WorldObject>() { cHeavy, sword, shield, helmet };
List<creature> creatures = new List<creature>() { orc, elf, goblin };

var world = new World(10, 10, items, creatures);

// Observer
var observer = new CreatureObserver();
orc.AddObserver(observer);
elf.AddObserver(observer);
goblin.AddObserver(observer);

// Loot Våben

var fireSword = new LightningDecorator(sword);

orc.Loot(fireSword);

// Kamp
Battle battle = new Battle();
battle.HitEnemy(elf, goblin);
battle.HitEnemy(orc, elf);
battle.HitEnemy(goblin, elf);

//Vægt grænse
orc.Loot(cHeavy);
elf.Loot(sword);



// Strategy pattern og operator overloade
elf.HitStrategy = dmg => elf.Health < 50 ? dmg - 10 : dmg;

int stategyDamage = elf.Hit();
goblin.ReciveDamage(new Damage(stategyDamage));

// Defense item ved kamp
goblin.Loot(shield);
battle.HitEnemy(elf, goblin);

goblin.Loot(helmet);
battle.HitEnemy(elf, goblin);

///Read config file
ConfigReader reader = new ConfigReader();
reader.ReadConfigfile("xxx.AdvancesSC\\GAmeFRameWorkDeoNuget\\GAmeFRameWorkDeoNuget\\config.xml");