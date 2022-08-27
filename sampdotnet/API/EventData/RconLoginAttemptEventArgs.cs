using System;

namespace SAMP.API.EventData
{
    public class RconLoginAttemptEventArgs : EventArgs
    {
        #region Class Variables

        private string 
            _strIp, // strip. lol.
            _strPassword;
        private bool _bSuccess;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new RconLoginAttemptEventArgs object.
        /// </summary>
        /// <param name="ip">The IP of the player that tried to login to RCON.</param>
        /// <param name="password">The password used to login with.</param>
        /// <param name="success">False if the password was incorrect or True if it was correct.</param>
        public RconLoginAttemptEventArgs(string ip, string password, bool success)
        {
            _strIp = ip;
            _strPassword = password;
            _bSuccess = success;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the IP of the player that tried to login to RCON.
        /// </summary>
        public string IP
        {
            get { return _strIp; }
        }

        /// <summary>
        /// Gets the password used to login with.
        /// </summary>
        public string Password
        {
            get { return _strPassword; }
        }

        /// <summary>
        /// Gets whether or not the password was correct.
        /// </summary>
        public bool Success
        {
            get { return _bSuccess; }
        }

        #endregion
    };
};