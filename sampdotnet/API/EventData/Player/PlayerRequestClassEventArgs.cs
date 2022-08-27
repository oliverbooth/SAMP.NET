using System;

namespace SAMP.API.EventData {
	public class PlayerRequestClassEventArgs : EventArgs {
		#region Class Variables
		
		private int
			m_iClassId;
		private bool
			m_bCancel;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerRequestClassEventArgs"/> class.
		/// </summary>
		/// <param name="reason">The reason for the disconnect.</param>
		public PlayerRequestClassEventArgs(int classid) {
			m_iClassId = classid;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// The ID of the current class being viewed.
		/// </summary>
		public int Class {
			get {
				return this.m_iClassId;
			}
		}
		
		/// <summary>
		/// Gets or sets whether the event should cancel (class denied.)
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
