using System;

namespace SAMP.API.EventData
{
    public class DialogResponseEventArgs : EventArgs
    {
        #region Class Variables

        private int
            _nDialogID,
            _nResponse,
            _nListItem;
        private string _strInputText;
        private bool _bPassOn;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new OnPlayerDisconnectEventArgs object.
        /// </summary>
        /// <param name="dialogid">The ID of the dialog the player responded to, assigned in Player.ShowDialog.</param>
        /// <param name="response">1 for first button and 0 for second button.</param>
        /// <param name="listitem">The ID of the list item selected by the player.</param>
        /// <param name="inputtext">The text entered into the input box by the player or the selected list item text.</param>
        public DialogResponseEventArgs(int dialogid, int response, int listitem, string inputtext)
        {
            _nDialogID = dialogid;
            _nResponse = response;
            _nListItem = listitem;
            _strInputText = inputtext;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// gets the ID of the dialog the player responded to, assigned in Player.ShowDialog.
        /// </summary>
        public int DialogID
        {
            get { return _nDialogID; }
        }

        /// <summary>
        /// Gets the response from the dialog. 1 for first button and 0 for second button.
        /// </summary>
        public int Response
        {
            get { return _nResponse; }
        }

        /// <summary>
        /// Gets the ID of the list item selected by the player.
        /// </summary>
        public int ListItem
        {
            get { return _nListItem; }
        }

        /// <summary>
        /// Gets the text entered into the input box by the player or the selected list item text.
        /// </summary>
        public string InputText
        {
            get { return _strInputText; }
        }

        /// <summary>
        /// Gets or sets whether or not this callback should be passed on to filterscripts.
        /// </summary>
        public bool ContinueToFilterscripts
        {
            get { return _bPassOn; }
            set { _bPassOn = value; }
        }

        #endregion
    };
};