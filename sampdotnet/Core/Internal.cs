using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using SAMP.API;

namespace SAMP.Core {
	internal class Internal {
		#region Class Variables
		
		public static int
			s_nDialogCounter   = 0;
		public static Hashtable
			s_qDialogResponses = new Hashtable();
		
		#endregion
		
		#region C++ Callbacks
		
		public static void OnGameModeInit() {
			GameMode._OnInit();
		}
		
		public static void OnGameModeExit() {
			GameMode._OnExit();
		}
		
		public static void OnPlayerConnect(int playerid) {
			// Instantiate the player
			// This, in turn, adds itself to the collection
			// Immediately call the OnConnect event.
			new Player(playerid)._OnConnect();
		}
		
		public static void OnPlayerDisconnect(int playerid, int reason) {
			Player.Get(playerid)._OnDisconnect(reason);
		}
		
		public static int OnPlayerSpawn (int playerid) {
			// Pre-define a variable for cancel
			bool bCancel = false;
			
			// Call event
			Player.Get(playerid)._OnSpawn(ref bCancel);
			
			// Return the cancel bool
			return bCancel ? 0 : 1;
		}
		
		public static void OnPlayerDeath(int playerid, int killerid, int reason) {
			Player.Get(playerid)._OnDeath(Player.Get(killerid), reason);
		}
		
		public static void OnVehicleSpawn(int vehicleid) {
			Vehicle.Get(vehicleid)._OnSpawn();
		}
		
		public static void OnVehicleDeath(int vehicleid, int killerid) {
			Vehicle.Get(vehicleid)._OnDeath(killerid);
		}
		
		public static int OnPlayerText(int playerid, string text) {
			return Player.Get(playerid)._OnText(text);
		}
		
		public static int OnPlayerCommandText(int playerid, string cmdtext) {
			// Pre-define a variable for cancel
			bool bHandled = false;
			
			// Call event
			Player.Get(playerid)._OnCommandText(cmdtext, ref bHandled);
			
			// Return the handled bool
			return bHandled ? 1 : 0;
		}
		
		public static int OnPlayerRequestClass(int playerid, int classid) {
			// Pre-define a variable for cancel
			bool cancel = false;
			
			// Call event
			Player.Get(playerid)._OnRequestClass(classid, ref cancel);
			
			// Return the cancel bool
			return cancel ? 0 : 1;
		}
		
		public static void OnPlayerEnterVehicle(int playerid, int vehicleid, int ispassenger) {
			Player.Get(playerid)._OnEnterVehicle(vehicleid, ispassenger == 1);
		}
		
		public static void OnPlayerExitVehicle(int playerid, int vehicleid) {
			Player.Get(playerid)._OnExitVehicle(vehicleid);
		}
		
		public static void OnPlayerStateChange(int playerid, int newstate, int oldstate) {
			Player.Get(playerid)._OnStateChange(newstate, oldstate);
		}
		
		public static void OnPlayerEnterCheckpoint (int playerid) {
			Player.Get(playerid)._OnEnterCheckpoint();
		}
		
		public static void OnPlayerLeaveCheckpoint(int playerid) {
			Player.Get(playerid)._OnLeaveCheckpoint();
		}
		
		public static void OnPlayerEnterRaceCheckpoint(int playerid) {
			Player.Get(playerid)._OnEnterRaceCheckpoint();
		}
		
		public static void OnPlayerLeaveRaceCheckpoint(int playerid) {
			Player.Get(playerid)._OnLeaveRaceCheckpoint();
		}
		
		public static int OnRconCommand(string cmd) {
			return Server._OnRconCommand(cmd);
		}
		
		public static int OnPlayerRequestSpawn(int playerid) {
			return Player.Get(playerid)._OnRequestSpawn();
		}
		
		public static void OnObjectMoved(int objectid) {
			// TODO: Implement
		}
		public static void OnPlayerObjectMoved(int playerid, int objectid) {
			// TODO: Implement
		}
		public static void OnPlayerPickUpPickup(int playerid, int pickupid) {
			Player.Get(playerid)._OnPickUpPickup(pickupid);
		}
		
		public static int OnVehicleMod(int playerid, int vehicleid, int componentid) {
			// TODO: Implement
			return 1;
		}
		public static void OnEnterExitModShop(int playerid, int enterexit, int interiorid) {
			Player.Get(playerid)._OnEnterExitModShop(enterexit, interiorid);
		}
		
