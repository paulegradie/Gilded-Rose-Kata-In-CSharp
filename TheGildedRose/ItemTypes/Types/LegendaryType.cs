﻿using TheGildedRose.ItemTypes.Interfaces;
using TheGildedRose.Repositories.SQLite;

namespace TheGildedRose.ItemTypes.Types
{
    public class LegendaryType : BaseItemType, ICreatable<LegendaryType>, IUpdateableItem
    {
        private LegendaryType(string name, int quality, int sellIn) : base("Legendary", name, quality, sellIn)
        {
        }

        public static LegendaryType CreateType(DataRow data)
        {
            return new LegendaryType(data.Name, data.Quality, data.SellIn);
        }

        public void Update()
        {
            // does nothing
        }
    }
}