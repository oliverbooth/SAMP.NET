#include "a_samp.h"

void SetSpawnInfo(int playerid, int team, int skin, float x, float y, float z, float rotation, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo) {
	g_Invoke->callNative(&PAWN::SetSpawnInfo, playerid, team, skin, x, y, z, rotation, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
}

void SpawnPlayer(int playerid) {
	g_Invoke->callNative(&PAWN::SpawnPlayer, playerid);
}

void SetPlayerPos(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerPos, playerid, x, y, z);
}

void SetPlayerPosFindZ(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerPosFindZ, playerid, x, y, z);
}

void GetPlayerPos(int playerid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerPos, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void SetPlayerFacingAngle(int playerid, float ang) {
	g_Invoke->callNative(&PAWN::SetPlayerFacingAngle, playerid, ang);
}

void GetPlayerFacingAngle(int playerid, float& ang) {
	float _ang = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerFacingAngle, playerid, &_ang);
	ang = _ang;
}

/*void IsPlayerInRangeOfPoint(int playerid, float range, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::IsPlayerInRangeOfPoint, playerid, range, x, y, z);
}*/

/*float GetPlayerDistanceFromPoint(int playerid, float x, float y, float z) {
	return (float)g_Invoke->callNative(&PAWN::GetPlayerDistanceFromPoint, playerid, x, y, z);
}*/

int IsPlayerStreamedIn(int playerid, int forplayerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerStreamedIn, playerid, forplayerid);
}

void SetPlayerInterior(int playerid, int interiorid) {
	g_Invoke->callNative(&PAWN::SetPlayerInterior, playerid, interiorid);
}

int GetPlayerInterior(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerInterior, playerid);
}

void SetPlayerHealth(int playerid, float health) {
	g_Invoke->callNative(&PAWN::SetPlayerHealth, playerid, health);
}

void GetPlayerHealth(int playerid, float& health) {
	float _health = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerHealth, playerid, &_health);
	health = _health;
}

void SetPlayerArmour(int playerid, float armour) {
	g_Invoke->callNative(&PAWN::SetPlayerArmour, playerid, armour);
}

void GetPlayerArmour(int playerid, float& armour) {
	float _armour = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerArmour, playerid, &_armour);
	armour = _armour;
}

void SetPlayerAmmo(int playerid, int weaponslot, int ammo) {
	g_Invoke->callNative(&PAWN::SetPlayerAmmo, playerid, weaponslot, ammo);
}

int GetPlayerAmmo(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerAmmo, playerid);
}

int GetPlayerWeaponState(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerWeaponState, playerid);
}

int GetPlayerTargetPlayer(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerTargetPlayer, playerid);
}

void SetPlayerTeam(int playerid, int teamid) {
	g_Invoke->callNative(&PAWN::SetPlayerTeam, playerid, teamid);
}

int GetPlayerTeam(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerTeam, playerid);
}

void SetPlayerScore(int playerid, int score) {
	g_Invoke->callNative(&PAWN::SetPlayerScore, playerid, score);
}

int GetPlayerScore(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerScore, playerid);
}

int GetPlayerDrunkLevel(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerDrunkLevel, playerid);
}

void SetPlayerDrunkLevel(int playerid, int level) {
	g_Invoke->callNative(&PAWN::SetPlayerDrunkLevel, playerid, level);
}

void SetPlayerColor(int playerid, unsigned int color) {
	g_Invoke->callNative(&PAWN::SetPlayerColor, playerid, color);
}

unsigned int GetPlayerColor(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerColor, playerid);
}

void SetPlayerSkin(int playerid, int skinid) {
	g_Invoke->callNative(&PAWN::SetPlayerSkin, playerid, skinid);
}

int GetPlayerSkin(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSkin, playerid);
}

void GivePlayerWeapon(int playerid, int weaponid, int ammo) {
	g_Invoke->callNative(&PAWN::GivePlayerWeapon, playerid, weaponid, ammo);
}

void ResetPlayerWeapons(int playerid) {
	g_Invoke->callNative(&PAWN::ResetPlayerWeapons, playerid);
}

void SetPlayerArmedWeapon(int playerid, int weaponid) {
	g_Invoke->callNative(&PAWN::SetPlayerArmedWeapon, playerid, weaponid);
}

