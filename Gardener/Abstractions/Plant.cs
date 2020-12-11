namespace Gardener.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Gardener.Enums;

    /// <summary>
    /// Abstruct class plant.
    /// </summary>
    public abstract class Plant : IOrganism
    {
        private readonly double averageSize;
        private readonly Prevalence rarity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plant"/> class.
        /// </summary>
        /// <param name="averageSize">initialize avarege size.</param>
        /// <param name="rarity">initialize prevalence.</param>
        public Plant(double averageSize, Prevalence rarity)
        {
            this.averageSize = averageSize;
            this.rarity = rarity;
        }

        /// <summary>
        /// Gets implement interface property AverageSize.
        /// </summary>
        public double AverageSize => this.averageSize;

        /// <summary>
        /// Gets implement interface property Kingdom
        /// For this class Kingdom = Plants.
        /// </summary>
        public Kingdoms Kingdom => Kingdoms.Plants;

        /// <summary>
        /// Gets implement interface property Rarity.
        /// </summary>
        public Prevalence Rarity => this.rarity;

        /// <summary>
        /// Gets implement interface property WayGettingEnergy
        /// For this class WayGettingEnergy = Photosynthesis.
        /// </summary>
        public GettingEnergy WayGettingEnergy => GettingEnergy.Photosynthesis;
    }
}
