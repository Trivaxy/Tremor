using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class TempleCannon : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 72;
			item.ranged = true;
			item.width = 20;
			item.height = 12;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 12, 5, 0);
			item.rare = 9;
			item.useStyle = 5;
			item.UseSound = SoundID.Item36;
			item.noMelee = true;
			item.autoReuse = false;
			item.shoot = 1;
			item.shootSpeed = 23f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Temple Cannon");
			Tooltip.SetDefault("");
		}


		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for (int i = 0; i < 1; ++i) // Will shoot 3 bullets.
			{
				Projectile.NewProjectile(position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
				Projectile.NewProjectile(position.X, position.Y, speedX - 1, speedY - 1, type, damage, knockBack, Main.myPlayer);
			}
			return false;
		}

		public override bool ConsumeAmmo(Player p)
		{
			return Main.rand.Next(2) == 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GolemCore", 1);
			recipe.AddIngredient(null, "Bolter", 1);
			recipe.AddIngredient(ItemID.ChlorophyteShotbow, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 25);
			recipe.AddIngredient(ItemID.SoulofNight, 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