void GetPlayerWeaponData(int playerid, int slot, int& weapons, int& ammo) {
	int _weapons = NULL;
	int _ammo = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerWeaponData, playerid, slot, &_weapons, &_ammo);
	weapons = _weapons;
	ammo = _ammo;
}

void GivePlayerMoney(int playerid, int money) {
	g_Invoke->callNative(&PAWN::GivePlayerMoney, playerid, money);
}

void ResetPlayerMoney(int playerid) {
	g_Invoke->callNative(&PAWN::ResetPlayerMoney, playerid);
}

void SetPlayerName(int playerid, char* name) {
	g_Invoke->callNative(&PAWN::SetPlayerName, playerid, name);
}

int GetPlayerMoney(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerMoney, playerid);
}

int GetPlayerState(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerState, playerid);
}

void GetPlayerIp(int playerid, char* name, int len) {
	g_Invoke->callNative(&PAWN::GetPlayerIp, playerid, name, len);
}

int GetPlayerPing(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerPing, playerid);
}

int GetPlayerWeapon(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerWeapon, playerid);
}

void GetPlayerKeys(int playerid, int& keys, int& updown, int& leftright) {
	int _keys = NULL;
	int _updown = NULL;
	int _leftright = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerKeys, playerid, &_keys, &_updown, &_leftright);
	keys = _keys;
	updown = _updown;
	leftright = _leftright;
}

void GetPlayerName(int playerid, char* name, int len) {
	char _name[MAX_PLAYER_NAME];
	g_Invoke->callNative(&PAWN::GetPlayerName, playerid, _name, sizeof(_name));
	strncpy_s(name, len, _name, _TRUNCATE);
}

void SetPlayerTime(int playerid, int hour, int minute) {
	g_Invoke->callNative(&PAWN::SetPlayerTime, playerid, hour, minute);
}

void GetPlayerTime(int playerid, int& hour, int& minute) {
	int _hour = NULL;
	int _minute = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerTime, playerid, &_hour, &_minute);
	hour = _hour;
	minute = _minute;
}

void TogglePlayerClock(int playerid, int toggle) {
	g_Invoke->callNative(&PAWN::TogglePlayerClock, playerid, toggle);
}

void SetPlayerWeather(int playerid, int weather) {
	g_Invoke->callNative(&PAWN::SetPlayerWeather, playerid, weather);
}

void ForceClassSelection(int playerid) {
	g_Invoke->callNative(&PAWN::ForceClassSelection, playerid);
}

void SetPlayerWantedLevel(int playerid, int level) {
	g_Invoke->callNative(&PAWN::SetPlayerWantedLevel, playerid, level);
}

int GetPlayerWantedLevel(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerWantedLevel, playerid);
}

void SetPlayerFightingStyle(int playerid, int style) {
	g_Invoke->callNative(&PAWN::SetPlayerFightingStyle, playerid, style);
}

int GetPlayerFightingStyle(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerFightingStyle, playerid);
}

void SetPlayerVelocity(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerVelocity, playerid, x, y, z);
}

void GetPlayerVelocity(int playerid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerVelocity, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void PlayCrimeReportForPlayer(int playerid, int suspectid, int crime) {
	g_Invoke->callNative(&PAWN::PlayCrimeReportForPlayer, playerid, suspectid, crime);
}

void PlayAudioStreamForPlayer(int playerid, char* url, float posx , float posy , float posz , float distance , int usepos ) {
	g_Invoke->callNative(&PAWN::PlayAudioStreamForPlayer, playerid, url, posx = 0.0, posy = 0.0, posz = 0.0, distance = 50.0, usepos = 0);
}

void StopAudioStreamForPlayer(int playerid) {
	g_Invoke->callNative(&PAWN::StopAudioStreamForPlayer, playerid);
}

void SetPlayerShopName(int playerid, char* shopname) {
	g_Invoke->callNative(&PAWN::SetPlayerShopName, playerid, shopname);
}

void SetPlayerSkillLevel(int playerid, int skill, int level) {
	g_Invoke->callNative(&PAWN::SetPlayerSkillLevel, playerid, skill, level);
}

int GetPlayerSurfingVehicleID(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSurfingVehicleID, playerid);
}

