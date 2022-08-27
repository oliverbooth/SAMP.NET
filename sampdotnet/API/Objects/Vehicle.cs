using System.Collections;

namespace SAMP.API
{
    public class Vehicle : Core.IWorldEntity, Core.ICountable
    {
        #region Class Variables

        private int
            _nId = -1,
            _nModel,
            _nColor1,
            _nColor2,
            _nRespawn;
        private float _fAngle = 0f;
        private Vector3 _qPosition = Vector3.Zero;
        internal static Hashtable vehicleStore = new Hashtable();

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new SAMP.API.Vehicle to be spawned with World.SpawnVehicle.
        /// </summary>
        /// <param name="modelid">The model for the vehicle.</param>
        /// <param name="color1">The primary color ID.</param>
        /// <param name="color2">The secondary color ID.</param>
        /// <param name="respawn_delay">The delay until the car is respawned without a driver in seconds.</param>
        public Vehicle(int modelid, int color1, int color2, int respawn_delay)
        {
            _nModel = modelid;
            _nColor1 = color1;
            _nColor2 = color2;
            _nRespawn = respawn_delay;
        }

        #endregion

        #region Events, Delegates and Method Calls

        #region OnSpawn
        public delegate void OnSpawnHandler(object sender, System.EventArgs e);
        public static event OnSpawnHandler OnSpawn;

        internal void _OnSpawn()
        {
            try { OnSpawn(this, null); }
            catch { }
        }
        #endregion
        #region OnDeath
        public delegate void OnDeathHandler(object sender, System.EventArgs e);
        public static event OnDeathHandler OnDeath;

        internal void _OnDeath(int killerid)
        {
            EventData.VehicleDeathEventArgs args = new EventData.VehicleDeathEventArgs(Player.Get(killerid));
            try { OnDeath(this, args); }
            catch { }
        }
        #endregion
        #region OnStreamIn
        public delegate void OnStreamInHandler(object sender, EventData.VehicleStreamEventArgs e);
        public static event OnStreamInHandler OnStreamIn;

        internal void _OnStreamIn(int forplayerid)
        {
            EventData.VehicleStreamEventArgs args = new EventData.VehicleStreamEventArgs(Player.Get(forplayerid));
            try { OnStreamIn(this, args); }
            catch { }
        }
        #endregion
        #region OnStreamOut
        public delegate void OnStreamOutHandler(object sender, EventData.VehicleStreamEventArgs e);
        public static event OnStreamOutHandler OnStreamOut;

        internal void _OnStreamOut(int forplayerid)
        {
            EventData.VehicleStreamEventArgs args = new EventData.VehicleStreamEventArgs(Player.Get(forplayerid));
            try { OnStreamOut(this, args); }
            catch { }
        }
        #endregion

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the model ID of this SAMP.API.Vehicle.
        /// </summary>
        public int Model
        {
            get
            {
                if(!this.ID.Equals(-1))
                    _nModel = Core.Natives.GetVehicleModel(this.ID);
                return _nModel;
            }
        }

        /// <summary>
        /// Gets the primary color of this SAMP.API.Vehicle.
        /// </summary>
        public int PrimaryColor
        {
            get { return _nColor1; }
            set
            {
                _nColor1 = value;

                if(!this.ID.Equals(-1))
                    Core.Natives.ChangeVehicleColor(this.ID, value, this.SecondaryColor);
            }
        }

        /// <summary>
        /// Gets the secondary color of this SAMP.API.Vehicle.
        /// </summary>
        public int SecondaryColor
        {
            get { return _nColor2; }
            set
            {
                _nColor2 = value;

                if(!this.ID.Equals(-1))
                    Core.Natives.ChangeVehicleColor(this.ID, this.PrimaryColor, value);
            }
        }

        /// <summary>
        /// Gets the respawn delay of this SAMP.API.Vehicle.
        /// </summary>
        public int RespawnDelay { get { return _nRespawn; } }

        /// <summary>
        /// Gets the vehicle ID.
        /// </summary>
        public int ID { get { return _nId; } internal set { _nId = value; } }

