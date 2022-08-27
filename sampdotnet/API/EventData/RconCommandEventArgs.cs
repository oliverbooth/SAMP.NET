using System;

namespace SAMP.API.EventData {
	public class RconCommandEventArgs : EventArgs {
		#region Class Variables
		
		private string
			m_strCommand;
		private bool
			m_bHandled;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.RconCommandEventArgs"/> class.
		/// </summary>
		/// <param name="command">The command entered.</param>
		public RconCommandEventArgs(string command) {
			this.m_strCommand = command;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the chat message associated with this event.
		/// </summary>
		public string Command {
			get {
				return this.m_strCommand;
			}
		}
		
		/// <summary>
		/// Gets or sets whether the event was handled. Returning TRUE will prevent the command being passed to other scripts.
		/// </summary>
		public bool Handled {
			get {
				return this.m_bHandled;
			} set {
				this.m_bHandled = value;
			}
		}
		
		#endregion
	};
};
