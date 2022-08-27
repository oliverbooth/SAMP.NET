
namespace SAMP.API
{
    public class PlayerCamera : Core.IWorldEntity
    {
        private int _playerid;

        /// <summary>
        /// Creates a new Camera object relating to a player.
        /// </summary>
        /// <param name="sender">The Player to attach to.</param>
        internal PlayerCamera(Player sender)
        {
            this._playerid = sender.ID;
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
                Core.Natives.GetPlayerCameraPos(_playerid, ref x, ref y, ref z);
                return new Vector3(x, y, z);
            }
            set
            {
                Core.Natives.SetPlayerCameraPos(_playerid, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets or sets the player's camera LookAt value in 3D space.
        /// </summary>
        /// <remarks>In 0.3a the camera front vector is available when player is inside a tank, S.W.A.T tank, fire truck, or on foot. Since 0.3b the camera data can be obtained when the player is in any vehicle.</remarks>
        /// <seealso cref="Position"/>
        public Vector3 LookAt
        {
            get
            {
                float
                    x = 0f,
                    y = 0f,
                    z = 0f;
                Core.Natives.GetPlayerCameraFrontVector(_playerid, ref x, ref y, ref z);
                return new Vector3(x, y, z);
            }
            set
            {
                Core.Natives.SetPlayerCameraLookAt(_playerid, value.X, value.Y, value.Z);
            }
        }

        /// <summary>
        /// Gets the current GTA camera mode for the player.
        /// <remarks>The camera modes are useful in determining whether a player is aiming, doing a passenger driveby etc.</remarks>
        /// </summary>
        public CameraMode Mode
        {
            get
            {
                return CameraMode.OnFootChase;
            }
        }
    };
};