#ifndef _CALLBACKS_H
#define _CALLBACKS_H

#include "a_samp.h"

extern "C" {
cell AMX_NATIVE_CALL CBOnGameModeInit(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnGameModeExit(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerConnect(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerDisconnect(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerSpawn(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerDeath(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleSpawn(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleDeath(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerText(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerCommandText(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerRequestClass(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerEnterVehicle(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerExitVehicle(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerStateChange(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerEnterCheckpoint(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerLeaveCheckpoint(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerEnterRaceCheckpoint(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerLeaveRaceCheckpoint(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnRconCommand(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerRequestSpawn(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnObjectMoved(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerObjectMoved(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerPickUpPickup(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleMod(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnEnterExitModShop(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehiclePaintjob(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleRespray(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleDamageStatusUpdate(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnUnoccupiedVehicleUpdate(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerSelectedMenuRow(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerExitedMenu(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerInteriorChange(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerKeyStateChange(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnRconLoginAttempt(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerUpdate(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerStreamIn(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerStreamOut(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleStreamIn(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnVehicleStreamOut(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnDialogResponse(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerTakeDamage(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerGiveDamage(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerClickMap(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerClickTextDraw(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerClickPlayerTextDraw(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerClickPlayer(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerEditObject(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerEditAttachedObject(AMX *amx, cell *params);
cell AMX_NATIVE_CALL CBOnPlayerSelectObject(AMX *amx, cell *params);
}
#endif // _CALLBACKS_H

