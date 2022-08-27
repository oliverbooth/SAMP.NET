
namespace SAMP.API
{
    public class SpawnInfo
    {
        #region Class Variables

        private Player _qPlayer;
        private int _nTeam;
        private Skin _qSkin;
        private Vector3 _qPos;
        private float _fAngle;
        private int _nWeapon1, _nWeapon1Ammo;
        private int _nWeapon2, _nWeapon2Ammo;
        private int _nWeapon3, _nWeapon3Ammo;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of SAMP.API.SpawnInfo.
        /// </summary>
        /// <param name="sender">The player whose spawn info is being affected.</param>
        internal SpawnInfo(Player sender)
        {
            _qPlayer = sender;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets or sets the spawn facing angle of the player.
        /// </summary>
        public float Angle
        {
            get { return _fAngle; }
            set { _fAngle = value; }
        }

        /// <summary>
        /// Gets or sets the spawn position of the player.
        /// </summary>
        public Vector3 Position
        {
            get { return _qPos; }
            set { _qPos = value; }
        }

        /// <summary>
        /// Gets or sets the Skin of the player.
        /// </summary>
        public Skin Skin
        {
            get { return _qSkin; }
            set { _qSkin = value; }
        }

        /// <summary>
        /// Gets or sets the team ID of the player.
        /// </summary>
        public int Team
        {
            get { return _nTeam; }
            set { _nTeam = value; }
        }

        /// <summary>
        /// Gets or sets the primary spawn-weapon for the player.
        /// </summary>
        public int Weapon1
        {
            get { return _nWeapon1; }
            set { _nWeapon1 = value; }
        }

        /// <summary>
        /// Gets or sets the amount of ammunition for the primary spawn-weapon.
        /// </summary>
        public int Weapon1Ammo
        {
            get { return _nWeapon1Ammo; }
            set { _nWeapon1Ammo = value; }
        }

        /// <summary>
        /// Gets or sets the secondary spawn-weapon for the player.
        /// </summary>
        public int Weapon2
        {
            get { return _nWeapon2; }
            set { _nWeapon2 = value; }
        }

        /// <summary>
        /// Gets or sets the amount of ammunition for the secondary spawn-weapon.
        /// </summary>
        public int Weapon2Ammo
        {
            get { return _nWeapon2Ammo; }
            set { _nWeapon2Ammo = value; }
        }

        /// <summary>
        /// Gets or sets the third spawn-weapon for the player.
        /// </summary>
        public int Weapon3
        {
            get { return _nWeapon3; }
            set { _nWeapon3 = value; }
        }

        /// <summary>
        /// Gets or sets the amount of ammunition for the third spawn-weapon.
        /// </summary>
        public int Weapon3Ammo
        {
            get { return _nWeapon3Ammo; }
            set { _nWeapon3Ammo = value; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sends all buffered SpawnInfo to be updated.
        /// </summary>
        public void Flush()
        {
            Core.Natives.SetSpawnInfo(_qPlayer.ID, Team, (int)Skin, Position.X, Position.Y, Position.Z, Angle, Weapon1, Weapon1Ammo, Weapon2, Weapon2Ammo, Weapon3, Weapon3Ammo);
        }

        #endregion
    };
};