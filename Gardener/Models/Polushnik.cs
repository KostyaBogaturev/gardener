namespace Gardener.Models
{
    using System;
    using Gardener.Abstractions;
    using Gardener.Enums;

    /// <summary>
    /// Class of Lyciformes Polushnik.
    /// </summary>
    public class Polushnik : Fern
    {
        private const string Info = "Water rooted rosette herbaceous perennial.It grows in thickets or in groups on sandy or sandy-silty soil along the bottom of oligotrophic lakes at a depth of 4 meters or more.";
        private const double PolushnikAverageSize = 0.2;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polushnik"/> class.
        /// </summary>
        public Polushnik()
            : base(PolushnikAverageSize, Prevalence.Rare, Lyciformes.Polushniks)
        {
        }

        /// <summary>
        /// Gets name of this class.
        /// </summary>
        public override string Name => "Polushnik";

        /// <summary>
        /// Override method GetInfo , add new information about Polushnik.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
