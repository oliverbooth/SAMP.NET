using System;

namespace SAMP.API.EventData {
	public class PlayerDeathEventArgs : EventArgs {
		#region Class Variables
		
		private Player
			m_qKiller;
		private int
			m_iReason;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Creates a new PlayerDeathEventArgs object.
		/// </summary>
		/// <param name="killer">The player who killed the player who died. NULL if none.</param>
		/// <param name="reason">The ID of the reason for the player's death.</param>
		public PlayerDeathEventArgs(Player killer, int reason) {
			this.m_qKiller = killer;
			this.m_iReason = reason;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the player who killed the player who died. NULL if none.
		/// </summary>
		public Player Killer {
			get {
				return this.m_qKiller;
			}
		}
		
		/// <summary>
		/// Gets the ID of the reason for the player's death.
		/// </summary>
		public int Reason {
			get {
				return this.m_iReason;
			}
		}
		
		#endregion
	};
};
