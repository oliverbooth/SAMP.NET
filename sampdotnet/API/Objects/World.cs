
using System;
namespace SAMP.API
{
    public class World
    {
        #region Class Variables

        private static bool _bTirePopping = true;
        private static bool _bInteriorWeapons = true;
        private static bool _bInteriorEnterExits = true;
        private static float _fNameTagDrawDistance = 70f;
        private static float _fGlobalChatRadius = 0.0f;
        private static float _fGravity = 0.008f;
        private static float _fPlayerMarkerRadius = 0.0f;
        private static int _nWeather = 0;
        private static int _nTime = 0;

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets or sets whether the usage of weapons in interiors is allowed.
        /// </summary>
        public static bool InteriorWeapons
        {
            get { return _bInteriorWeapons; }
            set { _bInteriorWeapons = value; Core.Natives.AllowInteriorWeapons(value ? 1 : 0); }
        }

        /// <summary>
        /// Gets or sets the radius limitation for chat (i.e. only players within the giving distance will see their message in chat.)
        /// Also changes the distance at which a player can see other players on the map at the same distance.
        /// </summary>
        public static float GlobalChatRadius
        {
            get { return _fGlobalChatRadius; }
            set { _fGlobalChatRadius = value; Core.Natives.LimitGlobalChatRadius(value); }
        }

        /// <summary>
        /// Gets or sets the gravity for all players.
        /// </summary>
        /// <remarks>Default gravity is 0.008.</remarks>
        public static float Gravity
        {
            get { return _fGravity; }
            set { _fGravity = value; Core.Natives.SetGravity(value); }
        }

        /// <summary>
        /// Gets or sets the maximum distance to display the names of players.
        /// </summary>
        public static float NameTagDrawDistance
        {
            get { return _fNameTagDrawDistance; }
            set { _fNameTagDrawDistance = value; Core.Natives.SetNameTagDrawDistance(value); }
        }

        /// <summary>
        /// Gets or sets the player marker radius.
        /// </summary>
        public static float PlayerMarkerRadius
        {
            get { return _fPlayerMarkerRadius; }
            set { _fPlayerMarkerRadius = value; Core.Natives.LimitPlayerMarkerRadius(value); }
        }

        /// <summary>
        /// Gets or sets the world time to a specific hour.
        /// </summary>
        public static int Time
        {
            get { return _nTime; }
            set { _nTime = value; Core.Natives.SetWorldTime(value); }
        }

        #pragma warning disable 618
        [Obsolete("This property was removed in SA-MP 0.3. Tire popping is enabled by default.")]
        /// <summary>
        /// Gets or sets the possibility of tire popping.
        /// </summary>
        public static bool TirePopping
        {
            get { return _bTirePopping; }
            set { _bTirePopping = value; Core.Natives.EnableTirePopping(value ? 1 : 0); }
        }
        #pragma warning restore 618

        /// <summary>
        /// Gets or sets the world weather for all players.
        /// </summary>
        public static int Weather
        {
            get { return _nWeather; }
            set { _nWeather = value; Core.Natives.SetWeather(value); }
        }

        /// <summary>
        /// Gets or sets whether the interior entrances/exits (the yellow object outside and inside each door) are enabled.
        /// </summary>
        public static bool InteriorEnterExits
        {
            get { return _bInteriorEnterExits; }
            set
            {
                _bInteriorEnterExits = value;

                // Check the value was true. We don't want to call the function
                // if they didn't intend it to be true.
                if(value)
                    Core.Natives.UsePlayerPedAnims();
            }
        }

        #endregion

        #region Public Methods (also they're static)

        /// <summary>
        /// Creates an object.
        /// </summary>
        /// <param name="model">The model you want to use.</param>
        /// <param name="position">The position at which to create the object.</param>
        /// <param name="rotation">The rotation at which to create the object.</param>
        /// <param name="drawDistance">The distance that San Andreas renders objects. 0.0 will cause objects to render at their default distances. 300.0 is the usable maximum.</param>
        /// <returns>Returns the ID of the object that was created.</returns>
        public static int CreateObject(int model, Vector3 position, Vector3 rotation, float drawDistance = 0.0f)
        {
            return Core.Natives.CreateObject(model, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, drawDistance);
        }

