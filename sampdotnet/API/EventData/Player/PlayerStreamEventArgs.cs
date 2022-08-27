using System;

namespace SAMP.API.EventData {
	public class PlayerStreamEventArgs : EventArgs {
		#region Class Variables
		
		private Player
			m_qPlayer;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerStreamEventArgs"/> class.
		/// </summary>
		/// <param name="forplayer">The player who the player streamed in or out for.</param>
		public PlayerStreamEventArgs(Player forplayer) {
			this.m_qPlayer = forplayer;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the player who the player streamed in or out for.
		/// </summary>
		public Player ForPlayer {
			get {
				return this.m_qPlayer;
			}
		}
		
		#endregion
	};
};
