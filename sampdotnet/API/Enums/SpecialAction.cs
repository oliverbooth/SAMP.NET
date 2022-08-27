
namespace SAMP.API {
	/// <summary>
	/// Special action.
	/// </summary>
	public enum SpecialAction : int {
		None             = 0,
		UseJetpack       = 2,
		Dance1           = 5,
		Dance2           = 6,
		Dance3           = 7,
		Dance4           = 8,
		HandsUp          = 10,
		UseCellPhone     = 11,
		Sitting          = 12,
		StopUseCellPhone = 13,
		
		Duck             = 1, // Can't be set
		EnterVehicle     = 3, // Can't be set
		ExitVehicle      = 4, // Can't be set
		Beer             = 20,
		Ciggy            = 21,
		Wine             = 22,
		Sprunk           = 23,
		Pissing          = 68,
		
		Cuffed           = 24
	};
};
