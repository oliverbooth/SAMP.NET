using System;

namespace SAMP.API.EventData {
	public class PlayerStateChangeEventArgs : EventArgs {
		#region Class Variables
		
		private PlayerState[] state = { PlayerState.None, PlayerState.None };
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.PlayerStateChangeEventArgs"/> class.
		/// </summary>
		/// <param name="newState">The player's new state.</param>
		/// <param name="oldState">The player's old state.</param>
		public PlayerStateChangeEventArgs(PlayerState newState, PlayerState oldState) {
			this.state[0] = newState;
			this.state[1] = oldState;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the player's new state.
		/// </summary>
		public PlayerState NewState {
			get {
				return this.state[0];
			}
		}
		
		/// <summary>
		/// Gets the player's old state.
		/// </summary>
		public PlayerState OldState {
			get {
				return this.state[1];
			}
		}
		
		#endregion
	};
};
