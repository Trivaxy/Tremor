using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CrateFish : ModItem
	{
		public override void SetDefaults()
		{

			item.questItem = true;
			item.maxStack = 1;
			item.width = 26;
			item.height = 26;
			item.uniqueStack = true;
			item.rare = -11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crate Fish");
			Tooltip.SetDefault("");
		}


		public override bool IsQuestFish()
		{
			return true;
		}

		public override bool IsAnglerQuestAvailable()
		{
			return NPC.downedBoss2;
		}

		public override void AnglerQuestChat(ref string description, ref string catchLocation)
		{
			description = "Hahaha! Another mistake of evolution! Who knows how much goodies could I find in this fish if you will bring it to me!";
			catchLocation = "Anywhere";
		}
	}
}
