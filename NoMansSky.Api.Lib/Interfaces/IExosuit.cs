﻿namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's exosuit.
    /// </summary>
    public interface IExosuit
    {
        /// <summary>
        /// Returns the Exosuit's general inventory.
        /// </summary>
        /// <returns></returns>
        public Inventory GetInventory();

        /// <summary>
        /// Returns the Exosuit's technology inventory.
        /// </summary>
        /// <returns></returns>
        public Inventory GetTechnology();

        /// <summary>
        /// Returns the Exosuit's cargo inventory.
        /// </summary>
        /// <returns></returns>
        public Inventory GetCargo();
    }
}
