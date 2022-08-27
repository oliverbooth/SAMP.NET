#include "a_samp.h"

void _samp_SendClientMessage(int playerid, unsigned int color, char* message) {
	g_Invoke->callNative(&PAWN::SendClientMessage, playerid, color, message);
}

void _samp_SendClientMessageToAll(unsigned int color, char* message) {
	g_Invoke->callNative(&PAWN::SendClientMessageToAll, color, message);
}

void _samp_SendPlayerMessageToPlayer(int playerid, int senderid, char* message) {
	g_Invoke->callNative(&PAWN::SendPlayerMessageToPlayer, playerid, senderid, message);
}

void _samp_SendPlayerMessageToAll(int senderid, char* message) {
	g_Invoke->callNative(&PAWN::SendPlayerMessageToAll, senderid, message);
}

void _samp_SendDeathMessage(int killer, int killee, int weapon) {
	g_Invoke->callNative(&PAWN::SendDeathMessage, killer, killee, weapon);
}

void _samp_GameTextForAll(char* string, int time, int style) {
	g_Invoke->callNative(&PAWN::GameTextForAll, string, time, style);
}

void _samp_GameTextForPlayer(int playerid, char* string, int time, int style) {
	g_Invoke->callNative(&PAWN::GameTextForPlayer, playerid, string, time, style);
}

int _samp_GetTickCount() {
	return g_Invoke->callNative(&PAWN::GetTickCount);
}

int _samp_GetMaxPlayers() {
	return g_Invoke->callNative(&PAWN::GetMaxPlayers);
}

void _samp_SetGameModeText(char* string) {
	g_Invoke->callNative(&PAWN::SetGameModeText, string);
}

void _samp_SetTeamCount(int count) { // No effect
	g_Invoke->callNative(&PAWN::SetTeamCount, count);
}

int _samp_AddPlayerClass(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo) {
	return g_Invoke->callNative(&PAWN::AddPlayerClass, modelid, spawn_x, spawn_y, spawn_z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
}

int _samp_AddPlayerClassEx(int teamid, int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo) {
	return g_Invoke->callNative(&PAWN::AddPlayerClassEx, teamid, modelid, spawn_x, spawn_y, spawn_z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
}

int _samp_AddStaticVehicle(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2) {
	return g_Invoke->callNative(&PAWN::AddStaticVehicle, modelid, spawn_x, spawn_y, spawn_z, z_angle, color1, color2);
}

int _samp_AddStaticVehicleEx(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2, int respawn_delay) {
	return g_Invoke->callNative(&PAWN::AddStaticVehicleEx, modelid, spawn_x, spawn_y, spawn_z, z_angle, color1, color2, respawn_delay);
}

int _samp_AddStaticPickup(int model, int type, float x, float y, float z, int virtualworld) {
	return g_Invoke->callNative(&PAWN::AddStaticPickup, model, type, x, y, z, virtualworld);
}

int _samp_CreatePickup(int model, int type, float x, float y, float z, int virtualworld) {
	return g_Invoke->callNative(&PAWN::CreatePickup, model, type, x, y, z, virtualworld);
}

void _samp_DestroyPickup(int pickup) {
	g_Invoke->callNative(&PAWN::DestroyPickup, pickup);
}

void _samp_ShowNameTags(int show) {
	g_Invoke->callNative(&PAWN::ShowNameTags, show);
}

void _samp_ShowPlayerMarkers(int mode) {
	g_Invoke->callNative(&PAWN::ShowPlayerMarkers, mode);
}

void _samp_GameModeExit() {
	g_Invoke->callNative(&PAWN::GameModeExit);
}

void _samp_SetWorldTime(int hour) {
	g_Invoke->callNative(&PAWN::SetWorldTime, hour);
}

void _samp_GetWeaponName(int weaponid, char* weapon, int len) {
	char _weapon[50];
	g_Invoke->callNative(&PAWN::GetWeaponName, weaponid, _weapon, len);
	strncpy(_weapon, weapon, len);
}

void _samp_EnableTirePopping(int enable) {  // Deprecated
	g_Invoke->callNative(&PAWN::EnableTirePopping, enable);
}

void _samp_AllowInteriorWeapons(int allow) {
	g_Invoke->callNative(&PAWN::AllowInteriorWeapons, allow);
}

void _samp_SetWeather(int weatherid) {
	g_Invoke->callNative(&PAWN::SetWeather, weatherid);
}

void _samp_SetGravity(float gravity) {
	g_Invoke->callNative(&PAWN::SetGravity, gravity);
}

void _samp_AllowAdminTeleport(int allow) { // Deprecated
	g_Invoke->callNative(&PAWN::AllowAdminTeleport, allow);
}

void _samp_SetDeathDropAmount(int amount) { // Deprecated
	g_Invoke->callNative(&PAWN::SetDeathDropAmount, amount);
}

void _samp_CreateExplosion(float x, float y, float z, int type, float radius) {
	g_Invoke->callNative(&PAWN::CreateExplosion, x, y, z, type, radius);
}

void _samp_EnableZoneNames(int enable) {
	g_Invoke->callNative(&PAWN::EnableZoneNames, enable);
}

void _samp_UsePlayerPedAnims() {
	g_Invoke->callNative(&PAWN::UsePlayerPedAnims);
}

void _samp_DisableInteriorEnterExits() {
	g_Invoke->callNative(&PAWN::DisableInteriorEnterExits);
}

void _samp_SetNameTagDrawDistance(float distance) {
	g_Invoke->callNative(&PAWN::SetNameTagDrawDistance, distance);
}

void _samp_DisableNameTagLOS() {
	g_Invoke->callNative(&PAWN::DisableNameTagLOS);
}

void _samp_LimitGlobalChatRadius(float chat_radius) {
	g_Invoke->callNative(&PAWN::LimitGlobalChatRadius, chat_radius);
}

void _samp_LimitPlayerMarkerRadius(float marker_radius) {
	g_Invoke->callNative(&PAWN::LimitPlayerMarkerRadius, marker_radius);
}

void _samp_ConnectNPC(char* name, char* script) {
	g_Invoke->callNative(&PAWN::ConnectNPC, name, script);
}

int _samp_IsPlayerNPC(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerNPC, playerid);
}

int _samp_IsPlayerAdmin(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerAdmin, playerid);
}

