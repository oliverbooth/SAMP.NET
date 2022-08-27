using System;

namespace SAMP.API.EventData {
	public class PlayerTextEventArgs : EventArgs {
		#region Class Variables
		
		private string
			m_strMessage;
		private bool
			m_bCancel;
		internal bool
			m_bSet       = false;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerTextEventArgs"/> class.
		/// </summary>
		/// <param name="message">The chat message associated with this PlayerTextEventArgs.</param>
		public PlayerTextEventArgs(string message) {
			this.m_strMessage = message;
			this.m_bCancel = false;
		}

		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the chat message.
		/// </summary>
		public string Message {
			get {
				return this.m_strMessage;
			}
		}
		
		/// <summary>
		/// Gets or sets whether the event should cancel (chat message displayed).
		/// </summary>
		public bool Cancel {
			get {
				return this.m_bCancel;
			} set {
				this.m_bCancel = value;
				this.m_bSet = true;
			}
		}
		
		#endregion
	};
};