        /// <summary>
        /// Gets or sets the vehicle's facing angle.
        /// </summary>
        public float Angle
        {
            get
            {
                if(!this.ID.Equals(-1))
                    Core.Natives.GetVehicleZAngle(this.ID, ref _fAngle);

                return _fAngle;
            }
            set
            {
                _fAngle = value;

                if(!this.ID.Equals(-1))
                    Core.Natives.SetVehicleZAngle(_nId, value);
            }
        }

        /// <summary>
        /// Gets or sets the vehicle's health.
        /// </summary>
        public float Health
        {
            get {
                float health = 0f;

                if(!this.ID.Equals(-1))
                    Core.Natives.GetVehicleHealth(this.ID, ref health);

                return health; }
            set
            {
                if(!this.ID.Equals(-1))
                    Core.Natives.SetVehicleHealth(this.ID, value);
            }
        }

        /// <summary>
        /// Gets whether the vehicle is occupied by a player.
        /// </summary>
        public bool Occupied
        {
            get
            {
                foreach(Player player in Player.All)
                {
                    if(player.IsInVehicle(this))
                        return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Gets or sets the vehicle's position.
        /// </summary>
        public Vector3 Position
        {
            get
            {
                float
                    x = 0f,
                    y = 0f,
                    z = 0f;

                if(!this.ID.Equals(-1))
                    Core.Natives.GetVehiclePos(this.ID, ref x, ref y, ref z);

                return new Vector3(x, y, z);
            }
            set
            {
                _qPosition = value;

                if(!this.ID.Equals(-1))
                    Core.Natives.SetVehiclePos(this.ID, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets or sets the trailer attatched to this vehicle.
        /// </summary>
        public Vehicle Trailer
        {
            get
            {
                if(!this.ID.Equals(-1))
                    return Vehicle.Get(Core.Natives.GetVehicleTrailer(this.ID));
                else
                    return null;
            }
            set
            {
                if(!this.ID.Equals(-1))
                    if(value == null)
                        Core.Natives.DetachTrailerFromVehicle(this.ID);
                    else
                        Core.Natives.AttachTrailerToVehicle(value.ID, this.ID);
            }
        }

        #endregion

        #region Public Methods

        internal static Vehicle Get(int vehicleid)
        {
            // Iterate through the vehicle collection store
            foreach(DictionaryEntry d in vehicleStore)
            {
                if(d.Key.Equals(vehicleid))
                    return (Vehicle)d.Value;
            }

            // The vehicle doesn't exist.
            return null;
        }

        /// <summary>
        /// Adds a component to the vehicle.
        /// </summary>
        /// <param name="componentid">The componentid that needs to be added to the vehicle.</param>
        /// <remarks>Important Note: Using an invalid componentid crashes the game.</remarks>
        public void AddComponent(int componentid)
        {
            Core.Natives.AddVehicleComponent(this.ID, componentid);
        }

        /// <summary>
        /// Destroys the vehicle.
        /// </summary>
        public void Destroy()
        {
            Core.Natives.DestroyVehicle(this.ID);
            vehicleStore.Remove(this.ID);
        }

        /// <summary>
        /// Determines the installed component from a vehicle in a specific slot.
        /// </summary>
        /// <param name="slot">The component slot to check for components.</param>
        /// <returns>Returns the ID of the component installed in the specified slot.</returns>
        public int GetComponentInSlot(int slot)
        {
            return Core.Natives.GetVehicleComponentInSlot(this.ID, slot);
        }

        /// <summary>
        /// Determines what type of component (the slot) of a component id Find out what type of component a certain ID is.
        /// </summary>
        /// <param name="component">The component ID to check.</param>
        /// <returns>Returns the component slot of the specified component.</returns>
        public static ComponentSlot GetComponentType(int component)
        {
            return (ComponentSlot)Core.Natives.GetVehicleComponentType(component);
        }

        /// <summary>
        /// Removes a component from the vehicle.
        /// </summary>
        /// <param name="componentid">The componentid that needs to be removed from the vehicle.</param>
        public void RemoveComponent(int componentid)
        {
            Core.Natives.RemoveVehicleComponent(this.ID, componentid);
        }

        #endregion
    };
};