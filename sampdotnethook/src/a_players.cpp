#include "a_samp.h"

void _samp_SetSpawnInfo(int playerid, int team, int skin, float x, float y, float z, float rotation, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo) {
	g_Invoke->callNative(&PAWN::SetSpawnInfo, playerid, team, skin, x, y, z, rotation, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
}

void _samp_SpawnPlayer(int playerid) {
	g_Invoke->callNative(&PAWN::SpawnPlayer, playerid);
}

void _samp_SetPlayerPos(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerPos, playerid, x, y, z);
}

void _samp_SetPlayerPosFindZ(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerPosFindZ, playerid, x, y, z);
}

void _samp_GetPlayerPos(int playerid, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerPos, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void _samp_SetPlayerFacingAngle(int playerid, float ang) {
	g_Invoke->callNative(&PAWN::SetPlayerFacingAngle, playerid, ang);
}

void _samp_GetPlayerFacingAngle(int playerid, float& ang) {
	float _ang = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerFacingAngle, playerid, &_ang);
	ang = _ang;
}

/*void IsPlayerInRangeOfPoint(int playerid, float range, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::IsPlayerInRangeOfPoint, playerid, range, x, y, z);
}*/

/*float GetPlayerDistanceFromPoint(int playerid, float x, float y, float z) {
	return (float)g_Invoke->callNative(&PAWN::GetPlayerDistanceFromPoint, playerid, x, y, z);
}*/

int _samp_IsPlayerStreamedIn(int playerid, int forplayerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerStreamedIn, playerid, forplayerid);
}

void _samp_SetPlayerInterior(int playerid, int interiorid) {
	g_Invoke->callNative(&PAWN::SetPlayerInterior, playerid, interiorid);
}

int _samp_GetPlayerInterior(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerInterior, playerid);
}

void _samp_SetPlayerHealth(int playerid, float health) {
	g_Invoke->callNative(&PAWN::SetPlayerHealth, playerid, health);
}

void _samp_GetPlayerHealth(int playerid, float& health) {
	float _health = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerHealth, playerid, &_health);
	health = _health;
}

void _samp_SetPlayerArmour(int playerid, float armour) {
	g_Invoke->callNative(&PAWN::SetPlayerArmour, playerid, armour);
}

void _samp_GetPlayerArmour(int playerid, float& armour) {
	float _armour = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerArmour, playerid, &_armour);
	armour = _armour;
}

void _samp_SetPlayerAmmo(int playerid, int weaponslot, int ammo) {
	g_Invoke->callNative(&PAWN::SetPlayerAmmo, playerid, weaponslot, ammo);
}

int _samp_GetPlayerAmmo(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerAmmo, playerid);
}

int _samp_GetPlayerWeaponState(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerWeaponState, playerid);
}

int _samp_GetPlayerTargetPlayer(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerTargetPlayer, playerid);
}

void _samp_SetPlayerTeam(int playerid, int teamid) {
	g_Invoke->callNative(&PAWN::SetPlayerTeam, playerid, teamid);
}

int _samp_GetPlayerTeam(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerTeam, playerid);
}

void _samp_SetPlayerScore(int playerid, int score) {
	g_Invoke->callNative(&PAWN::SetPlayerScore, playerid, score);
}

int _samp_GetPlayerScore(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerScore, playerid);
}

int _samp_GetPlayerDrunkLevel(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerDrunkLevel, playerid);
}

void _samp_SetPlayerDrunkLevel(int playerid, int level) {
	g_Invoke->callNative(&PAWN::SetPlayerDrunkLevel, playerid, level);
}

void _samp_SetPlayerColor(int playerid, unsigned int color) {
	g_Invoke->callNative(&PAWN::SetPlayerColor, playerid, color);
}

unsigned int _samp_GetPlayerColor(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerColor, playerid);
}

void _samp_SetPlayerSkin(int playerid, int skinid) {
	g_Invoke->callNative(&PAWN::SetPlayerSkin, playerid, skinid);
}

int _samp_GetPlayerSkin(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSkin, playerid);
}

void _samp_GivePlayerWeapon(int playerid, int weaponid, int ammo) {
	g_Invoke->callNative(&PAWN::GivePlayerWeapon, playerid, weaponid, ammo);
}

void _samp_ResetPlayerWeapons(int playerid) {
	g_Invoke->callNative(&PAWN::ResetPlayerWeapons, playerid);
}

void _samp_SetPlayerArmedWeapon(int playerid, int weaponid) {
	g_Invoke->callNative(&PAWN::SetPlayerArmedWeapon, playerid, weaponid);
}

