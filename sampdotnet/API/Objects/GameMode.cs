using System;

namespace SAMP.API
{
    public class GameMode
    {
        #region Class Variables

        private static bool _bGameModeInitialized = false;
        private static bool _bPlayerPedAnims = false;
        private static int _nClassCount = 0;
        private static int _nTeamCount = 0;
        private static string _strGameModeText = string.Empty;

        #endregion

        #region Events & Delegates

        public delegate void OnInitHandler(object sender, EventArgs e);
        public delegate void OnExitHandler(object sender, EventArgs e);

        public static event OnInitHandler OnInit;
        public static event OnExitHandler OnExit;

        #endregion

        #region Accessors & Mutators

        [Obsolete("This property is deprecated. Please see the SAMP.API.Player.OnClickMap event.", true)]
        /// <summary>
        /// Gets or sets whether RCON admins will be teleported to their waypoint when they set one.
        /// </summary>
        public static bool AllowAdminTeleport { get { return false; } set { } }

        [Obsolete("This property is deprecated.", true)]
        /// <summary>
        /// Gets or sets the amount of money dropped when a player dies.
        /// </summary>
        public static int DeathDropAmount { get { return 0; } set { } }

        [Obsolete("This property is deprecated due to crashes it caused.", true)]
        /// <summary>
        /// Gets or sets the zone / area names being shown on screen as a player enters the area.
        /// </summary>
        public static bool ZoneNames { get { return false; } set { } }

        /// <summary>
        /// Gets the amount of player classes used in the gamemode.
        /// </summary>
        public static int ClassCount
        {
            get { return _nClassCount; }
        }

        // Pointless property, but meh - I tried to port everything.
        /// <summary>
        /// Gets or sets the amount of teams used in the gamemode.
        /// </summary>
        /// <remarks>You can pass 2 billion here if you like, this function has no effect at all.</remarks>
        public static int TeamCount
        {
            get { return _nTeamCount; }
            set { _nTeamCount = value; Core.Natives.SetTeamCount(value); }
        }

        /// <summary>
        /// Gets or sets the name of the gamemode, which appears in the list of servers.
        /// </summary>
        public static string Text
        {
            get { return _strGameModeText; }
            set { _strGameModeText = value; Core.Natives.SetGameModeText(value); }
        }

        /// <summary>
        /// Gets or sets whether to use standard player walking animation (animation of CJ)
        /// </summary>
        /// <remarks>Only works when placed under the SAMP.API.GameMode.Init event.</remarks>
        public static bool UsePlayerPedAnims
        {
            get { return _bPlayerPedAnims; }
            set
            {
                // This property only works under Init event

                if(!_bGameModeInitialized)
                {
                    _bPlayerPedAnims = value;

                    // Check the value was true. We don't want to call the function
                    // if they didn't intend it to be true.
                    if(value)
                        Core.Natives.UsePlayerPedAnims();
                }
                else
                    throw Core.Exceptions.GameModeInitialized;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a class to class selection.
        /// </summary>
        /// <param name="skin">The skin which the player will spawn with.</param>
        /// <param name="spawnPoint">The spawnpoint of this class.</param>
        /// <param name="angle">The direction in which the player should face after spawning.</param>
        /// <param name="weapon1">The first spawn-weapon for the player.</param>
        /// <param name="weapon1_ammo">The amount of ammunition for the primary spawnweapon.</param>
        /// <param name="weapon2">The second spawn-weapon for the player.</param>
        /// <param name="weapon2_ammo">The amount of ammunition for the secondary spawnweapon.</param>
        /// <param name="weapon3">The third spawn-weapon for the player.</param>
        /// <param name="weapon3_ammo">The amount of ammunition for the third spawnweapon.</param>
        /// <returns>Returns the ID of the class which was just added.</returns>
        /// <remarks>Classes are used so players may spawn with a skin of their choice and so on.</remarks>
        /// <example>SAMP.API.GameMode.AddPlayerClass(SAMP.API.Skin.cj, new Vector3(1958.33f, 1343.12f, 15.36f), 269.15, 26, 36, 28, 150, 0, 0);</example>
        public int AddPlayerClass(Skin skin, Vector3 spawnPoint, float angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo)
        {
            // Call native
            _nClassCount++;
            return Core.Natives.AddPlayerClass((int)skin, spawnPoint.X, spawnPoint.Y, spawnPoint.Z, angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
        }

        /// <summary>
        /// Adds a class to class selection, with a team parameter.
        /// </summary>
        /// <param name="team">The team you want the player to spawn in.</param>
        /// <param name="skin">The skin which the player will spawn with.</param>
        /// <param name="spawnPoint">The spawnpoint of this class.</param>
        /// <param name="angle">The direction in which the player should face after spawning.</param>
        /// <param name="weapon1">The first spawn-weapon for the player.</param>
        /// <param name="weapon1_ammo">The amount of ammunition for the primary spawnweapon.</param>
        /// <param name="weapon2">The second spawn-weapon for the player.</param>
        /// <param name="weapon2_ammo">The amount of ammunition for the secondary spawnweapon.</param>
        /// <param name="weapon3">The third spawn-weapon for the player.</param>
        /// <param name="weapon3_ammo">The amount of ammunition for the third spawnweapon.</param>
        /// <returns>Returns the ID of the class which was just added.</returns>
        /// <remarks>Classes are used so players may spawn with a skin of their choice and so on.</remarks>
        /// <example>SAMP.API.GameMode.AddPlayerClass(15, SAMP.API.Skin.cj, new Vector3(1958.33f, 1343.12f, 15.36f), 269.15, 26, 36, 28, 150, 0, 0);</example>
        public int AddPlayerClass(int team, Skin skin, Vector3 spawnPoint, float angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo)
        {
            // Call native
            _nClassCount++;
            return Core.Natives.AddPlayerClassEx(team, (int)skin, spawnPoint.X, spawnPoint.Y, spawnPoint.Z, angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
        }

        #endregion

        #region Internal Methods

        /// <summary>
        /// Invoke the OnExit event.
        /// </summary>
        internal static void _OnExit()
        {
            try { OnExit(null, null); }
            catch { }
            _bGameModeInitialized = false;
        }

        /// <summary>
        /// Invoke the OnInit event.
        /// </summary>
        internal static void _OnInit()
        {
            try { OnInit(null, null); }
            catch { }
            _bGameModeInitialized = true;
        }

        #endregion
    };
};