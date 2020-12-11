namespace Gardener.Abstractions
{
    using System;
    using Gardener.Enums;

    /// <summary>
    /// Abstract class wich discript Fern.
    /// </summary>
    public abstract class Fern : HighPlant
    {
        private const string Info = "Ferns- the department of vascular plants, which includes both modern ferns and some of the oldest higher plants.";
        private readonly Lyciformes member;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fern"/> class.
        /// </summary>
        /// <param name="averageSize">initialize avarege size.</param>
        /// <param name="rarity">init rarity.</param>
        /// <param name="member">init member.</param>
        public Fern(double averageSize, Prevalence rarity, Lyciformes member)
            : base(averageSize, rarity, HighPlantsClasses.Ferns)
        {
            this.member = member;
        }

        /// <summary>
        /// Override method GetInfo , add new information about Fern.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
