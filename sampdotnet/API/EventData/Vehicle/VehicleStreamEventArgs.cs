using System;

namespace SAMP.API.EventData
{
    public class VehicleStreamEventArgs : EventArgs
    {
        #region Class Variables

        private Player _qPlayer;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new VehicleStreamEventArgs object.
        /// </summary>
        /// <param name="forplayer">The player who the vehicle streamed in or out for.</param>
        public VehicleStreamEventArgs(Player forplayer)
        {
            _qPlayer = forplayer;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the player who the vehicle streamed in or out for.
        /// </summary>
        public Player ForPlayer
        {
            get { return _qPlayer; }
        }

        #endregion
    };
};