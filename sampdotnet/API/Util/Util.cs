using System;
using System.Text;

namespace SAMP.API {
	public class Util {
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets a value indicating whether the current platform is Linux.
		/// </summary>
		public static bool IsLinux {
			get {
				int iPlatform = (int)Environment.OSVersion.Platform;
				return (iPlatform == 4) || (iPlatform == 6) || (iPlatform == 128);
			}
		}
		
		/// <summary>
		/// Gets a value indicating whether the current platform is Windows.
		/// </summary>
		public static bool IsWindows {
			get {
				return !IsLinux;
			}
		}
		
		/// <summary>
		/// Gets the uptime of the actual server in milliseconds. (The machine, NOT the SA:MP server.)
		/// </summary>
		public static TimeSpan TickCount {
			get {
				return TimeSpan.FromMilliseconds(Core.Natives.GetTickCount());
			}
		}
		
		#endregion
		
		#region Public Methods
		
		/// <summary>
		/// Outputs a formatted string on the console (the server window, not the in-game chat).
		/// </summary>
		/// <param name="format">The format string.</param>
		/// <param name="args">Indefinite number of arguments of any tag.</param>
		public static void Log(string format, params object[] args) {
			Core.Natives.logprintf(string.Format(format, args));
		}
		
		/// <summary>
		/// Gets the name of a weapon.
		/// </summary>
		/// <param name="weaponid">The Weapon ID you want to know the name of.</param>
		/// <returns>The weapon name.</returns>
		public static string GetWeaponName(int weaponid) {
			StringBuilder pstrWeaponName = new StringBuilder(50);
			Core.Natives.GetWeaponName(weaponid, pstrWeaponName, pstrWeaponName.Capacity);
			return pstrWeaponName.ToString();
		}
		
		#endregion
	};
};