int GetPlayerSurfingObjectID(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSurfingObjectID, playerid);
}

void RemoveBuildingForPlayer(int playerid, int modelid, float fx, float fy, float fz, float fradius) {
	g_Invoke->callNative(&PAWN::RemoveBuildingForPlayer, playerid, modelid, fx, fy, fz, fradius);
}

void SetPlayerAttachedObject(int playerid, int index, int modelid, int bone, float foffsetx , float foffsety , float foffsetz , float frotx , float froty , float frotz , float fscalex , float fscaley , float fscalez , int materialcolor1 , int materialcolor2 ) {
	g_Invoke->callNative(&PAWN::SetPlayerAttachedObject, playerid, index, modelid, bone, foffsetx = 0.0, foffsety = 0.0, foffsetz = 0.0, frotx = 0.0, froty = 0.0, frotz = 0.0, fscalex = 1.0, fscaley = 1.0, fscalez = 1.0, materialcolor1 = 0, materialcolor2 = 0);
}

void RemovePlayerAttachedObject(int playerid, int index) {
	g_Invoke->callNative(&PAWN::RemovePlayerAttachedObject, playerid, index);
}

void IsPlayerAttachedObjectSlotUsed(int playerid, int index) {
	g_Invoke->callNative(&PAWN::IsPlayerAttachedObjectSlotUsed, playerid, index);
}

void EditAttachedObject(int playerid, int index) {
	g_Invoke->callNative(&PAWN::EditAttachedObject, playerid, index);
}

int CreatePlayerTextDraw(int playerid, float x, float y, char* text) {
	return g_Invoke->callNative(&PAWN::CreatePlayerTextDraw, playerid, x, y, text);
}

void PlayerTextDrawDestroy(int playerid, int text) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawDestroy, playerid, text);
}

void PlayerTextDrawLetterSize(int playerid, int text, float x, float y) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawLetterSize, playerid, text, x, y);
}

void PlayerTextDrawTextSize(int playerid, int text, float x, float y) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawTextSize, playerid, text, x, y);
}

void PlayerTextDrawAlignment(int playerid, int text, int alignment) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawAlignment, playerid, text, alignment);
}

void PlayerTextDrawColor(int playerid, int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawColor, playerid, text, color);
}

void PlayerTextDrawUseBox(int playerid, int text, int use) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawUseBox, playerid, text, use);
}

void PlayerTextDrawBoxColor(int playerid, int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawBoxColor, playerid, text, color);
}

void PlayerTextDrawSetShadow(int playerid, int text, int size) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetShadow, playerid, text, size);
}

void PlayerTextDrawSetOutline(int playerid, int text, int size) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetOutline, playerid, text, size);
}

void PlayerTextDrawBackgroundColor(int playerid, int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawBackgroundColor, playerid, text, color);
}

void PlayerTextDrawFont(int playerid, int text, int font) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawFont, playerid, text, font);
}

void PlayerTextDrawSetProportional(int playerid, int text, int set) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetProportional, playerid, text, set);
}

void PlayerTextDrawSetSelectable(int playerid, int text, int set) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetSelectable, playerid, text, set);
}

void PlayerTextDrawShow(int playerid, int text) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawShow, playerid, text);
}

void PlayerTextDrawHide(int playerid, int text) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawHide, playerid, text);
}

void PlayerTextDrawSetString(int playerid, int text, char* string) {
	g_Invoke->callNative(&PAWN::PlayerTextDrawSetString, playerid, text, string);
}

void SetPVarInt(int playerid, char* varname, int int_value) {
	g_Invoke->callNative(&PAWN::SetPVarInt, playerid, varname, int_value);
}

void GetPVarInt(int playerid, char* varname) {
	g_Invoke->callNative(&PAWN::GetPVarInt, playerid, varname);
}

void SetPVarString(int playerid, char* varname, char* string_value) {
	g_Invoke->callNative(&PAWN::SetPVarString, playerid, varname, string_value);
}

void GetPVarString(int playerid, char* varname, char* string_return, int len) {
	g_Invoke->callNative(&PAWN::GetPVarString, playerid, varname, string_return, len);
}

void SetPVarFloat(int playerid, char* varname, float float_value) {
	g_Invoke->callNative(&PAWN::SetPVarFloat, playerid, varname, float_value);
}

