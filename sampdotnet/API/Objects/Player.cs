using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SAMP.API
{
    public class Player : Core.IWorldEntity, Core.ICountable
    {
        #region Class Variables

        private bool _bFindZOnPosChange;
        private int _nPlayerID;
        private int _nSeat;
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
        /// Gets or sets the player's skin.
        /// </summary>
        public int Skin
        {
            get
            {
                return Core.Natives.GetPlayerSkin(this.ID);
            }
            set
            {
                Core.Natives.SetPlayerSkin(this.ID, value);
            }
        }

        /// <summary>
        /// Gets the SpawnInfo of this player.
        /// </summary>
        public SpawnInfo SpawnInfo
        {
            get { return _qSpawnInfo; }
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
        #region OnPickupPickUp
        public delegate void OnPickUpPickupHandler(object sender, EventData.PlayerPickUpPickupEventArgs e);
        public static event OnPickUpPickupHandler OnPickUpPickup;

        internal void _OnPickupPickUp(int pickupid)
        {
            EventData.PlayerPickUpPickupEventArgs args = new EventData.PlayerPickUpPickupEventArgs(pickupid);
            try { OnPickUpPickup(this, args); }
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

        #endregion
    };
};