namespace Gardener.Abstractions
{
    using System;
    using Gardener.Enums;

    /// <summary>
    /// Abstract class wich discript low devision plants.
    /// </summary>
    public abstract class LowPlant : Plant
    {
        private const string Info = "Higher plants belong to the department Streptophyta and its subgroup Streptophytina. All of them are multicellular nuclear organisms with specialized reproductive organs.";

        /// <summary>
        /// Initializes a new instance of the <see cref="LowPlant"/> class.
        /// </summary>
        /// <param name="averageSize">initialize average size.</param>
        /// <param name="rarity">initialize prevalence.</param>
        public LowPlant(double averageSize, Prevalence rarity)
            : base(averageSize, rarity, PlantDevision.HigherPlants)
        {
        }

        /// <summary>
        /// Override method GetInfo , add new information about high devision plants.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
