using System;

namespace SAMP.API.EventData {
	public class VehicleStreamEventArgs : EventArgs {
		#region Class Variables
		
		private Player
			m_qPlayer;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.VehicleStreamEventArgs"/> class.
		/// </summary>
		/// <param name="forplayer">The player who the vehicle streamed in or out for.</param>
		public VehicleStreamEventArgs(Player forplayer) {
			this.m_qPlayer = forplayer;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the player who the vehicle streamed in or out for.
		/// </summary>
		public Player ForPlayer {
			get {
				return this.m_qPlayer;
			}
		}
		
		#endregion
	};
};
