using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bulletsAndMore
{
	public class bulletsAndMore : Mod
	{
		public override void AddRecipes()
		{
			Recipe recipe = Recipe.Create(ItemID.MusketBall, 100);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}