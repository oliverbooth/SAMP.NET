using System;

namespace SAMP.API.EventData
{
    public class RconCommandEventArgs : EventArgs
    {
        #region Class Variables

        private string _strCommand;
        private bool _bHandled;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new RconCommandEventArgs object.
        /// </summary>
        /// <param name="command">The command entered.</param>
        public RconCommandEventArgs(string command)
        {
            _strCommand = command;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the chat message associated with this event.
        /// </summary>
        public string Command
        {
            get { return _strCommand; }
        }

        /// <summary>
        /// Gets or sets whether the event was handled. Returning TRUE will prevent the command being passed to other scripts.
        /// </summary>
        public bool Handled
        {
            get { return _bHandled; }
            set { _bHandled = value; }
        }

        #endregion
    };
};