void _samp_GetPlayerWeaponData(int playerid, int slot, int& weapons, int& ammo) {
	int _weapons = 0;
	int _ammo = 0;
	g_Invoke->callNative(&PAWN::GetPlayerWeaponData, playerid, slot, &_weapons, &_ammo);
	weapons = _weapons;
	ammo = _ammo;
}

void _samp_GivePlayerMoney(int playerid, int money) {
	g_Invoke->callNative(&PAWN::GivePlayerMoney, playerid, money);
}

void _samp_ResetPlayerMoney(int playerid) {
	g_Invoke->callNative(&PAWN::ResetPlayerMoney, playerid);
}

void _samp_SetPlayerName(int playerid, char* name) {
	g_Invoke->callNative(&PAWN::SetPlayerName, playerid, name);
}

int _samp_GetPlayerMoney(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerMoney, playerid);
}

int _samp_GetPlayerState(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerState, playerid);
}

void _samp_GetPlayerIp(int playerid, char* name, int len) {
	g_Invoke->callNative(&PAWN::GetPlayerIp, playerid, name, len);
}

int _samp_GetPlayerPing(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerPing, playerid);
}

int _samp_GetPlayerWeapon(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerWeapon, playerid);
}

void _samp_GetPlayerKeys(int playerid, int& keys, int& updown, int& leftright) {
	int _keys = 0;
	int _updown = 0;
	int _leftright = 0;
	g_Invoke->callNative(&PAWN::GetPlayerKeys, playerid, &_keys, &_updown, &_leftright);
	keys = _keys;
	updown = _updown;
	leftright = _leftright;
}

void _samp_GetPlayerName(int playerid, char* name, int len) {
	g_Invoke->callNative(&PAWN::GetPlayerName, playerid, name, len);
}

void _samp_SetPlayerTime(int playerid, int hour, int minute) {
	g_Invoke->callNative(&PAWN::SetPlayerTime, playerid, hour, minute);
}

void _samp_GetPlayerTime(int playerid, int& hour, int& minute) {
	int _hour = 0;
	int _minute = 0;
	g_Invoke->callNative(&PAWN::GetPlayerTime, playerid, &_hour, &_minute);
	hour = _hour;
	minute = _minute;
}

void _samp_TogglePlayerClock(int playerid, int toggle) {
	g_Invoke->callNative(&PAWN::TogglePlayerClock, playerid, toggle);
}

void _samp_SetPlayerWeather(int playerid, int weather) {
	g_Invoke->callNative(&PAWN::SetPlayerWeather, playerid, weather);
}

void _samp_ForceClassSelection(int playerid) {
	g_Invoke->callNative(&PAWN::ForceClassSelection, playerid);
}

void _samp_SetPlayerWantedLevel(int playerid, int level) {
	g_Invoke->callNative(&PAWN::SetPlayerWantedLevel, playerid, level);
}

int _samp_GetPlayerWantedLevel(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerWantedLevel, playerid);
}

void _samp_SetPlayerFightingStyle(int playerid, int style) {
	g_Invoke->callNative(&PAWN::SetPlayerFightingStyle, playerid, style);
}

int _samp_GetPlayerFightingStyle(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerFightingStyle, playerid);
}

void _samp_SetPlayerVelocity(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerVelocity, playerid, x, y, z);
}

void _samp_GetPlayerVelocity(int playerid, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerVelocity, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void _samp_PlayCrimeReportForPlayer(int playerid, int suspectid, int crime) {
	g_Invoke->callNative(&PAWN::PlayCrimeReportForPlayer, playerid, suspectid, crime);
}

void _samp_PlayAudioStreamForPlayer(int playerid, char* url, float posx , float posy , float posz , float distance , int usepos ) {
	g_Invoke->callNative(&PAWN::PlayAudioStreamForPlayer, playerid, url, posx = 0.0, posy = 0.0, posz = 0.0, distance = 50.0, usepos = 0);
}

void _samp_StopAudioStreamForPlayer(int playerid) {
	g_Invoke->callNative(&PAWN::StopAudioStreamForPlayer, playerid);
}

void _samp_SetPlayerShopName(int playerid, char* shopname) {
	g_Invoke->callNative(&PAWN::SetPlayerShopName, playerid, shopname);
}

void _samp_SetPlayerSkillLevel(int playerid, int skill, int level) {
	g_Invoke->callNative(&PAWN::SetPlayerSkillLevel, playerid, skill, level);
}

int _samp_GetPlayerSurfingVehicleID(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSurfingVehicleID, playerid);
}

