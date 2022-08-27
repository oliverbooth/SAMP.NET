
namespace SAMP.API {
	public class SpawnInfo {
		#region Class Variables
		
		private Player
			m_qPlayer;
		private Skin
			m_qSkin;
		private Vector3
			m_qPos;
		private int
			m_iTeam,
			m_iWeapon1, m_nWeapon1Ammo,
			m_iWeapon2, m_nWeapon2Ammo,
			m_iWeapon3, m_nWeapon3Ammo;
		private float
			m_fpAngle = 0.0f;
		
		#endregion
		
		#region Constructor
		
		internal SpawnInfo(Player sender) {
			m_qPlayer = sender;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets or sets the spawn facing angle of the player.
		/// </summary>
		public float Angle {
			get {
				return this.m_fpAngle;
			} set {
				this.m_fpAngle = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the spawn position of the player.
		/// </summary>
		public Vector3 Position {
			get {
				return m_qPos;
			} set {
				m_qPos = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the skin of the player.
		/// </summary>
		public Skin Skin {
			get {
				return m_qSkin;
			} set {
				m_qSkin = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the team ID of the player.
		/// </summary>
		public int Team {
			get {
				return m_iTeam;
			} set {
				m_iTeam = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the primary spawn-weapon for the player.
		/// </summary>
		public int Weapon1 {
			get { return m_iWeapon1; }
			set { m_iWeapon1 = value; }
		}
		
		/// <summary>
		/// Gets or sets the amount of ammunition for the primary spawn-weapon.
		/// </summary>
		public int Weapon1Ammo {
			get { return m_nWeapon1Ammo; }
			set { m_nWeapon1Ammo = value; }
		}
		
		/// <summary>
		/// Gets or sets the secondary spawn-weapon for the player.
		/// </summary>
		public int Weapon2 {
			get { return m_iWeapon2; }
			set { m_iWeapon2 = value; }
		}
		
		/// <summary>
		/// Gets or sets the amount of ammunition for the secondary spawn-weapon.
		/// </summary>
		public int Weapon2Ammo {
			get { return m_nWeapon2Ammo; }
			set { m_nWeapon2Ammo = value; }
		}
		
		/// <summary>
		/// Gets or sets the third spawn-weapon for the player.
		/// </summary>
		public int Weapon3 {
			get { return m_iWeapon3; }
			set { m_iWeapon3 = value; }
		}
		
		/// <summary>
		/// Gets or sets the amount of ammunition for the third spawn-weapon.
		/// </summary>
		public int Weapon3Ammo {
			get { return m_nWeapon3Ammo; }
			set { m_nWeapon3Ammo = value; }
		}
		
		#endregion
		
		#region Public Methods
		
		/// <summary>
		/// Sends all buffered SpawnInfo to be updated.
		/// </summary>
		public void Flush() {
			Core.Natives.SetSpawnInfo(m_qPlayer.ID, Team, (int)Skin, Position.X, Position.Y, Position.Z, Angle, Weapon1, Weapon1Ammo, Weapon2, Weapon2Ammo, Weapon3, Weapon3Ammo);
		}
		
		#endregion
	};
};
