
namespace SAMP.API {
	/// <summary>
	/// Weapon state.
	/// </summary>
	public enum WeaponState : int {
		Unknown     = -1,
		NoBullets   = 0,
		LastBullet  = 1,
		MoreBullets = 2,
		Reloading   = 3
	};
};
