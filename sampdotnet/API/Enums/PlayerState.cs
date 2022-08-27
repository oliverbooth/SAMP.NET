
namespace SAMP.API {
	/// <summary>
	/// Player state.
	/// </summary>
	public enum PlayerState : int {
		None                  = 0,
		OnFoot                = 1,
		Driver                = 2,
		Passenger             = 3,
		ExitVehicle           = 4,
		EnterVehicleDriver    = 5,
		EnterVehiclePassenger = 6,
		Wasted                = 7,
		Spawned               = 8,
		Spectating            = 9,
	};
};
