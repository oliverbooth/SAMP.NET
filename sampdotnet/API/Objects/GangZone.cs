using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAMP.API
{
    public class GangZone
    {
        #region Class Variables

        private int _nId;
        private Vector2 _qMin, _qMax;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a GangZone (colored radar area).
        /// </summary>
        /// <param name="min">The south-west side of the gangzone. (X = west, Y = south).</param>
        /// <param name="max">The north-east side of the gangzone. (X = east, Y = north).</param>
        public GangZone(Vector2 min, Vector2 max)
        {
            _qMin = min;
            _qMax = max;
            _nId = Core.Natives.GangZoneCreate(min.X, min.Y, max.X, max.Y);
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the ID of this GangZone.
        /// </summary>
        internal int ID
        {
            get { return _nId; }
        }

        /// <summary>
        /// Gets the maximum position.
        /// </summary>
        public Vector2 Maximum
        {
            get { return _qMax; }
        }

        /// <summary>
        /// Gets the minimum position.
        /// </summary>
        public Vector2 Minimum
        {
            get { return _qMin; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Makes the GangZone flash for all players.
        /// </summary>
        /// <param name="color">The color the zone will flash.</param>
        public void FlashForAll(Color color)
        {
            Core.Natives.GangZoneFlashForAll(this.ID, color.ToArgb());
        }

        /// <summary>
        /// Makes the GangZone flash for a player.
        /// </summary>
        /// <param name="player">The player you would like to hide the GangZone for.</param>
        /// <param name="color">The color the zone will flash.</param>
        public void FlashForPlayer(Player player, Color color)
        {
            Core.Natives.GangZoneFlashForPlayer(player.ID, this.ID, color.ToArgb());
        }

        /// <summary>
        /// Hides the GangZone for all players.
        /// </summary>
        /// <param name="color">The color for the GangZone to be.</param>
        public void HideForAll(Color color)
        {
            Core.Natives.GangZoneHideForAll(this.ID);
        }

        /// <summary>
        /// Hides the GangZone for a player.
        /// </summary>
        /// <param name="player">The player you would like to hide the GangZone for.</param>
        /// <param name="color">The color for the GangZone to be.</param>
        public void HideForPlayer(Player player, Color color)
        {
            Core.Natives.GangZoneHideForPlayer(player.ID, this.ID);
        }

        /// <summary>
        /// Shows the GangZone for all players.
        /// </summary>
        /// <param name="color">The color for the GangZone to be.</param>
        /// <returns>Returns a System.Boolean representing whether or not the GangZone was shown.</returns>
        public bool ShowForAll(Color color)
        {
            return Core.Natives.GangZoneShowForAll(this.ID, color.ToArgb()) == 1;
        }

        /// <summary>
        /// Shows the GangZone for a player.
        /// </summary>
        /// <param name="player">The player you would like to show the GangZone for.</param>
        /// <param name="color">The color for the GangZone to be.</param>
        public void ShowForPlayer(Player player, Color color)
        {
            Core.Natives.GangZoneShowForPlayer(player.ID, this.ID, color.ToArgb());
        }

        /// <summary>
        /// Stops the GangZone flashing for all players.
        /// </summary>
        public void StopFlashForAll()
        {
            Core.Natives.GangZoneStopFlashForAll(this.ID);
        }

        /// <summary>
        /// Stops the GangZone flashing for a player.
        /// </summary>
        /// <param name="player">The player you would like to hide the GangZone for.</param>
        public void StopFlashForPlayer(Player player)
        {
            Core.Natives.GangZoneStopFlashForPlayer(player.ID, this.ID);
        }

        #endregion
    };
};