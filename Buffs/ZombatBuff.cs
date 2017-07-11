using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class ZombatBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Zombat");
			Description.SetDefault("The zombat will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			TremorPlayer modPlayer = (TremorPlayer)player.GetModPlayer(mod, "TremorPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("ZombatStaffPro")] > 0)
			{
				modPlayer.zombatMinion = true;
			}
			if (!modPlayer.zombatMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}