int _samp_GetPlayerSurfingObjectID(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSurfingObjectID, playerid);
}

void _samp_RemoveBuildingForPlayer(int playerid, int modelid, float fx, float fy, float fz, float fradius) {
	g_Invoke->callNative(&PAWN::RemoveBuildingForPlayer, playerid, modelid, fx, fy, fz, fradius);
}

void _samp_SetPlayerAttachedObject(int playerid, int index, int modelid, int bone, float foffsetx , float foffsety , float foffsetz , float frotx , float froty , float frotz , float fscalex , float fscaley , float fscalez , int materialcolor1 , int materialcolor2 ) {
	g_Invoke->callNative(&PAWN::SetPlayerAttachedObject, playerid, index, modelid, bone, foffsetx = 0.0, foffsety = 0.0, foffsetz = 0.0, frotx = 0.0, froty = 0.0, frotz = 0.0, fscalex = 1.0, fscaley = 1.0, fscalez = 1.0, materialcolor1 = 0, materialcolor2 = 0);
}

void _samp_RemovePlayerAttachedObject(int playerid, int index) {
	g_Invoke->callNative(&PAWN::RemovePlayerAttachedObject, playerid, index);
}

void _samp_IsPlayerAttachedObjectSlotUsed(int playerid, int index) {
	g_Invoke->callNative(&PAWN::IsPlayerAttachedObjectSlotUsed, playerid, index);
}

void _samp_EditAttachedObject(int playerid, int index) {
	g_Invoke->callNative(&PAWN::EditAttachedObject, playerid, index);
}

int _samp_CreatePlayerTextDraw(int playerid, float x, float y, char* text) {
	return g_Invoke->callNative(&PAWN::CreatePlayerTextDraw, playerid, x, y, text);
}

void _samp_PlayerTextDrawDestroy(int playerid, int text) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawDestroy, playerid, text);
}

void _samp_PlayerTextDrawLetterSize(int playerid, int text, float x, float y) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawLetterSize, playerid, text, x, y);
}

void _samp_PlayerTextDrawTextSize(int playerid, int text, float x, float y) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawTextSize, playerid, text, x, y);
}

void _samp_PlayerTextDrawAlignment(int playerid, int text, int alignment) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawAlignment, playerid, text, alignment);
}

void _samp_PlayerTextDrawColor(int playerid, int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawColor, playerid, text, color);
}

void _samp_PlayerTextDrawUseBox(int playerid, int text, int use) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawUseBox, playerid, text, use);
}

void _samp_PlayerTextDrawBoxColor(int playerid, int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawBoxColor, playerid, text, color);
}

void _samp_PlayerTextDrawSetShadow(int playerid, int text, int size) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetShadow, playerid, text, size);
}

void _samp_PlayerTextDrawSetOutline(int playerid, int text, int size) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetOutline, playerid, text, size);
}

void _samp_PlayerTextDrawBackgroundColor(int playerid, int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawBackgroundColor, playerid, text, color);
}

void _samp_PlayerTextDrawFont(int playerid, int text, int font) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawFont, playerid, text, font);
}

void _samp_PlayerTextDrawSetProportional(int playerid, int text, int set) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetProportional, playerid, text, set);
}

void _samp_PlayerTextDrawSetSelectable(int playerid, int text, int set) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetSelectable, playerid, text, set);
}

void _samp_PlayerTextDrawShow(int playerid, int text) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawShow, playerid, text);
}

void _samp_PlayerTextDrawHide(int playerid, int text) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawHide, playerid, text);
}

void _samp_PlayerTextDrawSetString(int playerid, int text, char* string) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetString, playerid, text, string);
}

void _samp_SetPVarInt(int playerid, char* varname, int int_value) {
	g_Invoke->callNative(&PAWN::SetPVarInt, playerid, varname, int_value);
}

void _samp_GetPVarInt(int playerid, char* varname) {
	g_Invoke->callNative(&PAWN::GetPVarInt, playerid, varname);
}

void _samp_SetPVarString(int playerid, char* varname, char* string_value) {
	g_Invoke->callNative(&PAWN::SetPVarString, playerid, varname, string_value);
}

void _samp_GetPVarString(int playerid, char* varname, char* string_return, int len) {
	g_Invoke->callNative(&PAWN::GetPVarString, playerid, varname, string_return, len);
}

void _samp_SetPVarFloat(int playerid, char* varname, float float_value) {
	g_Invoke->callNative(&PAWN::SetPVarFloat, playerid, varname, float_value);
}

