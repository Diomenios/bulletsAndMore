using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bulletsAndMore
{
	public class bulletsAndMore : Mod
	{
		public override void AddRecipes()
		{
			Recipe.Create(ItemID.MusketBall, 100)
				.AddIngredient(ItemID.StoneBlock, 1)
				.AddTile(TileID.WorkBenches)
				.Register()
			;

			Recipe.Create(ItemID.LesserManaPotion, 1)
				.AddIngredient(ItemID.GlowingMushroom, 2)
				.AddIngredient(ItemID.BottledWater, 1)
				.AddTile(TileID.Bottles)
				.Register()
			;

			Recipe.Create(ItemID.LesserManaPotion, 1)
				.AddIngredient(ItemID.GlowingMushroom, 2)
				.AddIngredient(ItemID.BottledWater, 1)
				.AddTile(TileID.AlchemyTable)
				.Register()
			;

			Recipe.Create(ItemID.Book, 1)
				.AddRecipeGroup("Wood", 20)
				.AddIngredient(ItemID.BottledWater, 2)
				.AddTile(TileID.WorkBenches)
				.Register()
			;
		}
	}
}