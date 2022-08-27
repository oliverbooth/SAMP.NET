using System;

namespace SAMP.API.EventData {
	public class PlayerSpawnEventArgs : EventArgs {
		#region Class Variables
		
		private bool
			m_bCancel;
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets or sets whether the event should be cancelled (send back to class selection).
		/// </summary>
		public bool Cancel
		{
			get {
				return this.m_bCancel;
			} set {
				this.m_bCancel = value;
			}
		}
		
		#endregion
	};
};