		public static void OnVehiclePaintjob(int playerid, int vehicleid, int paintjobid) {
			// TODO: Implement
		}
		
		public static void OnVehicleRespray(int playerid, int vehicleid, int color1, int color2) {
			// TODO: Implement
		}
		public static void OnVehicleDamageStatusUpdate(int vehicleid, int playerid) {
			// TODO: Implement
		}
		
		public static void OnUnoccupiedVehicleUpdate(int vehicleid, int playerid, int passenger_seat) {
			// TODO: Implement
		}
		public static void OnPlayerSelectedMenuRow(int playerid, int row) {
			// TODO: Implement
		}
		
		public static void OnPlayerExitedMenu(int playerid) {
			// TODO: Implement
		}
		
		public static void OnPlayerInteriorChange(int playerid, int newinteriorid, int oldinteriorid) {
			// TODO: Implement
		}
		
		public static int OnPlayerKeyStateChange(int playerid, int newkeys, int oldkeys) {
			// TODO: Implement
			return 1;
		}
		
		public static void OnRconLoginAttempt(string ip, string password, int success) {
			Server._OnRconLoginAttempt(ip, password, success);
		}
		
		public static int OnPlayerUpdate(int playerid) {
			return Player.Get(playerid)._OnUpdate ();
		}
		
		public static void OnPlayerStreamIn(int playerid, int forplayerid) {
			Player.Get(playerid)._OnStreamIn(forplayerid);
		}
		
		public static void OnPlayerStreamOut(int playerid, int forplayerid) {
			Player.Get(playerid)._OnStreamOut(forplayerid);
		}
		
		public static void OnVehicleStreamIn(int vehicleid, int forplayerid) {
			Vehicle.Get(vehicleid)._OnStreamIn(forplayerid);
		}

		public static void OnVehicleStreamOut(int vehicleid, int forplayerid) {
			Vehicle.Get(vehicleid)._OnStreamOut(forplayerid);
		}
		
		public static int OnDialogResponse(int playerid, int dialogid, int response, int listitem, string inputtext) {
			// Pre-define a variable for pass-on
			bool bPasson = false;
			
			// Call event
			Player.Get(playerid)._OnDialogResponse(dialogid, response, listitem, inputtext, ref bPasson);
			
			// Return the pass-on int
			return bPasson ? 0 : 1;
		}
		
		public static void OnPlayerTakeDamage(int playerid, int issuerid, float amount, int weaponid) {
			// TODO: Implement
		}
		
		public static void OnPlayerGiveDamage(int playerid, int damagedid, float amount, int weaponid) {
			// TODO: Implement
		}
		
		public static void OnPlayerClickMap(int playerid, float fX, float fY, float fZ) {
			Player.Get(playerid)._OnClickMap(fX, fY, fZ);
		}
		
		public static int OnPlayerClickTextDraw (int playerid, int clickedid) {
			// TODO: Implement
			return 0;
		}
		
		public static void OnPlayerClickPlayerTextDraw(int playerid, int playertextid) {
			// TODO: Implement
		}
		
		public static void OnPlayerClickPlayer(int playerid, int clickedplayerid, int source) {
			// TODO: Implement
		}
		
		public static void OnPlayerEditObject(int playerid, int playerobject, int objectid, int response, float fX, float fY, float fZ, float fRotX, float fRotY, float fRotZ) {
			// TODO: Implement
		}
		
		public static void OnPlayerEditAttachedObject(int playerid, int response, int index, int modelid, int boneid, float fOffsetX, float fOffsetY, float fOffsetZ, float fRotX, float fRotY, float fRotZ, float fScaleX, float fScaleY, float fScaleZ) {
			// TODO: Implement
		}
		
		public static void OnPlayerSelectObject(int playerid, int type, int objectid, int modelid, float fX, float fY, float fZ) {
			// TODO: Implement
		}
		
		#endregion
		
		public static string ByteArrayToString(byte[] arr) {
			return Encoding.UTF8.GetString(arr);
		}
		
		public static string IntPtrToString(IntPtr pointer) {
			return Marshal.PtrToStringAuto(pointer);
		}
	};
};
