namespace Gardener.Models
{
    using System;
    using Gardener.Abstractions;
    using Gardener.Enums;

    /// <summary>
    /// Class of Lyciformes Polushnik.
    /// </summary>
    public class Selaginella : Fern
    {
        private const string Info = "A short plant in appearance resembles a fern.Leaves are bright green.";
        private const double SelaginellaAverageSize = 0.3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Selaginella"/> class.
        /// </summary>
        public Selaginella()
            : base(SelaginellaAverageSize, Prevalence.Rare, Lyciformes.Polushniks)
        {
        }

        /// <summary>
        /// Gets name of this class.
        /// </summary>
        public override string Name => "Selaginella";

        /// <summary>
        /// Override method GetInfo , add new information about Selaginella.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
