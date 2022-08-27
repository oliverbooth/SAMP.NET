using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SAMP.API
{
    public class Player : Core.IWorldEntity, Core.ICountable
    {
        #region Class Variables

        private bool _bFindZOnPosChange;
        private bool _bClock;
        private int _nPlayerID;
        private int _nSeat;
        private int _nWeather;
        private SpawnInfo _qSpawnInfo;
        private PlayerCamera _qCamera;

        internal static Hashtable playerStore = new Hashtable();
        internal Hashtable variables = new Hashtable();

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new Player object.
        /// <param name="id">The ID of the player.</param>
        /// </summary>
        internal Player(int id)
        {
            _nPlayerID = id;
            _qCamera = new PlayerCamera(this);
            _qSpawnInfo = new API.SpawnInfo(this);
        }

        #endregion

        #region Events, Delegates and Method Calls

        // TODO: Implement more events

        #region OnConnect
        public delegate void OnConnectHandler(object sender, System.EventArgs e);
        public static event OnConnectHandler OnConnect;

        internal void _OnConnect()
        {
            playerStore.Add(this.ID, this);

            try { OnConnect(this, null); }
            catch { }
        }
        #endregion
        #region OnDisconnect
        public delegate void OnDisconnectHandler(object sender, EventData.PlayerDisconnectEventArgs e);
        public static event OnDisconnectHandler OnDisconnect;

        internal void _OnDisconnect(int reason)
        {
            // Remove from collection
            Player.playerStore.Remove(this.ID);

            EventData.PlayerDisconnectEventArgs args = new EventData.PlayerDisconnectEventArgs((DisconnectReason)reason);
            try { OnDisconnect(this, args); }
            catch { }
        }
        #endregion
        #region OnDeath
        public delegate void OnDeathHandler(object sender, EventData.PlayerDeathEventArgs e);
        public static event OnDeathHandler OnDeath;

        internal void _OnDeath(Player killer, int reason)
        {
            EventData.PlayerDeathEventArgs args = new EventData.PlayerDeathEventArgs(killer, reason);
            try { OnDeath(this, args); }
            catch { }
        }
        #endregion
        #region OnSpawn
        public delegate void OnSpawnHandler(object sender, EventData.PlayerSpawnEventArgs e);
        public static event OnSpawnHandler OnSpawn;

        internal void _OnSpawn(ref bool cancel)
        {
            EventData.PlayerSpawnEventArgs args = new EventData.PlayerSpawnEventArgs();
            try { OnSpawn(this, args); cancel = args.Cancel; }
            catch { }
        }
        #endregion
        #region OnText
        public delegate void OnTextHandler(object sender, EventData.PlayerTextEventArgs e);
        public static event OnTextHandler OnText;

        internal int _OnText(string text)
        {
            EventData.PlayerTextEventArgs args = new EventData.PlayerTextEventArgs(text);
            try { OnText(this, args); }
            catch { }
            return args.Cancel ? 0 : 1;
        }
        #endregion
        #region OnCommandText
        public delegate void OnCommandTextHandler(object sender, EventData.PlayerCommandTextEventArgs e);
        public static event OnCommandTextHandler OnCommandText;
        
        internal void _OnCommandText(string text, ref bool handled)
        {
            EventData.PlayerCommandTextEventArgs args = new EventData.PlayerCommandTextEventArgs(text);
            try { OnCommandText(this, args); handled = args.Handled; }
            catch { }
        }
        #endregion
        #region OnRequestClass
        public delegate void OnRequestClassHandler(object sender, EventData.PlayerRequestClassEventArgs e);
        public static event OnRequestClassHandler OnRequestClass;
        
        internal void _OnRequestClass(int classid, ref bool cancel)
        {
            EventData.PlayerRequestClassEventArgs args = new EventData.PlayerRequestClassEventArgs(classid);
            try { OnRequestClass(this, args); cancel = args.Cancel; }
            catch { }
        }
        #endregion
        #region OnEnterVehicle
        public delegate void OnEnterVehicleHandler(object sender, EventData.PlayerEnterVehicleEventArgs e);
        public static event OnEnterVehicleHandler OnEnterVehicle;

        internal void _OnEnterVehicle(int vehicleid, bool ispassenger)
        {
            EventData.PlayerEnterVehicleEventArgs args = new EventData.PlayerEnterVehicleEventArgs(Vehicle.Get(vehicleid), ispassenger);
            try { OnEnterVehicle(this, args); }
            catch { }
        }
        #endregion
        #region OnExitVehicle
        public delegate void OnExitVehicleHandler(object sender, EventData.PlayerExitVehicleEventArgs e);
        public static event OnExitVehicleHandler OnExitVehicle;

        internal void _OnExitVehicle(int vehicleid)
        {
            EventData.PlayerExitVehicleEventArgs args = new EventData.PlayerExitVehicleEventArgs(Vehicle.Get(vehicleid));
            try { OnExitVehicle(this, args); }
            catch { }
        }
        #endregion
        #region OnStateChange
        public delegate void OnStateChangeHandler(object sender, EventData.PlayerStateChangeEventArgs e);
        public static event OnStateChangeHandler OnStateChange;

        internal void _OnStateChange(int newstate, int oldstate)
        {
            EventData.PlayerStateChangeEventArgs args = new EventData.PlayerStateChangeEventArgs((PlayerState)newstate, (PlayerState)oldstate);
            try { OnStateChange(this, args); }
            catch { }
        }
        #endregion
        #region OnEnterCheckpoint
        public delegate void OnEnterCheckpointHandler(object sender, System.EventArgs e);
        public static event OnEnterCheckpointHandler OnEnterCheckpoint;

        internal void _OnEnterCheckpoint()
        {
            try { OnEnterCheckpoint(this, null); }
            catch { }
        }
        #endregion
        #region OnLeaveCheckpoint
        public delegate void OnLeaveCheckpointHandler(object sender, System.EventArgs e);
        public static event OnLeaveCheckpointHandler OnLeaveCheckpoint;

        internal void _OnLeaveCheckpoint()
        {
            try { OnLeaveCheckpoint(this, null); }
            catch { }
        }
        #endregion
        #region OnEnterRaceCheckpoint
        public delegate void OnEnterRaceCheckpointHandler(object sender, System.EventArgs e);
        public static event OnEnterRaceCheckpointHandler OnEnterRaceCheckpoint;

        internal void _OnEnterRaceCheckpoint()
        {
            try { OnEnterRaceCheckpoint(this, null); }
            catch { }
        }
        #endregion
        #region OnLeaveRaceCheckpoint
        public delegate void OnLeaveRaceCheckpointHandler(object sender, System.EventArgs e);
        public static event OnLeaveRaceCheckpointHandler OnLeaveRaceCheckpoint;

        internal void _OnLeaveRaceCheckpoint()
        {
            try { OnLeaveRaceCheckpoint(this, null); }
            catch { }
        }
        #endregion
        #region OnRequestSpawn
        public delegate void OnRequestSpawnHandler(object sender, EventData.PlayerSpawnEventArgs e);
        public static event OnRequestSpawnHandler OnRequestSpawn;

        internal int _OnRequestSpawn()
        {
            EventData.PlayerSpawnEventArgs args = new EventData.PlayerSpawnEventArgs();
            try { OnRequestSpawn(this, args); }
            catch { }
            return args.Cancel ? 0 : 1;
        }
        #endregion
        #region OnEnterExitModShop
        public delegate void OnEnterExitModShopHandler(object sender, EventData.PlayerEnterExitModShopEventArgs e);
        public static event OnEnterExitModShopHandler OnEnterExitModShop;

        internal void _OnEnterExitModShop(int enterexit, int interiodid)
        {
            EventData.PlayerEnterExitModShopEventArgs args = new EventData.PlayerEnterExitModShopEventArgs(enterexit == 1, interiodid);
            try { OnEnterExitModShop(this, args); }
            catch { }
        }
        #endregion
        #region OnPickUpPickup
        public delegate void OnPickUpPickupHandler(object sender, EventData.PlayerPickUpPickupEventArgs e);
        public static event OnPickUpPickupHandler OnPickUpPickup;

        internal void _OnPickUpPickup(int pickupid)
        {
            EventData.PlayerPickUpPickupEventArgs args = new EventData.PlayerPickUpPickupEventArgs(pickupid);
            try { OnPickUpPickup(this, args); }
            catch { }
        }
        #endregion        #region OnStreamIn
        #region OnStreamIn
        public delegate void OnStreamInHandler(object sender, EventData.PlayerStreamEventArgs e);
        public static event OnStreamInHandler OnStreamIn;

        internal void _OnStreamIn(int forplayerid)
        {
            EventData.PlayerStreamEventArgs args = new EventData.PlayerStreamEventArgs(Player.Get(forplayerid));
            try { OnStreamIn(this, args); }
            catch { }
        }
        #endregion
        #region OnStreamOut
        public delegate void OnStreamOutHandler(object sender, EventData.PlayerStreamEventArgs e);
        public static event OnStreamOutHandler OnStreamOut;

        internal void _OnStreamOut(int forplayerid)
        {
            EventData.PlayerStreamEventArgs args = new EventData.PlayerStreamEventArgs(Player.Get(forplayerid));
            try { OnStreamOut(this, args); }
            catch { }
        }
        #endregion
        #region OnClickMap
        public delegate void OnClickMapHandler(object sender, EventData.PlayerClickMapEventArgs e);
        public static event OnClickMapHandler OnClickMap;

        internal void _OnClickMap(float x, float y, float z)
        {
            switch(0)
            {
                case 0:
                case 1:
                    goto case 2;
                case 2:
                    goto default;
                default:
                    break;
            }
            EventData.PlayerClickMapEventArgs args = new EventData.PlayerClickMapEventArgs(new Vector3(x, y, z));
            try { OnClickMap(this, args); }
            catch { }
        }
        #endregion
        #region OnDialogResponse
        public delegate void OnDialogResponseHandler(object sender, EventData.DialogResponseEventArgs e);
        public static event OnDialogResponseHandler OnDialogResponse;

        internal void _OnDialogResponse(int dialogid, int response, int listitem, string inputtext, ref bool passon)
        {
            EventData.DialogResponseEventArgs args = new EventData.DialogResponseEventArgs(dialogid, response, listitem, inputtext);
            try { OnDialogResponse(this, args); passon = args.ContinueToFilterscripts; }
            catch { }
        }
        #endregion
        #region OnUpdate
        public delegate void OnUpdateHandler(object sender, EventData.PlayerUpdateEventArgs e);
        public static event OnUpdateHandler OnUpdate;

        internal int _OnUpdate()
        {
            EventData.PlayerUpdateEventArgs args = new EventData.PlayerUpdateEventArgs();
            try { OnUpdate(this, args); }
            catch { }
            return args.Cancel ? 0 : 1;
        }
        #endregion

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets an array representing the currently connected players.
        /// </summary>
        public static Player[] All
        {
            get
            {
                // Create a temporary buffer list to store the player collection
                List<Player> l = new List<Player>();

                // Iterate through the player collection
                foreach(DictionaryEntry line in playerStore)
                {
                    // Add the current player entry to the buffer
                    l.Add((Player)line.Value);
                }

                // Return an array representing the players
                return l.ToArray();
            }
        }

        /// <summary>
        /// Gets or sets the player's facing angle.
        /// </summary>
        public float Angle
        {
            get
            {
                float angle = 0f;
                Core.Natives.GetPlayerFacingAngle(this.ID, ref angle);
                return angle;
            }
            set
            {
                Core.Natives.SetPlayerFacingAngle(this.ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the player's armour.
        /// </summary>
        public float Armour
        {
            get
            {
                float armour = 0f;
                Core.Natives.GetPlayerArmour(this.ID, ref armour);
                return armour;
            }
            set
            {
                Core.Natives.SetPlayerArmour(this.ID, value);
            }
        }

        /// <summary>
        /// Gets the PlayerCamera associated with this player (for use with GetPlayerCameraPos etc.)
        /// </summary>
        public PlayerCamera Camera
        {
            get
            {
                return _qCamera;
            }
        }

        /// <summary>
        /// Gets or sets the player's color.
        /// </summary>
        public Color Color
        {
            get { return Color.FromArgb(Core.Natives.GetPlayerColor(this.ID)); }
            set { Core.Natives.SetPlayerColor(this.ID, value.ToArgb()); }
        }

        /// <summary>
        /// Gets or sets the visibility of the in-game clock for the player.
        /// </summary>
        public bool Clock
        {
            get { return _bClock; }
            set { _bClock = value; Core.Natives.TogglePlayerClock(this.ID, value ? 1 : 0); }
        }

        /// <summary>
        /// Gets or sets the player's drunk level.
        /// </summary>
        /// <remarks>
        /// Note: Drunk level will automatically decrease over time (players with 50 FPS will lose 50 'levels' per second. This is useful for determining a player's FPS!)
        /// 
        /// Note: In 0.3a drunk level will decrement and stop at 2000. In 0.3b+ drunk level decrements to zero.)
        /// 
        /// Note: Levels over 2000 make the player drunk. Max drunk level is 50000. If the drunk level is above 5000, the player's radar will be hidden.
        /// </remarks>
        public int DrunkLevel
        {
            get { return Core.Natives.GetPlayerDrunkLevel(this.ID); }
            set { Core.Natives.SetPlayerDrunkLevel(this.ID, value); }
        }

        /// <summary>
        /// Gets or sets whether the player's position adjusts on the Z axis to the nearest solid ground under the position.
        /// NOTE: This value is reset to FALSE after every position change.
        /// </summary>
        public bool FindZOnPosChange
        {
            get { return _bFindZOnPosChange; }
            set { _bFindZOnPosChange = value; }
        }

        /// <summary>
        /// Gets or sets the player's health.
        /// </summary>
        public float Health
        {
            get
            {
                float health = 0f;
                Core.Natives.GetPlayerHealth(this.ID, ref health);
                return health;
            }
            set
            {
                Core.Natives.SetPlayerHealth(this.ID, value);
            }
        }

        /// <summary>
        /// Gets the player's ID.
        /// </summary>
        public int ID
        {
            get { return this._nPlayerID; }
        }

        /// <summary>
        /// Gets the player's IP address.
        /// </summary>
        public string IPAddress
        {
            get
            {
                StringBuilder sb = new StringBuilder(16);
                Core.Natives.GetPlayerIp(this.ID, sb, sb.Capacity);
                return sb.ToString();
            }
        }

        /// <summary>
        /// Gets whether the player is logged into RCON.
        /// </summary>
        public bool IsAdmin
        {
            get { return Core.Natives.IsPlayerAdmin(this.ID) == 1; }
        }

        /// <summary>
        /// Gets the player's currently pressed keys.
        /// </summary>
        public Keys Keys
        {
            get
            {
                int keys = 0, updown = 0, leftright = 0;
                Core.Natives.GetPlayerKeys(this.ID, ref keys, ref updown, ref leftright);
                return (Keys)keys;
            }
        }

        /// <summary>
        /// Gets the player's currently pressed left/right analog keys.
        /// </summary>
        public int KeysLeftRight
        {
            get
            {
                int keys = 0, updown = 0, leftright = 0;
                Core.Natives.GetPlayerKeys(this.ID, ref keys, ref updown, ref leftright);
                return leftright;
            }
        }

        /// <summary>
        /// Gets the player's currently pressed up/down analog keys.
        /// </summary>
        public int KeysUpDown
        {
            get
            {
                int keys = 0, updown = 0, leftright = 0;
                Core.Natives.GetPlayerKeys(this.ID, ref keys, ref updown, ref leftright);
                return updown;
            }
        }

        /// <summary>
        /// Gets the Menu the player is currently viewing, or NULL if they aren't viewing one.
        /// </summary>
        public Menu Menu
        {
            get
            {
                int menuid = Core.Natives.GetPlayerMenu(this.ID);
                return menuid == 255 ? null : Menu.Get(menuid);
            }
        }

        /// <summary>
        /// Gets the player's name
        /// </summary>
        public string Name
        {
            get
            {
                StringBuilder sb = new StringBuilder(24);
                Core.Natives.GetPlayerName(this.ID, sb, sb.Capacity);
                return sb.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the player's money.
        /// </summary>
        public int Money
        {
            get
            {
                return Core.Natives.GetPlayerMoney(this.ID);
            }
            set
            {
                Core.Natives.ResetPlayerMoney(this.ID);
                Core.Natives.GivePlayerMoney(this.ID, value);
            }
        }

        /// <summary>
        /// Gets the ping of the player (expressed in milliseconds.)
        /// </summary>
        public int Ping
        {
            get { return Core.Natives.GetPlayerPing(this.ID); }
        }

        /// <summary>
        /// Gets or sets a player's position.
        /// </summary>
        public Vector3 Position
        {
            get
            {
                float
                    x = 0f,
                    y = 0f,
                    z = 0f;
                Core.Natives.GetPlayerPos(this.ID, ref x, ref y, ref z);
                return new Vector3(x, y, z);
            }
            set
            {
                if(this.FindZOnPosChange)
                {
                    this.FindZOnPosChange = false;
                    Core.Natives.SetPlayerPosFindZ(this.ID, value.X, value.Y, value.Z);
                }
                else
                    Core.Natives.SetPlayerPos(this.ID, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets or sets the seat of the vehicle the player is in.
        /// </summary>
        public int Seat
        {
            get
            {
                return Core.Natives.GetPlayerVehicleSeat(this.ID);
            }
            set
            {
                if(Core.Natives.IsPlayerInAnyVehicle(this.ID) == 0)
                    _nSeat = value;
                else
                    Core.Natives.PutPlayerInVehicle(this.ID, this.Vehicle.ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the player's score.
        /// </summary>
        public int Score
        {
            get { return Core.Natives.GetPlayerScore(this.ID); }
            set { Core.Natives.SetPlayerScore(this.ID, value); }
        }

        /// <summary>
        /// Gets or sets the player's skin.
        /// </summary>
        public int Skin
        {
            get { return Core.Natives.GetPlayerSkin(this.ID); }
            set { Core.Natives.SetPlayerSkin(this.ID, value); }
        }

        /// <summary>
        /// Gets the SpawnInfo of this player.
        /// </summary>
        public SpawnInfo SpawnInfo
        {
            get { return _qSpawnInfo; }
        }

        /// <summary>
        /// Gets or sets the special action of the player.
        /// </summary>
        public SpecialAction SpecialAction
        {
            get { return (SpecialAction)Core.Natives.GetPlayerSpecialAction(this.ID); }
            set
            {
                switch(value)
                {
                    case API.SpecialAction.Duck:
                    case API.SpecialAction.EnterVehicle:
                    case API.SpecialAction.ExitVehicle:
                        throw new Exception("This special action cannot be set.");
                    default:
                        Core.Natives.SetPlayerSpecialAction(this.ID, (int)value);
                        break;
                }
            }
        }

        /// <summary>
        /// Gets or sets the player's team.
        /// </summary>
        public int Team
        {
            get { return Core.Natives.GetPlayerTeam(this.ID); }
            set { Core.Natives.SetPlayerTeam(this.ID, value); }
        }

        /// <summary>
        /// Gets or sets the player's time.
        /// </summary>
        /// <remarks>Only the Hour and Minute values take effect here. You can pass any valid year, month, day and second - it doesn't make a difference.</remarks>
        public DateTime Time
        {
            get
            {
                int hour = 0, minute = 0;
                Core.Natives.GetPlayerTime(this.ID, ref hour, ref minute);
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
            }
            set { Core.Natives.SetPlayerTime(this.ID, value.Hour, value.Minute); }
        }

        /// <summary>
        /// Gets or sets a player's vehicle.
        /// </summary>
        public Vehicle Vehicle
        {
            get
            {
                if(Core.Natives.IsPlayerInAnyVehicle(this.ID) == 0)
                    return null;

                return Vehicle.Get(Core.Natives.GetPlayerVehicleID(this.ID));
            }
            set
            {
                if(value == null)
                    Core.Natives.RemovePlayerFromVehicle(this.ID);
                else
                    Core.Natives.PutPlayerInVehicle(this.ID, value.ID, _nSeat);
            }
        }

        /// <summary>
        /// Gets the player's client version.
        /// </summary>
        public string Version
        {
            get
            {
                StringBuilder sb = new StringBuilder(10);
                Core.Natives.GetPlayerVersion(this.ID, sb, sb.Capacity);
                return sb.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the player's wanted level (6 brown stars under HUD.)
        /// </summary>
        public int WantedLevel
        {
            get { return Core.Natives.GetPlayerWantedLevel(this.ID); }
            set { Core.Natives.SetPlayerWantedLevel(this.ID, value); }
        }

        /// <summary>
        /// Gets or sets the player's currently armed weapon.
        /// </summary>
        public Weapon Weapon
        {
            get { return (Weapon)Core.Natives.GetPlayerWeapon(this.ID); }
            set { Core.Natives.SetPlayerArmedWeapon(this.ID, (int)value); }
        }

        /// <summary>
        /// Gets the state of the player's weapon.
        /// </summary>
        public WeaponState WeaponState
        {
            get { return (WeaponState)Core.Natives.GetPlayerWeaponState(this.ID); }
        }

        /// <summary>
        /// Gets or sets the player's current weather.
        /// </summary>
        public int Weather
        {
            get { return _nWeather; }
            set { _nWeather = value; Core.Natives.SetPlayerWeather(this.ID, value); }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets a player by their player ID.
        /// </summary>
        /// <param name="playerid">The player ID to search for.</param>
        /// <returns>Returns a Player object whose ID is playerid, or NULL if no such player is connected.</returns>
        public static Player Get(int playerid)
        {
            // Iterate through the player collection store
            foreach(DictionaryEntry d in playerStore)
            {
                if(d.Key.Equals(playerid))
                    return (Player)d.Value;
            }

            // The player doesn't exist.
            return null;
        }

        /// <summary>
        /// Bans the player from the server. Bans are IP-based, and stored in samp.ban.
        /// </summary>
        public void Ban()
        {
            Core.Natives.Ban(this.ID);
        }

        /// <summary>
        /// Bans the player from the server with a reason. Bans are IP-based, and stored in samp.ban.
        /// </summary>
        public void Ban(string reason)
        {
            Core.Natives.BanEx(this.ID, reason);
        }

        /// <summary>
        /// Gets all players in a given range of this player.
        /// </summary>
        /// <param name="range">The range to scan.</param>
        /// <returns>An array of Player objects representing the players within the given range of this player.</returns>
        public Player[] GetInRange(float range)
        {
            // Create variables
            List<Player> buffer = new List<Player>();
            Player[] players = Player.All;

            // Iterate through the connected players
            for(int i = 0; i < players.Length; i++)
            {
                // Check their distance
                if(Vector3.Distance(this.Position, players[i].Position) <= range)
                    // Add them to the buffer if they are in range
                    buffer.Add(players[i]);
            }

            // Return the buffer as an array
            return buffer.ToArray();
        }

        /// <summary>
        /// Gives the player a weapon.
        /// </summary>
        /// <param name="weapon">The ID of the weapon you want to give the player.</param>
        /// <param name="ammo">How much ammo to giev the player.</param>
        public void GiveWeapon(int weapon, int ammo)
        {
            Core.Natives.GivePlayerWeapon(this.ID, weapon, ammo);
        }

        /// <summary>
        /// Hides a menu to the player.
        /// </summary>
        /// <param name="menu">The menu to hide.</param>
        public void HideMenu(Menu menu)
        {
            Core.Natives.HideMenuForPlayer(menu.ID, this.ID);
        }

        /// <summary>
        /// Determines if the player is in any vehicle.
        /// </summary>
        /// <returns>Returns a System.Boolean representing whether or not the player is in any vehicle.</returns>
        public bool IsInVehicle()
        {
            return Core.Natives.IsPlayerInAnyVehicle(this.ID) == 1;
        }

        /// <summary>
        /// Determines if the player is in the specified vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle to check.</param>
        /// <returns>Returns a System.Boolean representing whether or not the player is in the vehicle.</returns>
        public bool IsInVehicle(Vehicle vehicle)
        {
            return Core.Natives.IsPlayerInVehicle(this.ID, vehicle.ID) == 1;
        }

        /// <summary>
        /// Determines if a player is streamed in another player's client.
        /// </summary>
        /// <param name="player">The player to check if this player is streamed in for.</param>
        /// <returns>Returns a System.Boolean representing whether or not the player is streamed in for the given player.</returns>
        public bool IsStreamedIn(Player player)
        {
            return Core.Natives.IsPlayerStreamedIn(this.ID, player.ID) == 1;
        }

        /// <summary>
        /// Kicks the player from the server.
        /// </summary>
        public void Kick()
        {
            Core.Natives.Kick(this.ID);
        }

        /// <summary>
        /// Plays a crime report for the player (similar to that of SP when CJ commits a crime.)
        /// </summary>
        /// <param name="suspect">The suspect which commited the crime.</param>
        /// <param name="crime">The Crime ID.</param>
        public void PlayCrimeReport(Player suspect, int crime)
        {
            Core.Natives.PlayCrimeReportForPlayer(this.ID, suspect.ID, crime);
        }

        /// <summary>
        /// Plays the specified sound for the player.
        /// </summary>
        /// <param name="sound">The sound to play.</param>
        public void PlaySound(int sound)
        {
            PlaySound(sound, Vector3.Zero);
        }

        /// <summary>
        /// Plays the specified sound for the player at the given position.
        /// </summary>
        /// <param name="sound">The sound to play.</param>
        /// <param name="position">The position at which to play the sound. Vector3.Zero for no position</param>
        public void PlaySound(int sound, Vector3 position)
        {
            Core.Natives.PlayerPlaySound(this.ID, sound, position.X, position.Y, position.Z);
        }

        /// <summary>
        /// Show a dialog to the player.
        /// </summary>
        /// <param name="style">The style of the dialog.</param>
        /// <param name="text">The text to display.</param>
        /// <param name="caption">The title at the top of the dialog.</param>
        /// <param name="button1">The text on the left button.</param>
        /// <param name="button2">The text on the right button. Leave blank to hide it.</param>
        public void ShowDialog(DialogStyle style, int dialogid, string text, string caption, string button1, string button2 = "")
        {
            Core.Natives.ShowPlayerDialog(this.ID, dialogid, (int)style, caption, text, button1, button2);
        }

        /// <summary>
        /// Allows the toggling of the specified player's name tag being visible to the player.
        /// </summary>
        /// <param name="showPlayer">Player whose name tag will be shown or hidden.</param>
        /// <param name="show">True - show name tag, False - hide name tag.</param>
        public void ShowNameTag(Player showPlayer, bool show)
        {
            Core.Natives.ShowPlayerNameTagForPlayer(this.ID, showPlayer.ID, show ? 1 : 0);
        }

        /// <summary>
        /// Sends a message to the player with white text. SA-MP color embedding is supported.
        /// </summary>
        /// <param name="message">The string of text you would like to send.</param>
        /// <seealso cref="World.SendMessageToAll"/>
        public void SendMessage(string message)
        {
            SendMessage(message, Color.White);
        }

        /// <summary>
        /// Sends a message to the player with the certain color. SA-MP color embedding is supported.
        /// </summary>
        /// <param name="message">The string of text you would like to send.</param>
        /// <param name="color">The color it should be in. This overload supports a SAMP.Color.</param>
        /// <seealso cref="World.SendMessageToAll"/>
        public void SendMessage(string message, Color color)
        {
            Core.Natives.SendClientMessage(this.ID, color.ToArgb(), message);
        }

        /// <summary>
        /// Sets the skill level of a certain weapon type for a player.
        /// </summary>
        /// <param name="type">The weapon type you want to set the skill of.</param>
        /// <param name="skillLevel">The skill level to set for that weapon, ranging from 0 to 999. (A level out of range will max it out.)</param>
        public void SetSkillLevel(WeaponType type, int skillLevel)
        {
            Core.Natives.SetPlayerSkillLevel(this.ID, (int)type, skillLevel);
        }
        
        /// <summary>
        /// Shows a menu to the player.
        /// </summary>
        /// <param name="menu">The menu to show.</param>
        public void ShowMenu(Menu menu)
        {
            Core.Natives.ShowMenuForPlayer(menu.ID, this.ID);
        }

        /// <summary>
        /// Spawns or respawns the player with the given SpawnInfo.
        /// </summary>
        public void Spawn()
        {
            Core.Natives.SpawnPlayer(this.ID);
        }

        #endregion
    };
};