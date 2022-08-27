#define VERSION ("0.5 alpha")

#include "callbacks.h"
#include "a_samp.h"
#include "Mono.h"

typedef void (*logprintf_t)(char* format, ...);
logprintf_t logprintf;
extern void *pAMXFunctions;

void fnlogprintf(char *message) {
	logprintf(message);
}

PLUGIN_EXPORT unsigned int PLUGIN_CALL Supports() {
    return SUPPORTS_VERSION | SUPPORTS_AMX_NATIVES;
}

PLUGIN_EXPORT bool PLUGIN_CALL Load(void** ppData) {
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
	sprintf_s(msg, sizeof(msg), "   sampdotnethook v%s is OK", VERSION);
    logprintf(msg);
    return true;
}

PLUGIN_EXPORT void PLUGIN_CALL Unload() {
	char msg[50] = "";
	sprintf_s(msg, sizeof(msg), "   sampdotnethook v%s unloaded", VERSION);
    logprintf(msg);
}

AMX_NATIVE_INFO PluginNatives[] = {
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

PLUGIN_EXPORT int PLUGIN_CALL AmxLoad( AMX* amx ) {
	g_Invoke->amx_list.push_back(amx);
	g_Invoke->getAddresses();
    return amx_Register(amx, PluginNatives, -1);
}

PLUGIN_EXPORT int PLUGIN_CALL AmxUnload( AMX* amx ) {
    for(std::list<AMX *>::iterator i = g_Invoke->amx_list.begin(); i != g_Invoke->amx_list.end(); ++i) {
        if(*i == amx) {
            g_Invoke->amx_list.erase(i);
            break;
        }
    }
    return AMX_ERR_NONE;
}