using System;

namespace SAMP.API.EventData {
	public class PlayerPickUpPickupEventArgs : EventArgs {
		#region Class Variables
		
		private int 
			m_iId;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerPickUpPickupEventArgs"/> class.
		/// </summary>
		/// <param name="position">The ID of the pickup.</param>
		public PlayerPickUpPickupEventArgs(int pickupid) {
			this.m_iId = pickupid;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// The ID of the pickup.
		/// </summary>
		public int PickUp {
			get {
				return this.m_iId;
			}
		}
		
		#endregion
	};
};
