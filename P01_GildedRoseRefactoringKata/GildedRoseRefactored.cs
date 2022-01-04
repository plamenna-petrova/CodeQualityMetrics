using System;
using System.Collections.Generic;
using System.Text;

namespace P01_GildedRoseRefactoringKata
{
    public class GildedRoseRefactored
    {
        private readonly IList<Item> items;

        public GildedRoseRefactored(IList<Item> items)
        {
            this.items = items;
        }

        private void DecrementQualityForNormalItems(int itemIndex) 
        {
            if (items[itemIndex].Quality > 0 && items[itemIndex].Name != GildedRoseConstants.Sulfuras)
            {
                items[itemIndex].Quality = items[itemIndex].Quality - 1;
            }
        }

        private void IncrementQuality(int itemIndex) 
        {
            if (items[itemIndex].Quality < 50)
            {
                items[itemIndex].Quality = items[itemIndex].Quality + 1;
            }
        }

        private void UpdateQualityForItemsThatAgeWell(int itemIndex) 
        {
            IncrementQuality(itemIndex);

            if (items[itemIndex].Name == GildedRoseConstants.Concert)
            {
                if (items[itemIndex].SellIn < 11)
                {
                    IncrementQuality(itemIndex);
                }

                if (items[itemIndex].SellIn < 6)
                {
                    IncrementQuality(itemIndex);
                }
            }
        }

        private void UpdateQualityForExpiredItems(int itemIndex) 
        {
            if (items[itemIndex].Name != GildedRoseConstants.AgedBrie)
            {
                if (items[itemIndex].Name != GildedRoseConstants.Concert)
                {
                    DecrementQualityForNormalItems(itemIndex);
                }
                else
                {
                    items[itemIndex].Quality = 0;
                }
            }
            else
            {
                IncrementQuality(itemIndex);
            }
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].Name != GildedRoseConstants.AgedBrie && items[i].Name != GildedRoseConstants.Concert)
                {
                    DecrementQualityForNormalItems(i);
                }
                else
                {
                    UpdateQualityForItemsThatAgeWell(i);
                }

                if (items[i].Name != GildedRoseConstants.Sulfuras)
                {
                    items[i].SellIn = items[i].SellIn - 1;
                }

                if (items[i].SellIn < 0)
                {
                    UpdateQualityForExpiredItems(i);
                }
            }
        }
    }
}