void _samp_Kick(int playerid) {
	g_Invoke->callNative(&PAWN::Kick, playerid);
}

void _samp_Ban(int playerid) {
	g_Invoke->callNative(&PAWN::Ban, playerid);
}

void _samp_BanEx(int playerid, char* reason) {
	g_Invoke->callNative(&PAWN::BanEx, playerid, reason);
}

void _samp_SendRconCommand(char* command) {
	g_Invoke->callNative(&PAWN::SendRconCommand, command);
}

void _samp_GetServerVarAsString(char* varname, char* buffer, int len) {
	char _buffer[1024];
	g_Invoke->callNative(&PAWN::GetServerVarAsString, varname, _buffer, len);
	strncpy(_buffer, buffer, len);
}

int _samp_GetServerVarAsInt(char* varname) {
	return g_Invoke->callNative(&PAWN::GetServerVarAsInt, varname);
}

int _samp_GetServerVarAsBool(char* varname) {
	return g_Invoke->callNative(&PAWN::GetServerVarAsBool, varname);
}

void _samp_GetPlayerNetworkStats(int playerid, char* retstr, int retstr_size) {
	char _retstr[1024];
	g_Invoke->callNative(&PAWN::GetPlayerNetworkStats, playerid, _retstr, retstr_size);
	strncpy(_retstr, retstr, retstr_size);
}

void _samp_GetNetworkStats(char* retstr, int retstr_size) {
	char _retstr[1024];
	g_Invoke->callNative(&PAWN::GetNetworkStats, _retstr, retstr_size);
	strncpy(_retstr, retstr, retstr_size);
}

int _samp_GetPlayerVersion(int playerid, char* version, int len) {
	char _version[10];
	int iRet = g_Invoke->callNative(&PAWN::GetPlayerVersion, playerid, _version, len);
	strncpy(_version, version, len);
	return iRet;
}

