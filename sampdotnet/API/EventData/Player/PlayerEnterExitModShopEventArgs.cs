using System;

namespace SAMP.API.EventData {
	public class PlayerEnterExitModShopEventArgs : EventArgs {
		#region Class Variables
		
		private bool
			m_bEntering;
		private int
			m_iInterior;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerEnterExitModShopEventArgs"/> class.
		/// </summary>
		/// <param name="entering"><c>true</c> if the player is entering, otherwise <c>false</c>.</param>
		/// <param name="interiodid">The interior ID of the modshop that the player is entering (or 0 if exiting).</param>
		public PlayerEnterExitModShopEventArgs(bool entering, int interiodid) {
			this.m_bEntering = entering;
			this.m_iInterior = interiodid;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets whether or not the player is Entering a mod shop.
		/// </summary>
		public bool Entering {
			get {
				return this.m_bEntering;
			}
		}
		
		/// <summary>
		/// Gets the interior ID of the modshop that the player is entering. This property will be 0 if the player is exiting.
		/// </summary>
		public int Interior {
			get {
				return this.m_iInterior;
			}
		}
		
		#endregion
	};
};
