using System;

namespace SAMP.API.EventData {
	public class PlayerCommandTextEventArgs : EventArgs {
		#region Class Variables
		
		private string
			m_strMessage;
		private bool
			m_bHandled;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerCommandTextEventArgs"/> class.
		/// </summary>
		/// <param name="message">The chat message.</param>
		public PlayerCommandTextEventArgs(string message) {
			this.m_strMessage = message;
			this.m_bHandled = false;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the chat message associated with this event.
		/// </summary>
		public string Message {
			get {
				return this.m_strMessage; }
		}
		
		/// <summary>
		/// Gets or sets whether the event was handled. Returning TRUE will prevent the 'SERVER: Unknown Command' message being shown.
		/// </summary>
		public bool Handled
		{
			get {
				return this.m_bHandled;
			} set {
				this.m_bHandled = value;
			}
		}
		
		#endregion
	};
};
