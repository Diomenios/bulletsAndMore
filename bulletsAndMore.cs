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

			recipe = Recipe.Create(ItemID.LesserManaPotion, 1)
				.AddIngredient(ItemID.GlowingMushroom, 2)
				.AddIngredient(ItemID.BottledWater, 1)
				.AddTile(TileID.Bottles)
				.Register()
			;

						recipe = Recipe.Create(ItemID.LesserManaPotion, 1)
				.AddIngredient(ItemID.GlowingMushroom, 2)
				.AddIngredient(ItemID.BottledWater, 1)
				.AddTile(TileID.AlchemyTable)
				.Register()
			;
		}
	}
}