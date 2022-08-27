using System;

namespace SAMP.API.EventData {
	public class RconLoginAttemptEventArgs : EventArgs {
		#region Class Variables
		
		private string
			m_strIp,
			m_strPassword;
		private bool
			m_bSuccess;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.EventData.RconLoginAttemptEventArgs"/> class.
		/// </summary>
		/// <param name="ip">The IP of the player that tried to login to RCON.</param>
		/// <param name="password">The password used to login with.</param>
		/// <param name="success">False if the password was incorrect or True if it was correct.</param>
		public RconLoginAttemptEventArgs(string ip, string password, bool success) {
			this.m_strIp = ip;
			this.m_strPassword = password;
			this.m_bSuccess = success;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the IP of the player that tried to login to RCON.
		/// </summary>
		public string IP {
			get {
				return this.m_strIp;
			}
		}
		
		/// <summary>
		/// Gets the password used to login with.
		/// </summary>
		public string Password {
			get {
				return this.m_strPassword;
			}
		}
		
		/// <summary>
		/// Gets whether or not the password was correct.
		/// </summary>
		public bool Success {
			get {
				return this.m_bSuccess;
			}
		}
		
		#endregion
	};
};
