using System;

namespace SAMP.API.EventData {
	public class PlayerExitVehicleEventArgs : EventArgs {
		#region Class Variables
		
		private Vehicle
			m_qVehicle;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerExitVehicleEventArgs"/> class.
		/// </summary>
		/// <param name="vehicle">The vehicle the player is exiting.</param>
		public PlayerExitVehicleEventArgs(Vehicle vehicle) {
			this.m_qVehicle = vehicle;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the vehicle the player is exiting.
		/// </summary>
		public Vehicle Vehicle {
			get {
				return this.m_qVehicle;
			}
		}
		
		#endregion
	};
};
