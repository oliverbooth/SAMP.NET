using System;

namespace SAMP.API.EventData
{
	public class PlayerEnterVehicleEventArgs : EventArgs
	{
		#region Class Variables

		private Vehicle _qVehicle;
		private bool _bIsPassenger;

		#endregion

		#region Constructor

		/// <summary>
		/// Creates a new PlayerEnterVehicleEventArgs object.
		/// </summary>
		/// <param name="vehicle">The vehicle the player is attempting to enter.</param>
		/// <param name="passenger">True = Driver, False = Passenger.</param>
		public PlayerEnterVehicleEventArgs(Vehicle vehicle, bool passenger)
		{
			_qVehicle = vehicle;
			_bIsPassenger = passenger;
		}

		#endregion

		#region Accessors & Mutators

		/// <summary>
		/// Gets whether or not the player was entering as a driver.
		/// </summary>
		public bool Driver
		{
			get { return !_bIsPassenger; }
		}

		/// <summary>
		/// Gets whether or not the player was entering as a passenger.
		/// </summary>
		public bool Passenger
		{
			get { return _bIsPassenger; }
		}

		/// <summary>
		/// Gets the vehicle the player is attempting to enter.
		/// </summary>
		public Vehicle Vehicle
		{
			get { return _qVehicle; }
		}

		#endregion
	};
};