float GetPVarFloat(int playerid, char* varname) {
	return (float)g_Invoke->callNative(&PAWN::GetPVarFloat, playerid, varname);
}

void DeletePVar(int playerid, char* varname) {
	g_Invoke->callNative(&PAWN::DeletePVar, playerid, varname);
}

int GetPVarsUpperIndex(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPVarsUpperIndex, playerid);
}

void GetPVarNameAtIndex(int playerid, int index, char* ret_varname, int ret_len) {
	g_Invoke->callNative(&PAWN::GetPVarNameAtIndex, playerid, index, ret_varname, ret_len);
}

int GetPVarType(int playerid, char* varname) {
	return g_Invoke->callNative(&PAWN::GetPVarType, playerid, varname);
}

void SetPlayerChatBubble(int playerid, char* text, unsigned int color, float drawdistance, int expiretime) {
	g_Invoke->callNative(&PAWN::SetPlayerChatBubble, playerid, text, color, drawdistance, expiretime);
}

void PutPlayerInVehicle(int playerid, int vehicleid, int seatid) {
	g_Invoke->callNative(&PAWN::PutPlayerInVehicle, playerid, vehicleid, seatid);
}

int GetPlayerVehicleID(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerVehicleID, playerid);
}

int GetPlayerVehicleSeat(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerVehicleSeat, playerid);
}

void RemovePlayerFromVehicle(int playerid) {
	g_Invoke->callNative(&PAWN::RemovePlayerFromVehicle, playerid);
}

void TogglePlayerControllable(int playerid, int toggle) {
	g_Invoke->callNative(&PAWN::TogglePlayerControllable, playerid, toggle);
}

void PlayerPlaySound(int playerid, int soundid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::PlayerPlaySound, playerid, soundid, x, y, z);
}

void ApplyAnimation(int playerid, char* animlib, char* animname, float fdelta, int loop, int lockx, int locky, int freeze, int time, int forcesync ) {
	g_Invoke->callNative(&PAWN::ApplyAnimation, playerid, animlib, animname, fdelta, loop, lockx, locky, freeze, time, forcesync = 0);
}

void ClearAnimations(int playerid, int forcesync ) {
	g_Invoke->callNative(&PAWN::ClearAnimations, playerid, forcesync = 0);
}

int GetPlayerAnimationIndex(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerAnimationIndex, playerid);
}

void GetAnimationName(int index, char* animlib, int len1, char* animname, int len2) {
	g_Invoke->callNative(&PAWN::GetAnimationName, index, animlib, len1, animname, len2);
}

int GetPlayerSpecialAction(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerSpecialAction, playerid);
}

void SetPlayerSpecialAction(int playerid, int actionid) {
	g_Invoke->callNative(&PAWN::SetPlayerSpecialAction, playerid, actionid);
}

void SetPlayerCheckpoint(int playerid, float x, float y, float z, float size) {
	g_Invoke->callNative(&PAWN::SetPlayerCheckpoint, playerid, x, y, z, size);
}

void DisablePlayerCheckpoint(int playerid) {
	g_Invoke->callNative(&PAWN::DisablePlayerCheckpoint, playerid);
}

void SetPlayerRaceCheckpoint(int playerid, int type, float x, float y, float z, float nextx, float nexty, float nextz, float size) {
	g_Invoke->callNative(&PAWN::SetPlayerRaceCheckpoint, playerid, type, x, y, z, nextx, nexty, nextz, size);
}

void DisablePlayerRaceCheckpoint(int playerid) {
	g_Invoke->callNative(&PAWN::DisablePlayerRaceCheckpoint, playerid);
}

void SetPlayerWorldBounds(int playerid, float x_max, float x_min, float y_max, float y_min) {
	g_Invoke->callNative(&PAWN::SetPlayerWorldBounds, playerid, x_max, x_min, y_max, y_min);
}

void SetPlayerMarkerForPlayer(int playerid, int showplayerid, unsigned int color) {
	g_Invoke->callNative(&PAWN::SetPlayerMarkerForPlayer, playerid, showplayerid, color);
}

void ShowPlayerNameTagForPlayer(int playerid, int showplayerid, int show) {
	g_Invoke->callNative(&PAWN::ShowPlayerNameTagForPlayer, playerid, showplayerid, show);
}

