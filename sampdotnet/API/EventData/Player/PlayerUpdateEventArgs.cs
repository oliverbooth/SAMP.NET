using System;

namespace SAMP.API.EventData
{
    public class PlayerUpdateEventArgs : EventArgs
    {
        #region Class Variables

        private bool _bCancel;

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets or sets whether the event should cancel.
        /// </summary>
        public bool Cancel
        {
            get { return _bCancel; }
            set { _bCancel = value; }
        }

        #endregion
    };
};