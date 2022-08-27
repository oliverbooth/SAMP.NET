using System;

namespace SAMP.API.EventData {
	public class PlayerUpdateEventArgs : EventArgs {
		#region Class Variables
		
		private bool
			m_bCancel;
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets or sets whether the event should cancel.
		/// </summary>
		public bool Cancel {
			get {
				return this.m_bCancel;
			} set {
				this.m_bCancel = value;
			}
		}

		#endregion
	};
};
