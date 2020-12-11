namespace Gardener.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Gardener.Abstractions;
    using Gardener.Models;

    /// <summary>
    /// In this class we will work.
    /// </summary>
    public static class Starter
    {
        /// <summary>
        /// In this method we will work.
        /// </summary>
        public static void Run()
        {
            Garden garden = new Garden();
            Juniper juniper = new Juniper();
            Plant plant = juniper;
            garden.Add(plant);
            Polushnik polushnik = new Polushnik();
            plant = polushnik;
            garden.Add(plant);
            UlotrixModel ulotrix = new UlotrixModel();
            plant = ulotrix;
            garden.Add(plant);
            garden.TryFind(Enums.Prevalence.OftenMeets, 0.1);
            ulotrix.GetInfo();
        }
    }
}
