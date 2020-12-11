namespace Gardener.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Gardener.Enums;

    /// <summary>
    /// Abstract class wich discript Gymnosperm.
    /// </summary>
    public abstract class Gymnosperm : HighPlant
    {
        private const string Info = "Gymnosperms are a very ancient group of higher seed plants.";

        /// <summary>
        /// Initializes a new instance of the <see cref="Gymnosperm"/> class.
        /// </summary>
        /// <param name="averageSize">initialize avarege size.</param>
        /// <param name="rarity">init rarity.</param>
        /// <param name="member">init member.</param>
        public Gymnosperm(double averageSize, Prevalence rarity)
            : base(averageSize, rarity, HighPlantsClasses.Gymnosperms)
        {
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
