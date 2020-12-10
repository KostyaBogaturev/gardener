namespace Gardener.Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Gardener.Enums;

    /// <summary>
    /// Interface of live organism.
    /// </summary>
    public interface IOrganism
    {
        /// <summary>
        /// Gets average size of organism.
        /// </summary>
        public double AverageSize { get; }

        /// <summary>
        /// Gets kingdom of organism.
        /// </summary>
        public Kingdoms Kingdom { get; }

        /// <summary>
        /// Gets prevalence of organism.
        /// </summary>
        public Prevalence Rarity { get; }
    }
}
