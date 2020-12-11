namespace Gardener.Models
{
    using System;
    using Gardener.Abstractions;
    using Gardener.Enums;
    using Gardener.Helper;

    /// <summary>
    /// In class garden we will keep our plants.
    /// </summary>
    public class Garden
    {
        private Plant[] garden;

        /// <summary>
        /// Initializes a new instance of the <see cref="Garden"/> class.
        /// </summary>
        public Garden()
        {
            this.garden = new Plant[1];
        }

        /// <summary>
        /// Add new item to array garden.
        /// </summary>
        /// <param name="plant">new item.</param>
        public void Add(Plant plant)
        {
            int lenth = this.garden.Length;
            this.garden[lenth - 1] = plant;
            Array.Resize(ref this.garden, lenth + 1);
        }

        /// <summary>
        /// Try find item in garden.
        /// </summary>
        /// <param name="rarity">rarity of plant.</param>
        public void TryFind(Prevalence rarity)
        {
            Plant plant = this.garden.Find(rarity);
            if (plant == null)
            {
                Console.WriteLine("Element not found");
            }
        }

        /// <summary>
        /// Try find item in garden.
        /// </summary>
        /// <param name="rarity">rarity of plant.</param>
        /// <param name="averageSize">average size of plant.</param>
        public void TryFind(Prevalence rarity, double averageSize)
        {
            Plant plant = this.garden.Find(rarity, averageSize);
            if (plant == null)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
