using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class RedFeatherWings : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 20;

			item.value = 100000;
			item.rare = 5;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Feather Wings");
			Tooltip.SetDefault("The wings made of red feathers.");
		}


		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 140;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 6f;
			acceleration *= 2.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RedFeather", 1);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
