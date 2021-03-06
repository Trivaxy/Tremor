using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GelCube : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 60;
			item.rare = 1;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Cube");
			Tooltip.SetDefault("Alchemically important ingredient");
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 5);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}

	}
}