int _samp_CreateMenu(char* title, int columns, float x, float y, float col1width, float col2width ) {
	return g_Invoke->callNative(&PAWN::CreateMenu, title, columns, x, y, col1width, col2width);
}

int _samp_DestroyMenu(int menuid) {
	return g_Invoke->callNative(&PAWN::DestroyMenu, menuid);
}

void _samp_AddMenuItem(int menuid, int column, char* menutext) {
	g_Invoke->callNative(&PAWN::AddMenuItem, menuid, column, menutext);
}

void _samp_SetMenuColumnHeader(int menuid, int column, char* columnheader) {
	g_Invoke->callNative(&PAWN::SetMenuColumnHeader, menuid, column, columnheader);
}

void _samp_ShowMenuForPlayer(int menuid, int playerid) {
	g_Invoke->callNative(&PAWN::ShowMenuForPlayer, menuid, playerid);
}

void _samp_HideMenuForPlayer(int menuid, int playerid) {
	g_Invoke->callNative(&PAWN::HideMenuForPlayer, menuid, playerid);
}

int _samp_IsValidMenu(int menuid) {
	return g_Invoke->callNative(&PAWN::IsValidMenu, menuid);
}

void _samp_DisableMenu(int menuid) {
	g_Invoke->callNative(&PAWN::DisableMenu, menuid);
}

void _samp_DisableMenuRow(int menuid, int row) {
	g_Invoke->callNative(&PAWN::DisableMenuRow, menuid, row);
}

int _samp_GetPlayerMenu(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerMenu, playerid);
}

int _samp_TextDrawCreate(float x, float y, char* text) {
	return g_Invoke->callNative(&PAWN::TextDrawCreate, x, y, text);
}

void _samp_TextDrawDestroy(int text) {
	g_Invoke->callNative(&PAWN::TextDrawDestroy, text);
}

void _samp_TextDrawLetterSize(int text, float x, float y) {
	g_Invoke->callNative(&PAWN::TextDrawLetterSize, text, x, y);
}

void _samp_TextDrawTextSize(int text, float x, float y) {
	g_Invoke->callNative(&PAWN::TextDrawTextSize, text, x, y);
}

void _samp_TextDrawAlignment(int text, int alignment) {
	g_Invoke->callNative(&PAWN::TextDrawAlignment, text, alignment);
}

void _samp_TextDrawColor(int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::TextDrawColor, text, color);
}

void _samp_TextDrawUseBox(int text, int use) {
	g_Invoke->callNative(&PAWN::TextDrawUseBox, text, use);
}

void _samp_TextDrawBoxColor(int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::TextDrawBoxColor, text, color);
}

void _samp_TextDrawSetShadow(int text, int size) {
	g_Invoke->callNative(&PAWN::TextDrawSetShadow, text, size);
}

void _samp_TextDrawSetOutline(int text, int size) {
	g_Invoke->callNative(&PAWN::TextDrawSetOutline, text, size);
}

void _samp_TextDrawBackgroundColor(int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::TextDrawBackgroundColor, text, color);
}

void _samp_TextDrawFont(int text, int font) {
	g_Invoke->callNative(&PAWN::TextDrawFont, text, font);
}

void _samp_TextDrawSetProportional(int text, int set) {
	g_Invoke->callNative(&PAWN::TextDrawSetProportional, text, set);
}

void _samp_TextDrawSetSelectable(int text, int set) {
	g_Invoke->callNative(&PAWN::TextDrawSetSelectable, text, set);
}

void _samp_TextDrawShowForPlayer(int playerid, int text) {
	g_Invoke->callNative(&PAWN::TextDrawShowForPlayer, playerid, text);
}

void _samp_TextDrawHideForPlayer(int playerid, int text) {
	g_Invoke->callNative(&PAWN::TextDrawHideForPlayer, playerid, text);
}

void _samp_TextDrawShowForAll(int text) {
	g_Invoke->callNative(&PAWN::TextDrawShowForAll, text);
}

void _samp_TextDrawHideForAll(int text) {
	g_Invoke->callNative(&PAWN::TextDrawHideForAll, text);
}

