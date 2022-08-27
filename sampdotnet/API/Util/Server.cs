using System;
using System.Text;

namespace SAMP.API
{
    public class Server
    {
        #region Class Variables

        // Nothing to see here

        #endregion

        #region Events, Delegates and Method Calls

        #region OnRconCommand
        public delegate void OnRconCommandHandler(object sender, EventData.RconCommandEventArgs e);
        public static event OnRconCommandHandler OnRconCommand;

        internal static int _OnRconCommand(string cmd)
        {
            EventData.RconCommandEventArgs args = new EventData.RconCommandEventArgs(cmd);
            try { OnRconCommand(null, args); }
            catch { }
            return args.Handled ? 1 : 0;
        }
        #endregion
        #region OnRconLoginAttempt
        public delegate void OnRconLoginAttemptHandler(object sender, EventData.RconLoginAttemptEventArgs e);
        public static event OnRconLoginAttemptHandler OnRconLoginAttempt;

        internal static void _OnRconLoginAttempt(string ip, string password, int success)
        {
            EventData.RconLoginAttemptEventArgs args = new EventData.RconLoginAttemptEventArgs(ip, password, success == 1);
            try { OnRconLoginAttempt(null, args); }
            catch { }
        }
        #endregion

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the number of currently connected players.
        /// </summary>
        public static int PlayerCount
        {
            get { return Player.playerStore.Count; }
        }

        /// <summary>
        /// Gets the maximum allowed players to connect.
        /// </summary>
        public static int MaxPlayers
        {
            get { return Core.Natives.GetMaxPlayers(); }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sends an RCON command.
        /// </summary>
        /// <param name="command">The RCON command to be executed.</param>
        public static void Rcon(string command)
        {
            Core.Natives.SendRconCommand(command);
        }

        /// <summary>
        /// Retrieve a server variable of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of variable to search for and return. Valid types are System.String, System.Int32 and System.Boolean.</typeparam>
        /// <param name="varname">The name of the variable to retrieve.</param>
        /// <returns>Returns a variable of type T containing the server variable value.</returns>
        public static T Var<T>(string varname)
        {
            if(typeof(T).Equals(typeof(string)))
            {
                StringBuilder sb = new StringBuilder(1024);
                Core.Natives.GetServerVarAsString(varname, sb, sb.Capacity);
                return (T)Convert.ChangeType(sb.ToString(), typeof(T));
            }

            else if(typeof(T).Equals(typeof(int)))
            {
                int buffer = Core.Natives.GetServerVarAsInt(varname);
                return (T)Convert.ChangeType(buffer, typeof(T));
            }

            else if(typeof(T).Equals(typeof(bool)))
            {
                bool buffer = Core.Natives.GetServerVarAsInt(varname) == 1;
                return (T)Convert.ChangeType(buffer, typeof(T));
            }

            else
                return default(T);
        }

        #endregion
    };
};