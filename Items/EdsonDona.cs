using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Default;

namespace EdsonDona.Items
{
    public class EdsonDona : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 5;


            Main.RegisterItemAnimation(Type, new DrawAnimationVertical(int.MaxValue, 3));
            ItemID.Sets.FoodParticleColors[Item.type] = new Color[3] {
                new Color(249, 230, 136),
                new Color(152, 93, 95),
                new Color(174, 192, 192)
            };

            ItemID.Sets.IsFood[Type] = true; 
        }
        public override void SetDefaults() 
        {
            Item.DefaultToFood(22, 22, BuffID.WellFed3, 57600);
            Item.value = Item.buyPrice(0, 3);
            Item.rare = ItemRarityID.Blue;

        }


        public override void OnConsumeItem(Player player)
        {
            player.AddBuff(BuffID.SugarRush, 3600);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

            
        }
    }
}

        

        