void _samp_TextDrawSetString(int text, char* string) {
	g_Invoke->callNative(&PAWN::TextDrawSetString, text, string);
}

int _samp_GangZoneCreate(float minx, float miny, float maxx, float maxy) {
	return g_Invoke->callNative(&PAWN::GangZoneCreate, minx, miny, maxx, maxy);
}

void _samp_GangZoneDestroy(int zone) {
	g_Invoke->callNative(&PAWN::GangZoneDestroy, zone);
}

void _samp_GangZoneShowForPlayer(int playerid, int zone, unsigned int color) {
	g_Invoke->callNative(&PAWN::GangZoneShowForPlayer, playerid, zone, color);
}

int _samp_GangZoneShowForAll(int zone, unsigned int color) {
	return g_Invoke->callNative(&PAWN::GangZoneShowForAll, zone, color);
}

void _samp_GangZoneHideForPlayer(int playerid, int zone) {
	g_Invoke->callNative(&PAWN::GangZoneHideForPlayer, playerid, zone);
}

void _samp_GangZoneHideForAll(int zone) {
	g_Invoke->callNative(&PAWN::GangZoneHideForAll, zone);
}

void _samp_GangZoneFlashForPlayer(int playerid, int zone, unsigned int flashcolor) {
	g_Invoke->callNative(&PAWN::GangZoneFlashForPlayer, playerid, zone, flashcolor);
}

void _samp_GangZoneFlashForAll(int zone, unsigned int flashcolor) {
	g_Invoke->callNative(&PAWN::GangZoneFlashForAll, zone, flashcolor);
}

void _samp_GangZoneStopFlashForPlayer(int playerid, int zone) {
	g_Invoke->callNative(&PAWN::GangZoneStopFlashForPlayer, playerid, zone);
}

void _samp_GangZoneStopFlashForAll(int zone) {
	g_Invoke->callNative(&PAWN::GangZoneStopFlashForAll, zone);
}

int _samp_Create3DTextLabel(char* text, unsigned int color, float x, float y, float z, float drawdistance, int virtualworld, int testLOS) {
	return g_Invoke->callNative(&PAWN::Create3DTextLabel, text, color, x, y, z, drawdistance, virtualworld, testLOS);
}

int _samp_Delete3DTextLabel(int id) {
	return g_Invoke->callNative(&PAWN::Delete3DTextLabel, id);
}

void _samp_Attach3DTextLabelToPlayer(int id, int playerid, float offsetx, float offsety, float offsetz) {
	g_Invoke->callNative(&PAWN::Attach3DTextLabelToPlayer, id, playerid, offsetx, offsety, offsetz);
}

void _samp_Attach3DTextLabelToVehicle(int id, int vehicleid, float offsetx, float offsety, float offsetz) {
	g_Invoke->callNative(&PAWN::Attach3DTextLabelToVehicle, id, vehicleid, offsetx, offsety, offsetz);
}

void _samp_Update3DTextLabelText(int id, unsigned int color, char* text) {
	g_Invoke->callNative(&PAWN::Update3DTextLabelText, id, color, text);
}

int _samp_CreatePlayer3DTextLabel(int playerid, char* text, unsigned int color, float x, float y, float z, float drawdistance, int attachedplayer, int attachedvehicle, int testLOS) {
	return g_Invoke->callNative(&PAWN::CreatePlayer3DTextLabel, playerid, text, color, x, y, z, drawdistance, attachedplayer, attachedvehicle, testLOS);
}

void _samp_DeletePlayer3DTextLabel(int playerid, int id) {
	g_Invoke->callNative(&PAWN::DeletePlayer3DTextLabel, playerid, id);
}

void _samp_UpdatePlayer3DTextLabelText(int playerid, int id, unsigned int color, char* text) {
	g_Invoke->callNative(&PAWN::UpdatePlayer3DTextLabelText, playerid, id, color, text);
}

void _samp_ShowPlayerDialog(int playerid, int dialogid, int style, char* caption, char* info, char* button1, char* button2) {
	g_Invoke->callNative(&PAWN::ShowPlayerDialog, playerid, dialogid, style, caption, info, button1, button2);
}


