using System;

namespace SAMP.API.EventData {
	public class DialogResponseEventArgs : EventArgs {
		#region Class Variables
		
		private int
			m_iId,
			m_iResponse,
			m_iListItem;
		private string
			m_strInputText;
		private bool
			m_bPassOn;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.DialogResponseEventArgs"/> class.
		/// </summary>
		/// <param name="dialogid">The ID of the dialog the player responded to, assigned in Player.ShowDialog.</param>
		/// <param name="response">1 for first button and 0 for second button.</param>
		/// <param name="listitem">The ID of the list item selected by the player.</param>
		/// <param name="inputtext">The text entered into the input box by the player or the selected list item text.</param>
		public DialogResponseEventArgs(int dialogid, int response, int listitem, string inputtext) {
			this.m_iId = dialogid;
			this.m_iResponse = response;
			this.m_iListItem = listitem;
			this.m_strInputText = inputtext;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the ID of the dialog the player responded to, assigned in <see cref="SAMP.API.Player.ShowDialog"/>.
		/// </summary>
		public int DialogID {
			get {
				return this.m_iId;
			}
		}
		
		/// <summary>
		/// Gets the response from the dialog.
		/// </summary>
		public int Response {
			get {
				return this.m_iResponse;
			}
		}
		
		/// <summary>
		/// Gets the ID of the list item selected by the player.
		/// </summary>
		public int ListItem {
			get {
				return this.m_iListItem;
			}
		}
		
		/// <summary>
		/// Gets the text entered into the input box by the player or the selected list item text.
		/// </summary>
		public string InputText {
			get {
				return this.m_strInputText;
			}
		}
		
		/// <summary>
		/// Gets or sets whether or not this callback should be passed on to filterscripts.
		/// </summary>
		public bool ContinueToFilterscripts {
			get {
				return this.m_bPassOn;
			} set {
				this.m_bPassOn = value;
			}
		}
		
		#endregion
	};
};
