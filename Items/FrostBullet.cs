using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace bulletsAndMore.Items
{
	public class FrostBullet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A bullet made from a block of ice. Can inflict frostburn debbuf."); // The item's description, can be set to whatever you want.

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults() {
			Item.damage = 8; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 9999;
			Item.consumable = true; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = ItemRarityID.White;
			Item.shoot = ModContent.ProjectileType<FrostShot>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 0.01f; // The speed of the projectile.
			Item.ammo = AmmoID.Bullet; // The ammo class this ammo belongs to.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe(100)
				.AddIngredient(ItemID.IceBlock)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}