using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class CopperSpearPro : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(66);

			aiType = 66;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("CopperSpearPro");

		}


	}
}
