using System;

namespace SAMP.API.EventData {
	public class VehicleDeathEventArgs : EventArgs {
		#region Class Variables
		
		private Player
			m_qKiller;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.VehicleDeathEventArgs"/> class.
		/// </summary>
		/// <param name="killer">The player who destroyed the vehicle.</param>
		public VehicleDeathEventArgs(Player killer) {
			this.m_qKiller = killer;
		}

		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the player who destroyed the vehicle.
		/// </summary>
		public Player Killer {
			get {
				return this.m_qKiller;
			}
		}

		#endregion
	};
};