float _samp_GetPVarFloat(int playerid, char* varname) {
	return (float)g_Invoke->callNative(&PAWN::GetPVarFloat, playerid, varname);
}

void _samp_DeletePVar(int playerid, char* varname) {
	g_Invoke->callNative(&PAWN::DeletePVar, playerid, varname);
}

int _samp_GetPVarsUpperIndex(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPVarsUpperIndex, playerid);
}

void _samp_GetPVarNameAtIndex(int playerid, int index, char* ret_varname, int ret_len) {
	g_Invoke->callNative(&PAWN::GetPVarNameAtIndex, playerid, index, ret_varname, ret_len);
}

int _samp_GetPVarType(int playerid, char* varname) {
	return g_Invoke->callNative(&PAWN::GetPVarType, playerid, varname);
}

void _samp_SetPlayerChatBubble(int playerid, char* text, unsigned int color, float drawdistance, int expiretime) {
	g_Invoke->callNative(&PAWN::SetPlayerChatBubble, playerid, text, color, drawdistance, expiretime);
}

void _samp_PutPlayerInVehicle(int playerid, int vehicleid, int seatid) {
	g_Invoke->callNative(&PAWN::PutPlayerInVehicle, playerid, vehicleid, seatid);
}

int _samp_GetPlayerVehicleID(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerVehicleID, playerid);
}

int _samp_GetPlayerVehicleSeat(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerVehicleSeat, playerid);
}

void _samp_RemovePlayerFromVehicle(int playerid) {
	g_Invoke->callNative(&PAWN::RemovePlayerFromVehicle, playerid);
}

void _samp_TogglePlayerControllable(int playerid, int toggle) {
	g_Invoke->callNative(&PAWN::TogglePlayerControllable, playerid, toggle);
}

void _samp_PlayerPlaySound(int playerid, int soundid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::PlayerPlaySound, playerid, soundid, x, y, z);
}

void _samp_ApplyAnimation(int playerid, char* animlib, char* animname, float fdelta, int loop, int lockx, int locky, int freeze, int time, int forcesync ) {
	g_Invoke->callNative(&PAWN::ApplyAnimation, playerid, animlib, animname, fdelta, loop, lockx, locky, freeze, time, forcesync = 0);
}

void _samp_ClearAnimations(int playerid, int forcesync ) {
	g_Invoke->callNative(&PAWN::ClearAnimations, playerid, forcesync = 0);
}

int _samp_GetPlayerAnimationIndex(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerAnimationIndex, playerid);
}

void _samp_GetAnimationName(int index, char* animlib, int len1, char* animname, int len2) {
	g_Invoke->callNative(&PAWN::GetAnimationName, index, animlib, len1, animname, len2);
}

int _samp_GetPlayerSpecialAction(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSpecialAction, playerid);
}

void _samp_SetPlayerSpecialAction(int playerid, int actionid) {
	g_Invoke->callNative(&PAWN::SetPlayerSpecialAction, playerid, actionid);
}

void _samp_SetPlayerCheckpoint(int playerid, float x, float y, float z, float size) {
	g_Invoke->callNative(&PAWN::SetPlayerCheckpoint, playerid, x, y, z, size);
}

void _samp_DisablePlayerCheckpoint(int playerid) {
	g_Invoke->callNative(&PAWN::DisablePlayerCheckpoint, playerid);
}

void _samp_SetPlayerRaceCheckpoint(int playerid, int type, float x, float y, float z, float nextx, float nexty, float nextz, float size) {
	g_Invoke->callNative(&PAWN::SetPlayerRaceCheckpoint, playerid, type, x, y, z, nextx, nexty, nextz, size);
}

void _samp_DisablePlayerRaceCheckpoint(int playerid) {
	g_Invoke->callNative(&PAWN::DisablePlayerRaceCheckpoint, playerid);
}

void _samp_SetPlayerWorldBounds(int playerid, float x_max, float x_min, float y_max, float y_min) {
	g_Invoke->callNative(&PAWN::SetPlayerWorldBounds, playerid, x_max, x_min, y_max, y_min);
}

void _samp_SetPlayerMarkerForPlayer(int playerid, int showplayerid, unsigned int color) {
	g_Invoke->callNative(&PAWN::SetPlayerMarkerForPlayer, playerid, showplayerid, color);
}

void _samp_ShowPlayerNameTagForPlayer(int playerid, int showplayerid, int show) {
	g_Invoke->callNative(&PAWN::ShowPlayerNameTagForPlayer, playerid, showplayerid, show);
}

