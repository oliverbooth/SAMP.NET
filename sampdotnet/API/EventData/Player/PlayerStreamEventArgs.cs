using System;

namespace SAMP.API.EventData
{
    public class PlayerStreamEventArgs : EventArgs
    {
        #region Class Variables

        private Player _qPlayer;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new PlayerStreamEventArgs object.
        /// </summary>
        /// <param name="forplayer">The player who the player streamed in or out for.</param>
        public PlayerStreamEventArgs(Player forplayer)
        {
            _qPlayer = forplayer;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the player who the player streamed in or out for.
        /// </summary>
        public Player ForPlayer
        {
            get { return _qPlayer; }
        }

        #endregion
    };
};