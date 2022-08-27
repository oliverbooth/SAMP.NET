#include "main.h"

typedef void (*logprintf_t)(char* format, ...);
logprintf_t logprintf;
extern void *pAMXFunctions;

void _samp_logprintf(char *message) {
	logprintf(message);
}

unsigned int PLUGIN_CALL Supports() {
    return SUPPORTS_VERSION | SUPPORTS_AMX_NATIVES;
}

bool PLUGIN_CALL Load(void** ppData) {
	// Set variables
    pAMXFunctions	= ppData[PLUGIN_DATA_AMX_EXPORTS];
    logprintf		= (logprintf_t) ppData[PLUGIN_DATA_LOGPRINTF];

	// Instantiate classes
	g_Invoke	= new Invoke;
	g_Mono		= new Mono;

	// Initialize the Mono instance and load the Script library
	g_Mono->init();

	// Output status
	char msg[50] = "";
	sprintf(msg, "   sampdotnethook v%s is OK", __SDNH_VERSION_);
    _samp_logprintf(msg);
    return true;
}

void PLUGIN_CALL Unload() {
    // Unload the Script library
    g_Mono->callMethod("Script:Unload", 0);

	char msg[50] = "";
	sprintf(msg, "   sampdotnethook v%s unloaded", __SDNH_VERSION_);
    _samp_logprintf(msg);
}

AMX_NATIVE_INFO PluginNatives[] = {
	// Set of callbacks for the PAWN gamemode Script to
	{ "CBOnGameModeInit",              CBOnGameModeInit },
	{ "CBOnGameModeExit",              CBOnGameModeExit },
	{ "CBOnPlayerConnect",             CBOnPlayerConnect },
	{ "CBOnPlayerDisconnect",          CBOnPlayerDisconnect },
	{ "CBOnPlayerSpawn",               CBOnPlayerSpawn },
	{ "CBOnPlayerDeath",               CBOnPlayerDeath },
	{ "CBOnVehicleSpawn",              CBOnVehicleSpawn },
	{ "CBOnVehicleDeath",              CBOnVehicleDeath },
	{ "CBOnPlayerText",                CBOnPlayerText },
	{ "CBOnPlayerCommandText",         CBOnPlayerCommandText },
	{ "CBOnPlayerRequestClass",        CBOnPlayerRequestClass },
	{ "CBOnPlayerEnterVehicle",        CBOnPlayerEnterVehicle },
	{ "CBOnPlayerExitVehicle",         CBOnPlayerExitVehicle },
	{ "CBOnPlayerStateChange",         CBOnPlayerStateChange },
	{ "CBOnPlayerEnterCheckpoint",     CBOnPlayerEnterCheckpoint },
	{ "CBOnPlayerLeaveCheckpoint",     CBOnPlayerLeaveCheckpoint },
	{ "CBOnPlayerEnterRaceCheckpoint", CBOnPlayerEnterRaceCheckpoint },
	{ "CBOnPlayerLeaveRaceCheckpoint", CBOnPlayerLeaveRaceCheckpoint },
	{ "CBOnRconCommand",               CBOnRconCommand },
	{ "CBOnPlayerRequestSpawn",        CBOnPlayerRequestSpawn },
	{ "CBOnObjectMoved",               CBOnObjectMoved },
	{ "CBOnPlayerObjectMoved",         CBOnPlayerObjectMoved },
	{ "CBOnPlayerPickUpPickup",        CBOnPlayerPickUpPickup },
	{ "CBOnVehicleMod",                CBOnVehicleMod },
	{ "CBOnEnterExitModShop",          CBOnEnterExitModShop },
	{ "CBOnVehiclePaintjob",           CBOnVehiclePaintjob },
	{ "CBOnVehicleRespray",            CBOnVehicleRespray },
	{ "CBOnVehicleDamageStatusUpdate", CBOnVehicleDamageStatusUpdate },
	{ "CBOnUnoccupiedVehicleUpdate",   CBOnUnoccupiedVehicleUpdate },
	{ "CBOnPlayerSelectedMenuRow",     CBOnPlayerSelectedMenuRow },
	{ "CBOnPlayerExitedMenu",          CBOnPlayerExitedMenu },
	{ "CBOnPlayerInteriorChange",      CBOnPlayerInteriorChange },
	{ "CBOnPlayerKeyStateChange",      CBOnPlayerKeyStateChange },
	{ "CBOnRconLoginAttempt",          CBOnRconLoginAttempt },
	{ "CBOnPlayerUpdate",              CBOnPlayerUpdate },
	{ "CBOnPlayerStreamIn",            CBOnPlayerStreamIn },
	{ "CBOnPlayerStreamOut",           CBOnPlayerStreamOut },
	{ "CBOnVehicleStreamIn",           CBOnVehicleStreamIn },
	{ "CBOnVehicleStreamOut",          CBOnVehicleStreamOut },
	{ "CBOnDialogResponse",            CBOnDialogResponse },
	{ "CBOnPlayerTakeDamage",          CBOnPlayerTakeDamage },
	{ "CBOnPlayerGiveDamage",          CBOnPlayerGiveDamage },
	{ "CBOnPlayerClickMap",            CBOnPlayerClickMap },
	{ "CBOnPlayerClickTextDraw",       CBOnPlayerClickTextDraw },
	{ "CBOnPlayerClickPlayerTextDraw", CBOnPlayerClickPlayerTextDraw },
	{ "CBOnPlayerClickPlayer",         CBOnPlayerClickPlayer },
	{ "CBOnPlayerEditObject",          CBOnPlayerEditObject },
	{ "CBOnPlayerEditAttachedObject",  CBOnPlayerEditAttachedObject },
	{ "CBOnPlayerSelectObject",        CBOnPlayerSelectObject },

    { 0, 0 }
};

int PLUGIN_CALL AmxLoad(AMX* amx) {
	g_Invoke->amx_list.push_back(amx);
	g_Invoke->getAddresses();
    return amx_Register(amx, PluginNatives, -1);
}

int PLUGIN_CALL AmxUnload(AMX* amx) {
    for(std::list<AMX *>::iterator i = g_Invoke->amx_list.begin(); i != g_Invoke->amx_list.end(); ) {
        if(*i == amx) {
            g_Invoke->amx_list.erase(i);
            break;
        }
    }
    return AMX_ERR_NONE;
}