void SetPlayerMapIcon(int playerid, int iconid, float x, float y, float z, int markertype, unsigned int color, int style) {
	g_Invoke->callNative(&PAWN::SetPlayerMapIcon, playerid, iconid, x, y, z, markertype, color, style);
}

void RemovePlayerMapIcon(int playerid, int iconid) {
	g_Invoke->callNative(&PAWN::RemovePlayerMapIcon, playerid, iconid);
}

void AllowPlayerTeleport(int playerid, int allow) {
	g_Invoke->callNative(&PAWN::AllowPlayerTeleport, playerid, allow);
}

void SetPlayerCameraPos(int playerid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerCameraPos, playerid, x, y, z);
}

void SetPlayerCameraLookAt(int playerid, float x, float y, float z, int cut) {
	g_Invoke->callNative(&PAWN::SetPlayerCameraLookAt, playerid, x, y, z, cut);
}

void SetCameraBehindPlayer(int playerid) {
	g_Invoke->callNative(&PAWN::SetCameraBehindPlayer, playerid);
}

void GetPlayerCameraPos(int playerid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerCameraPos, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void GetPlayerCameraFrontVector(int playerid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerCameraFrontVector, playerid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

int GetPlayerCameraMode(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerCameraMode, playerid);
}

void AttachCameraToObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::AttachCameraToObject, playerid, objectid);
}

void AttachCameraToPlayerObject(int playerid, int playerobjectid) {
	g_Invoke->callNative(&PAWN::AttachCameraToPlayerObject, playerid, playerobjectid);
}

void InterpolateCameraPos(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut) {
	g_Invoke->callNative(&PAWN::InterpolateCameraPos, playerid, fromx, fromy, fromz, tox, toy, toz, time, cut);
}

void InterpolateCameraLookAt(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut) {
	g_Invoke->callNative(&PAWN::InterpolateCameraLookAt, playerid, fromx, fromy, fromz, tox, toy, toz, time, cut);
}

int IsPlayerConnected(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerConnected, playerid);
}

int IsPlayerInVehicle(int playerid, int vehicleid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInVehicle, playerid, vehicleid);
}

int IsPlayerInAnyVehicle(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInAnyVehicle, playerid);
}

int IsPlayerInCheckpoint(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInCheckpoint, playerid);
}

int IsPlayerInRaceCheckpoint(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerInRaceCheckpoint, playerid);
}

void SetPlayerVirtualWorld(int playerid, int worldid) {
	g_Invoke->callNative(&PAWN::SetPlayerVirtualWorld, playerid, worldid);
}

int GetPlayerVirtualWorld(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerVirtualWorld, playerid);
}

void EnableStuntBonusForPlayer(int playerid, int enable) {
	g_Invoke->callNative(&PAWN::EnableStuntBonusForPlayer, playerid, enable);
}

void EnableStuntBonusForAll(int enable) {
	g_Invoke->callNative(&PAWN::EnableStuntBonusForAll, enable);
}

void TogglePlayerSpectating(int playerid, int toggle) {
	g_Invoke->callNative(&PAWN::TogglePlayerSpectating, playerid, toggle);
}

void PlayerSpectatePlayer(int playerid, int targetplayerid, int mode) {
	g_Invoke->callNative(&PAWN::PlayerSpectatePlayer, playerid, targetplayerid, mode);
}

void PlayerSpectateVehicle(int playerid, int targetvehicleid, int mode) {
	g_Invoke->callNative(&PAWN::PlayerSpectateVehicle, playerid, targetvehicleid, mode);
}

void StartRecordingPlayerData(int playerid, int recordtype, char* recordname) {
	g_Invoke->callNative(&PAWN::StartRecordingPlayerData, playerid, recordtype, recordname);
}

void StopRecordingPlayerData(int playerid) {
	g_Invoke->callNative(&PAWN::StopRecordingPlayerData, playerid);
}

void SelectTextDraw(int playerid, int hovercolor) {
	g_Invoke->callNative(&PAWN::SelectTextDraw, playerid, hovercolor);
}

void CancelSelectTextDraw(int playerid) {
	g_Invoke->callNative(&PAWN::CancelSelectTextDraw, playerid);
}