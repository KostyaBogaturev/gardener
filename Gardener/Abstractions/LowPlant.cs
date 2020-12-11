namespace Gardener.Abstractions
{
    using System;
    using Gardener.Enums;

    /// <summary>
    /// Abstract class wich discript low devision plants.
    /// </summary>
    public abstract class LowPlant : Plant
    {
        private const string Info = "Organisms that do not have morphological division of the body into vegetative organs";
        private readonly LowerPlantsClasses lpclass;

        /// <summary>
        /// Initializes a new instance of the <see cref="LowPlant"/> class.
        /// </summary>
        /// <param name="averageSize">initialize average size.</param>
        /// <param name="rarity">initialize prevalence.</param>
        /// <param name="lpclass">initialize class.</param>
        public LowPlant(double averageSize, Prevalence rarity, LowerPlantsClasses lpclass)
            : base(averageSize, rarity, PlantDevision.LowerPlants)
        {
            this.lpclass = lpclass;
        }

        /// <summary>
        /// Override method GetInfo , add new information about low devision plants.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
