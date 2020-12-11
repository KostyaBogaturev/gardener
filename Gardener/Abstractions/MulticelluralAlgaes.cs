namespace Gardener.Abstractions
{
    using System;
    using Gardener.Enums;

    /// <summary>
    /// Abstract class wich discript Multicellural Algaes.
    /// </summary>
    public abstract class MulticelluralAlgaes : LowPlant
    {
        private const string Info = "Multicellular green algae also live in the waters of the seas and oceans.";
        private readonly Algaes member;

        /// <summary>
        /// Initializes a new instance of the <see cref="MulticelluralAlgaes"/> class.
        /// </summary>
        /// <param name="averageSize">initialize avarege size.</param>
        /// <param name="rarity">init rarity.</param>
        /// <param name="member">init member.</param>
        public MulticelluralAlgaes(double averageSize, Prevalence rarity, Algaes member)
            : base(averageSize, rarity, LowerPlantsClasses.MulticellularAlgae)
        {
            this.member = member;
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
