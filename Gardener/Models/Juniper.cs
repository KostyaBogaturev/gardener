namespace Gardener.Models
{
    using System;
    using Gardener.Abstractions;
    using Gardener.Enums;

    /// <summary>
    /// Class of conifer juniper.
    /// </summary>
    public class Juniper : Gymnosperm
    {
        private const string Info = "Juniper is a coniferous plant with a high decorative effect.";
        private const double JuniperAverageSize = 4.2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Juniper"/> class.
        /// </summary>
        public Juniper()
            : base(JuniperAverageSize, Prevalence.MediumRarity, Conifers.Junipers)
        {
        }

        /// <summary>
        /// Override method GetInfo , add new information about juniper.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
