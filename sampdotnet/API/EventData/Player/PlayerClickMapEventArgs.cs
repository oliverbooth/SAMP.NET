using System;

namespace SAMP.API.EventData {
	public class PlayerClickMapEventArgs : EventArgs {
		#region Class Variables
		
		private Vector3
			m_qPosition;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerClickMapEventArgs"/> class.
		/// </summary>
		/// <param name="position">The coordinates of where the player clicked.</param>
		public PlayerClickMapEventArgs(Vector3 position) {
			this.m_qPosition = position;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// The coordinates of where the player clicked
		/// </summary>
		public Vector3 Position {
			get {
				return this.m_qPosition;
			}
		}
		
		#endregion
	};
};
