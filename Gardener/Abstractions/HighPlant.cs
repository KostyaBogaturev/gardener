namespace Gardener.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Gardener.Enums;

    /// <summary>
    /// Abstract class wich discript high devision plants.
    /// </summary>
    public abstract class HighPlant : Plant
    {
        private const string Info = "Higher plants belong to the department Streptophyta and its subgroup Streptophytina. All of them are multicellular nuclear organisms with specialized reproductive organs.";
        private readonly HighPlantsClasses hpclass;

        /// <summary>
        /// Initializes a new instance of the <see cref="HighPlant"/> class.
        /// </summary>
        /// <param name="averageSize">initialize average size.</param>
        /// <param name="rarity">initialize prevalence.</param>
        /// <param name="hpclass">initialize class.</param>
        public HighPlant(double averageSize, Prevalence rarity, HighPlantsClasses hpclass)
            : base(averageSize, rarity, PlantDevision.HigherPlants)
        {
            this.hpclass = hpclass;
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
