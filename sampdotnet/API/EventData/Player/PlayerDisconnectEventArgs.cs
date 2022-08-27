using System;

namespace SAMP.API.EventData {
	public class PlayerDisconnectEventArgs : EventArgs {
		#region Class Variables
		
		private DisconnectReason
			m_qReason;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerDisconnectEventArgs"/> class.
		/// </summary>
		/// <param name="reason">The reason for the disconnect.</param>
		public PlayerDisconnectEventArgs(DisconnectReason reason) {
			this.m_qReason = reason;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// The reason they left.
		/// </summary>
		public DisconnectReason Reason {
			get {
				return this.m_qReason;
			}
		}
		
		#endregion
	};
};