        /// <summary>
        /// Adds an object to the game in a pickupable form.
        /// </summary>
        /// <param name="model">The pickup model.</param>
        /// <param name="type">The pickup type.</param>
        /// <param name="position">The position.</param>
        /// <param name="virtualworld">The virtual world.</param>
        /// <returns>Returns the ID of the created pickup.</returns>
        public static int CreatePickup(int model, int type, Vector3 position, int virtualworld = -1)
        {
            int ret = Core.Natives.CreatePickup(model, type, position.X, position.Y, position.Z, virtualworld);
            if(ret == -1)
                throw Core.Exceptions.PickupMaxLimit;
            return ret;
        }

        /// <summary>
        /// Creates an explosion at the specified position.
        /// </summary>
        /// <param name="position">The position of the explosion.</param>
        /// <param name="type">The type of explosion.</param>
        /// <param name="radius">The explosion radius</param>
        /// <remarks>
        /// Important Note: Explosions are shown to all players, in all interiors and virtual worlds. There is currently no getting around this.
        /// Note: There is a limit as to how many explosions can be seen at once by a client. This is roughly 10.
        /// </remarks>
        public static void Explosion(Vector3 position, int type, float radius)
        {
            Core.Natives.CreateExplosion(position.X, position.Y, position.Z, type, radius);
        }

        /// <summary>
        /// Disables the nametag Line-Of-Sight checking so players can see nametags through objects.
        /// </summary>
        public static void DisableNameTagLOS()
        {
            Core.Natives.DisableNameTagLOS();
        }

        /// <summary>
        /// Spawns a SAMP.API.Vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle to spawn.</param>
        /// <param name="position">The position to spawn the vehicle.</param>
        /// <param name="angle">The facing angle of the vehicle.</param>
        public static void SpawnVehicle(Vehicle vehicle, Vector3 position, float angle)
        {
            vehicle.ID = Core.Natives.CreateVehicle(vehicle.Model, position.X, position.Y, position.Z, vehicle.Angle, vehicle.PrimaryColor, vehicle.SecondaryColor, vehicle.RespawnDelay);
            vehicle.Angle = angle;
            Vehicle.vehicleStore.Add(vehicle.ID, vehicle);
        }

        /// <summary>
        /// Sends a message to all players connected, specifying the message the players will receive. This is a multiple-user equivalent of Player.SendMessage().
        /// </summary>
        /// <param name="message">The string of text you would like to send.</param>
        /// <seealso cref="Player.SendMessage"/>
        public static void SendMessageToAll(string message)
        {
            SendMessageToAll(message, Color.White);
        }

        /// <summary>
        /// Sends a message to all players connected, specifying both the message the players will receive as the colour in which the message should show up. This is a multiple-user equivalent of Player.SendMessage().
        /// </summary>
        /// <param name="message">The string of text you would like to send.</param>
        /// <param name="color">The color it should be in. This overload supports HEX notation.</param>
        /// <seealso cref="Player.SendMessage"/>
        public static void SendMessageToAll(string message, uint color)
        {
            SendMessageToAll(message, Color.FromArgb(color));
        }

        /// <summary>
        /// Sends a message to all players connected, specifying both the message the players will receive as the colour in which the message should show up. This is a multiple-user equivalent of Player.SendMessage().
        /// </summary>
        /// <param name="message">The string of text you would like to send.</param>
        /// <param name="color">The color it should be in. This overload supports a SAMP.Color.</param>
        /// <seealso cref="Player.SendMessage"/>
        public static void SendMessageToAll(string message, Color color)
        {
            Core.Natives.SendClientMessageToAll(color.ToArgb(), message);
        }

        #endregion
    };
};