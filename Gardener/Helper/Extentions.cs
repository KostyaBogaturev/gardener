namespace Gardener.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Gardener.Abstractions;
    using Gardener.Enums;

    /// <summary>
    /// Extention for array of plants.
    /// </summary>
    public static class Extentions
    {
        /// <summary>
        /// Extention for find item in plant arr.
        /// </summary>
        /// <param name="array">array name.</param>
        /// <param name="rarity">rarity of plant.</param>
        /// <returns>Finded plant or null.</returns>
        public static Plant Find(this Plant[] array, Prevalence rarity)
        {
            Plant toReturn = null;

            foreach (Plant item in array)
            {
                if (item.Rarity == rarity)
                {
                    toReturn = item;
                    break;
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Extention for find item in plant arr.
        /// </summary>
        /// <param name="array">array name.</param>
        /// <param name="rarity">rarity of item.</param>
        /// <param name="averageSize">average size of plant.</param>
        /// <returns>Finded plant or null.</returns>
        public static Plant Find(this Plant[] array, Prevalence rarity, double averageSize)
        {
            Plant toReturn = null;

            foreach (Plant item in array)
            {
                if (item.Rarity == rarity && item.AverageSize == averageSize)
                {
                    toReturn = item;
                    break;
                }
            }

            return toReturn;
        }
    }
}
