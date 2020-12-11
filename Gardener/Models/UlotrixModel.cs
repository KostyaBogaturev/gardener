namespace Gardener.Models
{
    using System;
    using Gardener.Abstractions;
    using Gardener.Enums;

    /// <summary>
    /// Class Of alga ulotrix.
    /// </summary>
    public class UlotrixModel : MulticelluralAlgaes
    {
        private const double UlotrixAverageSize = 0.1;
        private const string Info = "Representatives live in sea and fresh waters, forming green mud on underwater objects.";

        /// <summary>
        /// Initializes a new instance of the <see cref="UlotrixModel"/> class.
        /// </summary>
        public UlotrixModel()
            : base(UlotrixAverageSize, Prevalence.OftenMeets, Algaes.Ulotrix)
        {
        }

        /// <summary>
        /// Gets name of this class.
        /// </summary>
        public override string Name => "Ulotrix";

        /// <summary>
        /// Override method GetInfo , add new information about ulotrix.
        /// </summary>
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Info);
        }
    }
}
