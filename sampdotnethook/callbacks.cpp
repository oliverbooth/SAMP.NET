#include "callbacks.h"
#include "Mono.h"

#pragma region OnGameModeInit()
// PAWN native: native CBOnGameModeInit();
cell AMX_NATIVE_CALL CBOnGameModeInit(AMX *amx, cell *params) {
	g_Mono->callMethod("Internal:OnGameModeInit", NULL);
	return 1;
}
#pragma endregion
#pragma region OnGameModeExit()
// PAWN native: native CBOnGameModeExit();
cell AMX_NATIVE_CALL CBOnGameModeExit(AMX *amx, cell *params) {
	g_Mono->callMethod("Internal:OnGameModeExit", NULL);
	return 1;
}
#pragma endregion
#pragma region OnPlayerConnect(playerid)
// PAWN native: native CBOnPlayerConnect(playerid);
cell AMX_NATIVE_CALL CBOnPlayerConnect(AMX *amx, cell *params) {
	// Create variables to store the arguments
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	// Call the method
	g_Mono->callMethod("Internal:OnPlayerConnect", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerDisconnect(playerid, reason)
// PAWN native: native CBOnPlayerDisconnect(playerid, reason);
cell AMX_NATIVE_CALL CBOnPlayerDisconnect(AMX *amx, cell *params) {
	// Create variables to store the arguments
	void *args[2];
	int
		playerid = params[1],
		reason   = params[2];
	args[0] = &playerid;
	args[1] = &reason;
	
	// Call the method
	g_Mono->callMethod("Internal:OnPlayerDisconnect", args);

	return 1;
}
#pragma endregion
#pragma region OnPlayerSpawn(playerid)
// PAWN native: native CBOnPlayerSpawn(playerid);
cell AMX_NATIVE_CALL CBOnPlayerSpawn(AMX *amx, cell *params) {
	// Create variables to store the arguments
	void *args[1];
	int playerid	= params[1];
	args[0]			= &playerid;

	// Call the method and return result
	return g_Mono->callReturn("Internal:OnPlayerSpawn", args);
}
#pragma endregion
#pragma region OnPlayerDeath(playerid, killerid, reason)
// PAWN native: native CBOnPlayerDeath(playerid, killerid, reason);
cell AMX_NATIVE_CALL CBOnPlayerDeath(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid = params[1],
		killerid = params[2],
		reason   = params[3];
	args[0] = &playerid;
	args[1] = &killerid;
	args[2] = &reason;
	
	g_Mono->callMethod("Internal:OnPlayerDeath", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleSpawn(vehicleid)
// PAWN native: native CBOnVehicleSpawn(vehicleid);
cell AMX_NATIVE_CALL CBOnVehicleSpawn(AMX *amx, cell *params) {
	void *args[1];
	int vehicleid = params[1];
	args[0] = &vehicleid;
	
	g_Mono->callMethod("Internal:OnVehicleSpawn", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleDeath(vehicleid, killerid)
// PAWN native: native CBOnVehicleDeath(vehicleid, killerid);
cell AMX_NATIVE_CALL CBOnVehicleDeath(AMX *amx, cell *params) {
	void *args[2];
	int
		vehicleid = params[1],
		killerid  = params[2];
	args[0] = &vehicleid;
	args[1] = &killerid;
	
	g_Mono->callMethod("Internal:OnVehicleDeath", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerText(playerid, text[])
// PAWN native: native CBOnPlayerText(playerid, text[]);
cell AMX_NATIVE_CALL CBOnPlayerText(AMX *amx, cell *params) {
	// Define some variables
	int
		len = NULL,
		ret = NULL;
	cell *addr = NULL;
	
	// Get address and string length
	amx_GetAddr(amx, params[2], &addr);
	amx_StrLen(addr, &len);

	if(len) {
		// Create a buffer variable
		char *message = new char[++len];

		// Get the string and store it in the bufer
		amx_GetString(message, addr, 0, len);
		

		// Create variables to store the arguments
		void *args[2];
		int playerid = params[1];
		args[0] = &playerid;
		args[1] = g_Mono->createString(message);

		// Call method and return result
		ret = g_Mono->callReturn("Internal:OnPlayerText", args);

		// Delete message from memory
		delete[] message;
	}

	return ret;
}
#pragma endregion
#pragma region OnPlayerCommandText(playerid, cmdtext[])
// PAWN native: native CBOnPlayerCommandText(playerid, cmdtext[]);
cell AMX_NATIVE_CALL CBOnPlayerCommandText(AMX *amx, cell *params) {
	// Define some variables
	int
		len = NULL,
		ret = NULL;
	cell *addr = NULL;

	// Get address and string length
	amx_GetAddr(amx, params[2], &addr);
	amx_StrLen(addr, &len);

	if(len) {
		// Create a buffer variable
		char *cmdtext = new char[++len];

		// Get the string and store it in the bufer
		amx_GetString(cmdtext, addr, 0, len);

		// Create variables to store the arguments
		void *args[2];
		int playerid = params[1];
		args[0] = &playerid;
		args[1] = g_Mono->createString(cmdtext);

		// Call the method
		ret = g_Mono->callReturn("Internal:OnPlayerCommandText", args);

		// Remove cmdtext from memory
		delete[] cmdtext;
	}

	// Return 'ret'
	return ret;
}
#pragma endregion
#pragma region OnPlayerRequestClass(playerid, classid)
// PAWN native: native CBOnPlayerRequestClass(playerid, classid);
cell AMX_NATIVE_CALL CBOnPlayerRequestClass(AMX *amx, cell *params) {
	// Create variables to store the arguments
	void *args[2];
	int
		playerid = params[1],
		classid  = params[2];
	args[0] = &playerid;
	args[1] = &classid;
	
	// Call the method and return result
	return g_Mono->callReturn("Internal:OnPlayerRequestClass", args);
}
#pragma endregion
#pragma region OnPlayerEnterVehicle(playerid, vehicleid, ispassenger)
// PAWN native: native CBOnPlayerEnterVehicle(playerid, vehicleid, ispassenger);
cell AMX_NATIVE_CALL CBOnPlayerEnterVehicle(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid    = params[1],
		vehicleid   = params[2],
		ispassenger = params[3];
	args[0] = &playerid;
	args[1] = &vehicleid;
	args[2] = &ispassenger;
	
	g_Mono->callMethod("Internal:OnPlayerEnterVehicle", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerExitVehicle(playerid, vehicleid)
// PAWN native: native CBOnPlayerExitVehicle(playerid, vehicleid);
cell AMX_NATIVE_CALL CBOnPlayerExitVehicle(AMX *amx, cell *params) {
	void *args[1];
	int
		playerid  = params[1],
		vehicleid = params[2];
	args[0] = &playerid;
	args[1] = &vehicleid;
	
	g_Mono->callMethod("Internal:OnPlayerExitVehicle", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerStateChange(playerid, newstate, oldstate)
// PAWN native: native CBOnPlayerStateChange(playerid, newstate, oldstate);
cell AMX_NATIVE_CALL CBOnPlayerStateChange(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid = params[1],
		newstate = params[2],
		oldstate = params[3];
	args[0] = &playerid;
	args[1] = &newstate;
	args[2] = &oldstate;
	
	g_Mono->callMethod("Internal:OnPlayerStateChange", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerEnterCheckpoint(playerid)
// PAWN native: native CBOnPlayerEnterCheckpoint(playerid);
cell AMX_NATIVE_CALL CBOnPlayerEnterCheckpoint(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	g_Mono->callMethod("Internal:OnPlayerEnterCheckpoint", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerLeaveCheckpoint(playerid)
// PAWN native: native CBOnPlayerLeaveCheckpoint(playerid);
cell AMX_NATIVE_CALL CBOnPlayerLeaveCheckpoint(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	g_Mono->callMethod("Internal:OnPlayerLeaveCheckpoint", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerEnterRaceCheckpoint(playerid)
// PAWN native: native CBOnPlayerEnterRaceCheckpoint(playerid);
cell AMX_NATIVE_CALL CBOnPlayerEnterRaceCheckpoint(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	g_Mono->callMethod("Internal:OnPlayerEnterRaceCheckpoint", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerLeaveRaceCheckpoint(playerid)
// PAWN native: native CBOnPlayerLeaveRaceCheckpoint(playerid);
cell AMX_NATIVE_CALL CBOnPlayerLeaveRaceCheckpoint(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	g_Mono->callMethod("Internal:OnPlayerLeaveRaceCheckpoint", args);
	return 1;
}
#pragma endregion
#pragma region OnRconCommand(cmd[])
// PAWN native: native CBOnRconCommand(cmd[]);
cell AMX_NATIVE_CALL CBOnRconCommand(AMX *amx, cell *params) {
	// Define some variables
	int
		len = NULL,
		ret = NULL;
	cell *addr = NULL;
	
	// Get address and string length
	amx_GetAddr(amx, params[1], &addr);
	amx_StrLen(addr, &len);


	if(len) {
		// Create a buffer variable
		char *cmd = new char[++len];

		// Get the string and store it in the bufer
		amx_GetString(cmd, addr, 0, len);
		

		// Create variables to store the arguments
		void *args[1];
		args[0] = g_Mono->createString(cmd);

		// Call method and return result
		ret = g_Mono->callReturn("Internal:OnRconCommand", args);

		// Delete message from memory
		delete[] cmd;
	}

	return ret;
}
#pragma endregion
#pragma region OnPlayerRequestSpawn(playerid)
// PAWN native: native CBOnPlayerRequestSpawn(playerid);
cell AMX_NATIVE_CALL CBOnPlayerRequestSpawn(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	return g_Mono->callReturn("Internal:OnPlayerRequestSpawn", args);
}
#pragma endregion
#pragma region OnObjectMoved(objectid)
// PAWN native: native CBOnObjectMoved(objectid);
cell AMX_NATIVE_CALL CBOnObjectMoved(AMX *amx, cell *params) {
	// Set arguments
	void *args[1];
	int objectid	= params[1];
	args[0]			= &objectid;

	// Call method
	g_Mono->callMethod("Internal:OnObjectMoved", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerObjectMoved(playerid, objectid)
// PAWN native: native CBOnPlayerObjectMoved(playerid, objectid);
cell AMX_NATIVE_CALL CBOnPlayerObjectMoved(AMX *amx, cell *params) {
	void *args[2];
	int
		playerid = params[1],
		objectid = params[2];
	args[0] = &playerid;
	args[1] = &objectid;
	
	g_Mono->callMethod("Internal:OnPlayerObjectMoved", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerPickUpPickup(playerid, pickupid)
// PAWN native: native CBOnPlayerPickUpPickup(playerid, pickupid);
cell AMX_NATIVE_CALL CBOnPlayerPickUpPickup(AMX *amx, cell *params) {
	void *args[1];
	int
		playerid = params[1],
		pickupid = params[2];
	args[0] = &playerid;
	args[1] = &pickupid;
	
	g_Mono->callMethod("Internal:OnPlayerPickUpPickup", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleMod(playerid, vehicleid, componentid)
// PAWN native: native CBOnVehicleMod(playerid, vehicleid, componentid);
cell AMX_NATIVE_CALL CBOnVehicleMod(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid    = params[1],
		vehicleid   = params[2],
		componentid = params[3];
	args[0] = &playerid;
	args[1] = &vehicleid;
	args[2] = &componentid;
	
	return g_Mono->callReturn("Internal:OnVehicleMod", args);
}
#pragma endregion
#pragma region OnEnterExitModShop(playerid, enterexit, interiorid)
// PAWN native: native CBOnEnterExitModShop(playerid, enterexit, interiorid);
cell AMX_NATIVE_CALL CBOnEnterExitModShop(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid	= params[1],
		enterexit	= params[2],
		interiorid	= params[3];

	// Store the arguments
	args[0] = &playerid;
	args[1] = &enterexit;
	args[2] = &interiorid;

	return g_Mono->callReturn("Internal:OnEnterExitModShop", args);
}
#pragma endregion
#pragma region OnVehiclePaintjob(playerid, vehicleid, paintjobid)
// PAWN native: native CBOnVehiclePaintjob(playerid, vehicleid, paintjobid);
cell AMX_NATIVE_CALL CBOnVehiclePaintjob(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid   = params[1],
		vehicleid  = params[2],
		paintjobid = params[3];
	args[0] = &playerid;
	args[1] = &vehicleid;
	args[2] = &paintjobid;
	
	g_Mono->callMethod("Internal:OnVehiclePaintjob", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleRespray(playerid, vehicleid, color1, color2)
// PAWN native: native CBOnVehicleRespray(playerid, vehicleid, color1, color2);
cell AMX_NATIVE_CALL CBOnVehicleRespray(AMX *amx, cell *params) {
	void *args[4];
	int
		playerid  = params[1],
		vehicleid = params[2],
		color1    = params[3],
		color2    = params[4];
	args[0] = &playerid;
	args[1] = &vehicleid;
	args[2] = &color1;
	args[3] = &color2;
	
	g_Mono->callMethod("Internal:OnVehicleRespray", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleDamageStatusUpdate(vehicleid, playerid)
// PAWN native: native CBOnVehicleDamageStatusUpdate(vehicleid, playerid);
cell AMX_NATIVE_CALL CBOnVehicleDamageStatusUpdate(AMX *amx, cell *params) {
	void *args[2];
	int
		vehicleid = params[1],
		playerid = params[2];
	args[0] = &vehicleid;
	args[1] = &playerid;
	
	g_Mono->callMethod("Internal:OnVehicleDamageStatusUpdate", args);
	return 1;
}
#pragma endregion
#pragma region OnUnoccupiedVehicleUpdate(vehicleid, playerid, passenger_seat)
// PAWN native: native CBOnUnoccupiedVehicleUpdate(vehicleid, playerid, passenger_seat);
cell AMX_NATIVE_CALL CBOnUnoccupiedVehicleUpdate(AMX *amx, cell *params) {
	void *args[3];
	int
		vehicleid      = params[1],
		playerid       = params[2],
		passenger_seat = params[3];
	args[0] = &vehicleid;
	args[1] = &playerid;
	args[2] = &passenger_seat;
	
	g_Mono->callMethod("Internal:OnUnoccupiedVehicleUpdate", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerSelectedMenuRow(playerid, row)
// PAWN native: native CBOnPlayerSelectedMenuRow(playerid, row);
cell AMX_NATIVE_CALL CBOnPlayerSelectedMenuRow(AMX *amx, cell *params) {
	void *args[2];
	int
		playerid = params[1],
		row      = params[2];
	args[0] = &playerid;
	args[1] = &row;
	
	g_Mono->callMethod("Internal:OnPlayerSelectedMenuRow", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerExitedMenu(playerid)
// PAWN native: native CBOnPlayerExitedMenu(playerid);
cell AMX_NATIVE_CALL CBOnPlayerExitedMenu(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	g_Mono->callMethod("Internal:OnPlayerExitedMenu", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerInteriorChange(playerid, newinteriorid, oldinteriorid)
// PAWN native: native CBOnPlayerInteriorChange(playerid, newinteriorid, oldinteriorid);
cell AMX_NATIVE_CALL CBOnPlayerInteriorChange(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid      = params[1],
		newinteriorid = params[2],
		oldinteriorid = params[3];
	args[0] = &playerid;
	args[1] = &newinteriorid;
	args[2] = &oldinteriorid;
	
	g_Mono->callMethod("Internal:OnPlayerInteriorChange", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerKeyStateChange(playerid, newkeys, oldkeys)
// PAWN native: native CBOnPlayerKeyStateChange(playerid, newkeys, oldkeys);
cell AMX_NATIVE_CALL CBOnPlayerKeyStateChange(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid = params[1],
		newkeys  = params[2],
		oldkeys  = params[3];
	args[0] = &playerid;
	args[1] = &newkeys;
	args[2] = &oldkeys;
	
	return g_Mono->callReturn("Internal:OnPlayerKeyStateChange", args);
}
#pragma endregion
#pragma region OnRconLoginAttempt(ip[], password[], success)
// PAWN native: native CBOnRconLoginAttempt(ip[], password[], success);
cell AMX_NATIVE_CALL CBOnRconLoginAttempt(AMX *amx, cell *params) {
	int success = params[3];
	int len[2] = { NULL, NULL };
	cell *addr[2] = { NULL, NULL };

	MonoString *ip, *password;
	
	amx_GetAddr(amx, params[1], &addr[0]);
	amx_GetAddr(amx, params[2], &addr[1]);

	amx_StrLen(addr[0], &len[0]);
	amx_StrLen(addr[1], &len[1]);

	if(len[0]) {
		char *cip = new char[++len[0]];
		amx_GetString(cip, addr[0], 0, len[0]);
		ip = g_Mono->createString(cip);
		delete[] cip;
	}

	if(len[1]) {
		char *cpassword = new char[++len[1]];
		amx_GetString(cpassword, addr[1], 0, len[1]);
		password = g_Mono->createString(cpassword);
		delete[] cpassword;
	}

	void *args[3];
	args[0] = ip;
	args[1] = password;
	args[2] = &success;
	
	g_Mono->callMethod("Internal:OnRconLoginAttempt", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerUpdate(playerid)
// PAWN native: native CBOnPlayerUpdate(playerid);
cell AMX_NATIVE_CALL CBOnPlayerUpdate(AMX *amx, cell *params) {
	void *args[1];
	int playerid = params[1];
	args[0] = &playerid;
	
	return g_Mono->callReturn("Internal:OnPlayerUpdate", args);
}
#pragma endregion
#pragma region OnPlayerStreamIn(playerid, forplayerid)
// PAWN native: native CBOnPlayerStreamIn(playerid, forplayerid);
cell AMX_NATIVE_CALL CBOnPlayerStreamIn(AMX *amx, cell *params) {
	void *args[2];
	int
		playerid    = params[1],
		forplayerid = params[2];
	args[0] = &playerid;
	args[1] = &forplayerid;
	
	g_Mono->callMethod("Internal:OnPlayerStreamIn", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerStreamOut(playerid, forplayerid)
// PAWN native: native CBOnPlayerStreamOut(playerid, forplayerid);
cell AMX_NATIVE_CALL CBOnPlayerStreamOut(AMX *amx, cell *params) {
	void *args[2];
	int
		playerid    = params[1],
		forplayerid = params[2];
	args[0] = &playerid;
	args[1] = &forplayerid;
	
	g_Mono->callMethod("Internal:OnPlayerStreamOut", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleStreamIn(vehicleid, forplayerid)
// PAWN native: native CBOnVehicleStreamIn(vehicleid, forplayerid);
cell AMX_NATIVE_CALL CBOnVehicleStreamIn(AMX *amx, cell *params) {
	void *args[2];
	int
		vehicleid   = params[1],
		forplayerid = params[2];
	args[0] = &vehicleid;
	args[1] = &forplayerid;
	
	g_Mono->callMethod("Internal:OnVehicleStreamIn", args);
	return 1;
}
#pragma endregion
#pragma region OnVehicleStreamOut(vehicleid, forplayerid)
// PAWN native: native CBOnVehicleStreamOut(vehicleid, forplayerid);
cell AMX_NATIVE_CALL CBOnVehicleStreamOut(AMX *amx, cell *params) {
	void *args[2];
	int
		vehicleid   = params[1],
		forplayerid = params[2];
	args[0] = &vehicleid;
	args[1] = &forplayerid;
	
	g_Mono->callMethod("Internal:OnVehicleStreamOut", args);
	return 1;
}
#pragma endregion
#pragma region OnDialogResponse(playerid, dialogid, response, listitem, inputtext[])
// PAWN native: native CBOnDialogResponse(playerid, dialogid, response, listitem, inputtext[]);
cell AMX_NATIVE_CALL CBOnDialogResponse(AMX *amx, cell *params) {
	// Create some variables
	int len = NULL;
	cell *addr = NULL;
	

	// Get address and string length
	amx_GetAddr(amx, params[5], &addr);
	amx_StrLen(addr, &len);
	

	// Create variables to store the arguments
	void *args[5];
	int
		playerid = params[1],
		dialogid = params[2],
		response = params[3],
		listitem = params[4];

	// Store the arguments
	args[0] = &playerid;
	args[1] = &dialogid;
	args[2] = &response;
	args[3] = &listitem;
	args[4] = NULL;

	if(len) {
		// Create a buffer variable
		char *text = new char[++len];

		// Get the string and store it in the bufer
		amx_GetString(text, addr, 0, len);

		// Store the extra argument
		args[4] = g_Mono->createString(text);

		// Remove text from memory
		delete[] text;
	}

	return g_Mono->callReturn("Internal:OnDialogResponse", args);
}
#pragma endregion
#pragma region OnPlayerTakeDamage(playerid, issuerid, Float:amount, weaponid)
// PAWN native: native CBOnPlayerTakeDamage(playerid, issuerid, Float:amount, weaponid);
cell AMX_NATIVE_CALL CBOnPlayerTakeDamage(AMX *amx, cell *params) {
	void *args[4];
	int
		playerid = params[1],
		issuerid = params[2],
		weaponid = params[4];
	float amount = amx_ctof(params[3]);
	args[0] = &playerid;
	args[1] = &issuerid;
	args[2] = &amount;
	args[3] = &weaponid;
	
	g_Mono->callMethod("Internal:OnPlayerTakeDamage", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerGiveDamage(playerid, damagedid, Float:amount, weaponid)
// PAWN native: native CBOnPlayerGiveDamage(playerid, damagedid, Float:amount, weaponid);
cell AMX_NATIVE_CALL CBOnPlayerGiveDamage(AMX *amx, cell *params) {
	void *args[4];
	int
		playerid  = params[1],
		damagedid = params[2],
		weaponid  = params[4];
	float amount = amx_ctof(params[3]);
	args[0] = &playerid;
	args[1] = &damagedid;
	args[2] = &amount;
	args[3] = &weaponid;
	
	g_Mono->callMethod("Internal:OnPlayerGiveDamage", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerClickMap(playerid, Float:fX, Float:fY, Float:fZ)
// PAWN native: native CBOnPlayerClickMap(playerid, Float:fX, Float:fY, Float:fZ);
cell AMX_NATIVE_CALL CBOnPlayerClickMap(AMX *amx, cell *params) {
	void *args[4];
	int playerid = params[1];
	float
		x = amx_ctof(params[2]),
		y = amx_ctof(params[3]),
		z = amx_ctof(params[4]);
	args[0] = &playerid;
	args[1] = &x;
	args[2] = &y;
	args[3] = &z;

	g_Mono->callMethod("Internal:OnPlayerClickMap", args);

	return 1;
}
#pragma endregion
#pragma region OnPlayerClickTextDraw(playerid, Text:clickedid)
// PAWN native: native CBOnPlayerClickTextDraw(playerid, Text:clickedid);
cell AMX_NATIVE_CALL CBOnPlayerClickTextDraw(AMX *amx, cell *params) {
	void *args[2];
	int
		playerid  = params[1],
		clickedid = params[2];
	args[0] = &playerid;
	args[1] = &clickedid;
	
	return g_Mono->callReturn("Internal:OnPlayerClickTextDraw", args);
}
#pragma endregion
#pragma region OnPlayerClickPlayerTextDraw(playerid, PlayerText:playertextid)
// PAWN native: native CBOnPlayerClickPlayerTextDraw(playerid, PlayerText:playertextid);
cell AMX_NATIVE_CALL CBOnPlayerClickPlayerTextDraw(AMX *amx, cell *params) {
	void *args[2];
	int
		playerid     = params[1],
		playertextid = params[2];
	args[0] = &playerid;
	args[1] = &playertextid;
	
	g_Mono->callMethod("Internal:OnPlayerClickPlayerTextDraw", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerClickPlayer(playerid, clickedplayerid, source)
// PAWN native: native CBOnPlayerClickPlayer(playerid, clickedplayerid, source);
cell AMX_NATIVE_CALL CBOnPlayerClickPlayer(AMX *amx, cell *params) {
	void *args[3];
	int
		playerid        = params[1],
		clickedplayerid = params[2],
		source          = params[3];
	args[0] = &playerid;
	args[1] = &clickedplayerid;
	args[2] = &source;
	
	g_Mono->callMethod("Internal:OnPlayerClickPlayer", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerEditObject(playerid, playerobject, objectid, response, Float:fX, Float:fY, Float:fZ, Float:fRotX, Float:fRotY, Float:fRotZ);
// PAWN native: native CBOnPlayerEditObject(playerid, playerobject, objectid, response, Float:fX, Float:fY, Float:fZ, Float:fRotX, Float:fRotY, Float:fRotZ);
cell AMX_NATIVE_CALL CBOnPlayerEditObject(AMX *amx, cell *params) {
	void *args[10];
	int
		playerid     = params[1],
		playerobject = params[2],
		objectid     = params[3],
		response     = params[4];
	float
		fX    = amx_ctof(params[5]),
		fY    = amx_ctof(params[6]),
		fZ    = amx_ctof(params[7]),
		fRotX = amx_ctof(params[8]),
		fRotY = amx_ctof(params[9]),
		fRotZ = amx_ctof(params[10]);

	args[0] = &playerid;
	args[1] = &playerobject;
	args[2] = &objectid;
	args[3] = &response;
	args[4] = &fX;
	args[5] = &fY;
	args[6] = &fZ;
	args[7] = &fRotX;
	args[8] = &fRotY;
	args[9] = &fRotZ;
	
	g_Mono->callMethod("Internal:OnPlayerEditObject", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerEditAttachedObject(playerid, response, index, modelid, boneid,Float:fOffsetX, Float:fOffsetY, Float:fOffsetZ,Float:fRotX, Float:fRotY, Float:fRotZ,Float:fScaleX, Float:fScaleY, Float:fScaleZ);
// PAWN native: native CBOnPlayerEditAttachedObject(playerid, response, index, modelid, boneid,Float:fOffsetX, Float:fOffsetY, Float:fOffsetZ,Float:fRotX, Float:fRotY, Float:fRotZ,Float:fScaleX, Float:fScaleY, Float:fScaleZ);
cell AMX_NATIVE_CALL CBOnPlayerEditAttachedObject(AMX *amx, cell *params) {
	void *args[14];
	int
		playerid = params[1],
		response = params[2],
		index    = params[3],
		modelid  = params[4],
		boneid   = params[5];
	float
		fOffsetX = amx_ctof(params[6]),
		fOffsetY = amx_ctof(params[7]),
		fOffsetZ = amx_ctof(params[8]),
		fRotX    = amx_ctof(params[9]),
		fRotY    = amx_ctof(params[10]),
		fRotZ    = amx_ctof(params[11]),
		fScaleX  = amx_ctof(params[12]),
		fScaleY  = amx_ctof(params[13]),
		fScaleZ  = amx_ctof(params[14]);

	args[0]  = &playerid;
	args[1]  = &response;
	args[2]  = &index;
	args[3]  = &modelid;
	args[4]  = &boneid;
	args[5]  = &fOffsetX;
	args[6]  = &fOffsetY;
	args[7]  = &fOffsetY;
	args[8]  = &fRotX;
	args[9]  = &fRotY;
	args[10] = &fRotZ;
	args[11] = &fScaleX;
	args[12] = &fScaleY;
	args[13] = &fScaleZ;
	
	g_Mono->callMethod("Internal:OnPlayerEditAttachedObject", args);
	return 1;
}
#pragma endregion
#pragma region OnPlayerSelectObject(playerid, type, objectid, modelid, Float:fX, Float:fY, Float:fZ)
// PAWN native: native CBOnPlayerSelectObject(playerid, type, objectid, modelid, Float:fX, Float:fY, Float:fZ);
cell AMX_NATIVE_CALL CBOnPlayerSelectObject(AMX *amx, cell *params) {
	void *args[7];
	int
		playerid = params[1],
		type     = params[2],
		objectid = params[3],
		modelid  = params[4];
	float
		x = amx_ctof(params[5]),
		y = amx_ctof(params[6]),
		z = amx_ctof(params[7]);

	args[0] = &playerid;
	args[1] = &type;
	args[2] = &objectid;
	args[3] = &modelid;
	args[4] = &x;
	args[5] = &y;
	args[6] = &z;
	
	g_Mono->callMethod("Internal:OnPlayerSelectObject", args);
	return 1;
}
#pragma endregion