//Uncomment for OWLTR Resources
//#define OWLTR

using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Factions;

namespace Server.Items
{
	public class TestCenterChest : MetalChest
    {
        public override int Hue { get { return 1150; } }
        public override string DefaultName { get { return "A Test Center Chest"; } }

        private static void PlaceItemIn(Container parent, int x, int y, Item item)
        {
            parent.AddItem(item);
            item.Location = new Point3D(x, y, 0);
        }

        private static Item MakePotionKeg(PotionEffect type, int hue)
        {
            PotionKeg keg = new PotionKeg();

            keg.Held = 100;
            keg.Type = type;
            keg.Hue = hue;

            return MakeNewbie(keg);
        }

        private static Item MakeNewbie(Item item)
        {
            if (!Core.AOS)
                item.LootType = LootType.Newbied;

            return item;
        }

        [Constructable]
		public TestCenterChest()
        {
            Container cont;

            // Begin box of money
            cont = new WoodenBox();
            cont.ItemID = 0xE7D;
            cont.Hue = 0x489;
            cont.Name = "Box Of Money";

            PlaceItemIn(cont, 16, 51, new BankCheck(500000000));
            PlaceItemIn(cont, 28, 51, new BankCheck(25000000));
            PlaceItemIn(cont, 40, 51, new BankCheck(10000000));
            PlaceItemIn(cont, 52, 51, new BankCheck(1000000));
            PlaceItemIn(cont, 64, 51, new BankCheck(500000));

            PlaceItemIn(cont, 16, 115, new Silver(9000));
            PlaceItemIn(cont, 34, 115, new Gold(60000));

            PlaceItemIn(this, 18, 169, cont);
            // End box of money

            // Begin bag of potion kegs
            cont = new Backpack();
            cont.Name = "Various Potion Kegs";

            PlaceItemIn(cont, 45, 149, MakePotionKeg(PotionEffect.CureGreater, 0x2D));
            PlaceItemIn(cont, 69, 149, MakePotionKeg(PotionEffect.HealGreater, 0x499));
            PlaceItemIn(cont, 93, 149, MakePotionKeg(PotionEffect.PoisonDeadly, 0x46));
            PlaceItemIn(cont, 117, 149, MakePotionKeg(PotionEffect.RefreshTotal, 0x21));
            PlaceItemIn(cont, 141, 149, MakePotionKeg(PotionEffect.ExplosionGreater, 0x74));

            PlaceItemIn(cont, 93, 82, new Bottle(10000));

            PlaceItemIn(this, 53, 169, cont);
            // End bag of potion kegs

            // Begin bag of tools
            cont = new Bag();
            cont.Name = "Tool Bag";

            PlaceItemIn(cont, 30, 35, new TinkerTools(10000));
            PlaceItemIn(cont, 60, 35, new HousePlacementTool());
            PlaceItemIn(cont, 90, 35, new DovetailSaw(10000));
            PlaceItemIn(cont, 30, 80, new Scissors());
            PlaceItemIn(cont, 45, 80, new MortarPestle(10000));
            PlaceItemIn(cont, 75, 80, new ScribesPen(10000));
            PlaceItemIn(cont, 90, 80, new SmithHammer(10000));
            PlaceItemIn(cont, 30, 118, new TwoHandedAxe());
            PlaceItemIn(cont, 60, 118, new FletcherTools(10000));
            PlaceItemIn(cont, 90, 118, new SewingKit(10000));

            PlaceItemIn(cont, 36, 51, new RunicHammer(CraftResource.DullCopper, 10000));
            PlaceItemIn(cont, 42, 51, new RunicHammer(CraftResource.ShadowIron, 10000));
            PlaceItemIn(cont, 48, 51, new RunicHammer(CraftResource.Copper, 10000));
            PlaceItemIn(cont, 54, 51, new RunicHammer(CraftResource.Bronze, 10000));
            PlaceItemIn(cont, 61, 51, new RunicHammer(CraftResource.Gold, 10000));
            PlaceItemIn(cont, 67, 51, new RunicHammer(CraftResource.Agapite, 10000));
            PlaceItemIn(cont, 73, 51, new RunicHammer(CraftResource.Verite, 10000));
            PlaceItemIn(cont, 79, 51, new RunicHammer(CraftResource.Valorite, 10000));
#if (OWLTR)
            PlaceItemIn(cont, 85, 51, new RunicHammer(CraftResource.Blaze, 10000));
            PlaceItemIn(cont, 91, 51, new RunicHammer(CraftResource.Ice, 10000));
            PlaceItemIn(cont, 97, 51, new RunicHammer(CraftResource.Toxic, 10000));
            PlaceItemIn(cont, 103, 51, new RunicHammer(CraftResource.Electrum, 10000));
            PlaceItemIn(cont, 109, 51, new RunicHammer(CraftResource.Platinum, 10000));
#endif

            PlaceItemIn(cont, 36, 65, new RunicSewingKit(CraftResource.SpinedLeather, 10000));
            PlaceItemIn(cont, 42, 65, new RunicSewingKit(CraftResource.HornedLeather, 10000));
            PlaceItemIn(cont, 48, 65, new RunicSewingKit(CraftResource.BarbedLeather, 10000));
#if (OWLTR)
            PlaceItemIn(cont, 54, 65, new RunicSewingKit(CraftResource.PolarLeather, 10000));
            PlaceItemIn(cont, 60, 65, new RunicSewingKit(CraftResource.SyntheticLeather, 10000));
            PlaceItemIn(cont, 66, 65, new RunicSewingKit(CraftResource.BlazeLeather, 10000));
            PlaceItemIn(cont, 72, 65, new RunicSewingKit(CraftResource.DaemonicLeather, 10000));
            PlaceItemIn(cont, 78, 65, new RunicSewingKit(CraftResource.ShadowLeather, 10000));
            PlaceItemIn(cont, 84, 65, new RunicSewingKit(CraftResource.FrostLeather, 10000));
            PlaceItemIn(cont, 60, 65, new RunicSewingKit(CraftResource.EtherealLeather, 10000));
#endif

            PlaceItemIn(this, 118, 169, cont);
            // End bag of tools

            // Begin bag of archery ammo
            cont = new Bag();
            cont.Name = "Bag Of Archery Ammo";

            PlaceItemIn(cont, 48, 76, new Arrow(5000));
            PlaceItemIn(cont, 72, 76, new Bolt(5000));

            PlaceItemIn(this, 118, 124, cont);
            // End bag of archery ammo

            // Begin bag of treasure maps
            cont = new Bag();
            cont.Name = "Bag Of Treasure Maps";

            PlaceItemIn(cont, 30, 35, new TreasureMap(1, Map.Trammel));
            PlaceItemIn(cont, 45, 35, new TreasureMap(2, Map.Trammel));
            PlaceItemIn(cont, 60, 35, new TreasureMap(3, Map.Trammel));
            PlaceItemIn(cont, 75, 35, new TreasureMap(4, Map.Trammel));

            PlaceItemIn(cont, 30, 50, new TreasureMap(1, Map.Trammel));
            PlaceItemIn(cont, 45, 50, new TreasureMap(2, Map.Trammel));
            PlaceItemIn(cont, 60, 50, new TreasureMap(3, Map.Trammel));
            PlaceItemIn(cont, 75, 50, new TreasureMap(4, Map.Trammel));

            PlaceItemIn(cont, 55, 100, new Lockpick(3000));
            PlaceItemIn(cont, 60, 100, new Pickaxe());

            PlaceItemIn(this, 98, 124, cont);
            // End bag of treasure maps

            // Begin bag of raw materials
            cont = new Bag();
            cont.Hue = 0x835;
            cont.Name = "Raw Materials Bag";

            PlaceItemIn(cont, 92, 40, new BarbedLeather(50000));
            PlaceItemIn(cont, 92, 46, new HornedLeather(50000));
            PlaceItemIn(cont, 92, 52, new SpinedLeather(50000));
#if (OWLTR)
            PlaceItemIn(cont, 92, 58, new PolarLeather(50000));
            PlaceItemIn(cont, 92, 64, new SyntheticLeather(50000));
            PlaceItemIn(cont, 92, 70, new BlazeLeather(50000));
            PlaceItemIn(cont, 92, 76, new DaemonicLeather(50000));
            PlaceItemIn(cont, 92, 82, new ShadowLeather(50000));
            PlaceItemIn(cont, 92, 88, new FrostLeather(50000));
            PlaceItemIn(cont, 92, 94, new EtherealLeather(50000));
#endif
            PlaceItemIn(cont, 92, 100, new Leather(50000));

            PlaceItemIn(cont, 30, 118, new Cloth(50000));
            PlaceItemIn(cont, 30, 84, new Board(50000));
            PlaceItemIn(cont, 57, 80, new BlankScroll(50000));

            PlaceItemIn(cont, 30, 35, new DullCopperIngot(50000));
            PlaceItemIn(cont, 35, 35, new ShadowIronIngot(50000));
            PlaceItemIn(cont, 40, 35, new CopperIngot(50000));
            PlaceItemIn(cont, 45, 35, new BronzeIngot(50000));
            PlaceItemIn(cont, 50, 35, new GoldIngot(50000));
            PlaceItemIn(cont, 55, 35, new AgapiteIngot(50000));
            PlaceItemIn(cont, 60, 35, new VeriteIngot(50000));
            PlaceItemIn(cont, 65, 35, new ValoriteIngot(50000));
            PlaceItemIn(cont, 70, 35, new IronIngot(50000));
#if (OWLTR)
            PlaceItemIn(cont, 75, 35, new BlazeIngot(50000));
            PlaceItemIn(cont, 80, 35, new IceIngot(50000));
            PlaceItemIn(cont, 85, 35, new ToxicIngot(50000));
            PlaceItemIn(cont, 90, 35, new ElectrumIngot(50000));
            PlaceItemIn(cont, 95, 35, new PlatinumIngot(50000));
#endif

            PlaceItemIn(cont, 30, 59, new RedScales(50000));
            PlaceItemIn(cont, 36, 59, new YellowScales(50000));
            PlaceItemIn(cont, 42, 59, new BlackScales(50000));
            PlaceItemIn(cont, 48, 59, new GreenScales(50000));
            PlaceItemIn(cont, 54, 59, new WhiteScales(50000));
            PlaceItemIn(cont, 60, 59, new BlueScales(50000));
#if (OWLTR)
            PlaceItemIn(cont, 66, 59, new CopperScales(50000));
            PlaceItemIn(cont, 72, 59, new SilverScales(50000));
            PlaceItemIn(cont, 78, 59, new GoldScales(50000));
#endif
            PlaceItemIn(this, 98, 169, cont);
            // End bag of raw materials

            // Begin bag of spell casting stuff
            cont = new Backpack();
            cont.Hue = 0x480;
            cont.Name = "Spell Casting Stuff";

            PlaceItemIn(cont, 45, 105, new Spellbook(UInt64.MaxValue));
            PlaceItemIn(cont, 65, 105, new NecromancerSpellbook((UInt64)0xFFFF));
            PlaceItemIn(cont, 85, 105, new BookOfChivalry((UInt64)0x3FF));
            PlaceItemIn(cont, 105, 105, new BookOfBushido());	//Default ctor = full
            PlaceItemIn(cont, 125, 105, new BookOfNinjitsu()); //Default ctor = full

            Runebook runebook = new Runebook(10);
            runebook.CurCharges = runebook.MaxCharges;
            PlaceItemIn(cont, 145, 105, runebook);

            Item toHue = new BagOfAllReagents(5000);
            toHue.Hue = 0x2D;
            PlaceItemIn(cont, 45, 150, toHue);

            toHue = new BagOfNecroReagents(5000);
            toHue.Hue = 0x488;
            PlaceItemIn(cont, 65, 150, toHue);

            for (int i = 0; i < 9; ++i)
                PlaceItemIn(cont, 45 + (i * 10), 75, new RecallRune());

            PlaceItemIn(cont, 141, 74, new FireHorn());

            PlaceItemIn(this, 78, 169, cont);
            // End bag of spell casting stuff

            // Begin bag of ethereals
            cont = new Backpack();
            cont.Hue = 0x490;
            cont.Name = "Bag Of Ethy's!";

            PlaceItemIn(cont, 45, 66, new EtherealHorse());
            PlaceItemIn(cont, 69, 82, new EtherealOstard());
            PlaceItemIn(cont, 93, 99, new EtherealLlama());
            PlaceItemIn(cont, 117, 115, new EtherealKirin());
            PlaceItemIn(cont, 45, 132, new EtherealUnicorn());
            PlaceItemIn(cont, 69, 66, new EtherealRidgeback());
            PlaceItemIn(cont, 93, 82, new EtherealSwampDragon());
            PlaceItemIn(cont, 117, 99, new EtherealBeetle());

            PlaceItemIn(this, 38, 124, cont);
            // End bag of ethereals
        }

        public TestCenterChest(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0); // version 
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}
