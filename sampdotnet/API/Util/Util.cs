using System;
using System.Text;

namespace SAMP.API
{
    public class Util
    {
        #region Accessors & Mutators

        /// <summary>
        /// Gets the uptime of the actual server in milliseconds. (The machine, NOT the SA:MP server.)
        /// </summary>
        public static TimeSpan TickCount
        {
            get
            {
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
        public static void Log(string format, params object[] args)
        {
            Core.Natives.logprintf(string.Format(format, args));
        }

        /// <summary>
        /// Get the name of a weapon.
        /// </summary>
        /// <param name="weaponid">The Weapon ID you want to know the name of.</param>
        /// <returns>Returns a System.String representing the name of the weapon.</returns>
        public static string GetWeaponName(int weaponid)
        {
            StringBuilder sb = new StringBuilder(50);
            Core.Natives.GetWeaponName(weaponid, sb, sb.Capacity);
            return sb.ToString();
        }

        #endregion
    };
};