void _samp_SetPlayerMapIcon(int playerid, int iconid, float x, float y, float z, int markertype, unsigned int color, int style) {
	g_Invoke->callNative(&PAWN::SetPlayerMapIcon, playerid, iconid, x, y, z, markertype, color, style);
}

void _samp_RemovePlayerMapIcon(int playerid, int iconid) {
	g_Invoke->callNative(&PAWN::RemovePlayerMapIcon, playerid, iconid);
}

void _samp_AllowPlayerTeleport(int playerid, int allow) {
	g_Invoke->callNative(&PAWN::AllowPlayerTeleport, playerid, allow);
}

void _samp_SetPlayerCameraPos(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerCameraPos, playerid, x, y, z);
}

void _samp_SetPlayerCameraLookAt(int playerid, float x, float y, float z, int cut) {
	g_Invoke->callNative(&PAWN::SetPlayerCameraLookAt, playerid, x, y, z, cut);
}

void _samp_SetCameraBehindPlayer(int playerid) {
	g_Invoke->callNative(&PAWN::SetCameraBehindPlayer, playerid);
}

void _samp_GetPlayerCameraPos(int playerid, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerCameraPos, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void _samp_GetPlayerCameraFrontVector(int playerid, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetPlayerCameraFrontVector, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

int _samp_GetPlayerCameraMode(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerCameraMode, playerid);
}

void _samp_AttachCameraToObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::AttachCameraToObject, playerid, objectid);
}

void _samp_AttachCameraToPlayerObject(int playerid, int playerobjectid) {
	g_Invoke->callNative(&PAWN::AttachCameraToPlayerObject, playerid, playerobjectid);
}

void _samp_InterpolateCameraPos(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut) {
	g_Invoke->callNative(&PAWN::InterpolateCameraPos, playerid, fromx, fromy, fromz, tox, toy, toz, time, cut);
}

void _samp_InterpolateCameraLookAt(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut) {
	g_Invoke->callNative(&PAWN::InterpolateCameraLookAt, playerid, fromx, fromy, fromz, tox, toy, toz, time, cut);
}

int _samp_IsPlayerConnected(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerConnected, playerid);
}

int _samp_IsPlayerInVehicle(int playerid, int vehicleid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInVehicle, playerid, vehicleid);
}

int _samp_IsPlayerInAnyVehicle(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInAnyVehicle, playerid);
}

int _samp_IsPlayerInCheckpoint(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInCheckpoint, playerid);
}

int _samp_IsPlayerInRaceCheckpoint(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInRaceCheckpoint, playerid);
}

void _samp_SetPlayerVirtualWorld(int playerid, int worldid) {
	g_Invoke->callNative(&PAWN::SetPlayerVirtualWorld, playerid, worldid);
}

int _samp_GetPlayerVirtualWorld(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerVirtualWorld, playerid);
}

void _samp_EnableStuntBonusForPlayer(int playerid, int enable) {
	g_Invoke->callNative(&PAWN::EnableStuntBonusForPlayer, playerid, enable);
}

void _samp_EnableStuntBonusForAll(int enable) {
	g_Invoke->callNative(&PAWN::EnableStuntBonusForAll, enable);
}

void _samp_TogglePlayerSpectating(int playerid, int toggle) {
	g_Invoke->callNative(&PAWN::TogglePlayerSpectating, playerid, toggle);
}

void _samp_PlayerSpectatePlayer(int playerid, int targetplayerid, int mode) {
	g_Invoke->callNative(&PAWN::PlayerSpectatePlayer, playerid, targetplayerid, mode);
}

void _samp_PlayerSpectateVehicle(int playerid, int targetvehicleid, int mode) {
	g_Invoke->callNative(&PAWN::PlayerSpectateVehicle, playerid, targetvehicleid, mode);
}

void _samp_StartRecordingPlayerData(int playerid, int recordtype, char* recordname) {
	g_Invoke->callNative(&PAWN::StartRecordingPlayerData, playerid, recordtype, recordname);
}

void _samp_StopRecordingPlayerData(int playerid) {
	g_Invoke->callNative(&PAWN::StopRecordingPlayerData, playerid);
}

void _samp_SelectTextDraw(int playerid, int hovercolor) {
	g_Invoke->callNative(&PAWN::SelectTextDraw, playerid, hovercolor);
}

void _samp_CancelSelectTextDraw(int playerid) {
	g_Invoke->callNative(&PAWN::CancelSelectTextDraw, playerid);
}

