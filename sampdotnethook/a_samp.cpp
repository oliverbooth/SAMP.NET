#include "a_samp.h"

void SendClientMessage(int playerid, unsigned int color, char* message) {
	g_Invoke->callNative(&PAWN::SendClientMessage, playerid, color, message);
}

void SendClientMessageToAll(unsigned int color, char* message) {
	g_Invoke->callNative(&PAWN::SendClientMessageToAll, color, message);
}

void SendPlayerMessageToPlayer(int playerid, int senderid, char* message) {
	g_Invoke->callNative(&PAWN::SendPlayerMessageToPlayer, playerid, senderid, message);
}

void SendPlayerMessageToAll(int senderid, char* message) {
	g_Invoke->callNative(&PAWN::SendPlayerMessageToAll, senderid, message);
}

void SendDeathMessage(int killer, int killee, int weapon) {
	g_Invoke->callNative(&PAWN::SendDeathMessage, killer, killee, weapon);
}

void GameTextForAll(char* string, int time, int style) {
	g_Invoke->callNative(&PAWN::GameTextForAll, string, time, style);
}

void GameTextForPlayer(int playerid, char* string, int time, int style) {
	g_Invoke->callNative(&PAWN::GameTextForPlayer, playerid, string, time, style);
}

int _GetTickCount() {
	return g_Invoke->callNative(&PAWN::GetTickCount);
}

int GetMaxPlayers() {
	return g_Invoke->callNative(&PAWN::GetMaxPlayers);
}

void SetGameModeText(char* string) {
	g_Invoke->callNative(&PAWN::SetGameModeText, string);
}

void SetTeamCount(int count) { // No effect
	g_Invoke->callNative(&PAWN::SetTeamCount, count);
}

int AddPlayerClass(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo) {
	return g_Invoke->callNative(&PAWN::AddPlayerClass, modelid, spawn_x, spawn_y, spawn_z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
}

int AddPlayerClassEx(int teamid, int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo) {
	return g_Invoke->callNative(&PAWN::AddPlayerClassEx, teamid, modelid, spawn_x, spawn_y, spawn_z, z_angle, weapon1, weapon1_ammo, weapon2, weapon2_ammo, weapon3, weapon3_ammo);
}

int AddStaticVehicle(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2) {
	return g_Invoke->callNative(&PAWN::AddStaticVehicle, modelid, spawn_x, spawn_y, spawn_z, z_angle, color1, color2);
}

int AddStaticVehicleEx(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2, int respawn_delay) {
	return g_Invoke->callNative(&PAWN::AddStaticVehicleEx, modelid, spawn_x, spawn_y, spawn_z, z_angle, color1, color2, respawn_delay);
}

int AddStaticPickup(int model, int type, float x, float y, float z, int virtualworld) {
	return g_Invoke->callNative(&PAWN::AddStaticPickup, model, type, x, y, z, virtualworld);
}

int CreatePickup(int model, int type, float x, float y, float z, int virtualworld) {
	return g_Invoke->callNative(&PAWN::CreatePickup, model, type, x, y, z, virtualworld);
}

void DestroyPickup(int pickup) {
	g_Invoke->callNative(&PAWN::DestroyPickup, pickup);
}

void ShowNameTags(int show) {
	g_Invoke->callNative(&PAWN::ShowNameTags, show);
}

void ShowPlayerMarkers(int mode) {
	g_Invoke->callNative(&PAWN::ShowPlayerMarkers, mode);
}

void GameModeExit() {
	g_Invoke->callNative(&PAWN::GameModeExit);
}

void SetWorldTime(int hour) {
	g_Invoke->callNative(&PAWN::SetWorldTime, hour);
}

void GetWeaponName(int weaponid, char* weapon, int len) {
	char _weapon[50];
	g_Invoke->callNative(&PAWN::GetWeaponName, weaponid, _weapon, len);
	strncpy_s(weapon, len, _weapon, _TRUNCATE);
}

void EnableTirePopping(int enable) {  // Deprecated
	g_Invoke->callNative(&PAWN::EnableTirePopping, enable);
}

void AllowInteriorWeapons(int allow) {
	g_Invoke->callNative(&PAWN::AllowInteriorWeapons, allow);
}

void SetWeather(int weatherid) {
	g_Invoke->callNative(&PAWN::SetWeather, weatherid);
}

void SetGravity(float gravity) {
	g_Invoke->callNative(&PAWN::SetGravity, gravity);
}

void AllowAdminTeleport(int allow) { // Deprecated
	g_Invoke->callNative(&PAWN::AllowAdminTeleport, allow);
}

void SetDeathDropAmount(int amount) { // Deprecated
	g_Invoke->callNative(&PAWN::SetDeathDropAmount, amount);
}

void CreateExplosion(float x, float y, float z, int type, float radius) {
	g_Invoke->callNative(&PAWN::CreateExplosion, x, y, z, type, radius);
}

void EnableZoneNames(int enable) {
	g_Invoke->callNative(&PAWN::EnableZoneNames, enable);
}

void UsePlayerPedAnims() {
	g_Invoke->callNative(&PAWN::UsePlayerPedAnims);
}

void DisableInteriorEnterExits() {
	g_Invoke->callNative(&PAWN::DisableInteriorEnterExits);
}

void SetNameTagDrawDistance(float distance) {
	g_Invoke->callNative(&PAWN::SetNameTagDrawDistance, distance);
}

void DisableNameTagLOS() {
	g_Invoke->callNative(&PAWN::DisableNameTagLOS);
}

void LimitGlobalChatRadius(float chat_radius) {
	g_Invoke->callNative(&PAWN::LimitGlobalChatRadius, chat_radius);
}

void LimitPlayerMarkerRadius(float marker_radius) {
	g_Invoke->callNative(&PAWN::LimitPlayerMarkerRadius, marker_radius);
}

void ConnectNPC(char* name, char* script) {
	g_Invoke->callNative(&PAWN::ConnectNPC, name, script);
}

int IsPlayerNPC(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerNPC, playerid);
}

int IsPlayerAdmin(int playerid) {
	return g_Invoke->callNative(&PAWN::IsPlayerAdmin, playerid);
}

void Kick(int playerid) {
	g_Invoke->callNative(&PAWN::Kick, playerid);
}

void Ban(int playerid) {
	g_Invoke->callNative(&PAWN::Ban, playerid);
}

void BanEx(int playerid, char* reason) {
	g_Invoke->callNative(&PAWN::BanEx, playerid, reason);
}

void SendRconCommand(char* command) {
	g_Invoke->callNative(&PAWN::SendRconCommand, command);
}

void GetServerVarAsString(char* varname, char* buffer, int len) {
	char _buffer[1024];
	g_Invoke->callNative(&PAWN::GetServerVarAsString, varname, _buffer, len);
	strncpy_s(buffer, len, _buffer, _TRUNCATE);
}

int GetServerVarAsInt(char* varname) {
	return g_Invoke->callNative(&PAWN::GetServerVarAsInt, varname);
}

int GetServerVarAsBool(char* varname) {
	return g_Invoke->callNative(&PAWN::GetServerVarAsBool, varname);
}

void GetPlayerNetworkStats(int playerid, char* retstr, int retstr_size) {
	char _retstr[1024];
	g_Invoke->callNative(&PAWN::GetPlayerNetworkStats, playerid, _retstr, retstr_size);
	strncpy_s(retstr, retstr_size, _retstr, _TRUNCATE);
}

void GetNetworkStats(char* retstr, int retstr_size) {
	char _retstr[1024];
	g_Invoke->callNative(&PAWN::GetNetworkStats, _retstr, retstr_size);
	strncpy_s(retstr, retstr_size, _retstr, _TRUNCATE);
}

void GetPlayerVersion(int playerid, char* version, int len) {
	char _version[10];
	g_Invoke->callNative(&PAWN::GetPlayerVersion, playerid, _version, len);
	strncpy_s(version, len, _version, _TRUNCATE);
}

int CreateMenu(char* title, int columns, float x, float y, float col1width, float col2width ) {
	return g_Invoke->callNative(&PAWN::CreateMenu, title, columns, x, y, col1width, col2width);
}

int DestroyMenu(int menuid) {
	return g_Invoke->callNative(&PAWN::DestroyMenu, menuid);
}

void AddMenuItem(int menuid, int column, char* menutext) {
	g_Invoke->callNative(&PAWN::AddMenuItem, menuid, column, menutext);
}

void SetMenuColumnHeader(int menuid, int column, char* columnheader) {
	g_Invoke->callNative(&PAWN::SetMenuColumnHeader, menuid, column, columnheader);
}

void ShowMenuForPlayer(int menuid, int playerid) {
	g_Invoke->callNative(&PAWN::ShowMenuForPlayer, menuid, playerid);
}

void HideMenuForPlayer(int menuid, int playerid) {
	g_Invoke->callNative(&PAWN::HideMenuForPlayer, menuid, playerid);
}

int IsValidMenu(int menuid) {
	return g_Invoke->callNative(&PAWN::IsValidMenu, menuid);
}

void DisableMenu(int menuid) {
	g_Invoke->callNative(&PAWN::DisableMenu, menuid);
}

void DisableMenuRow(int menuid, int row) {
	g_Invoke->callNative(&PAWN::DisableMenuRow, menuid, row);
}

int GetPlayerMenu(int playerid) {
	return g_Invoke->callNative(&PAWN::GetPlayerMenu, playerid);
}

int TextDrawCreate(float x, float y, char* text) {
	return g_Invoke->callNative(&PAWN::TextDrawCreate, x, y, text);
}

void TextDrawDestroy(int text) {
	g_Invoke->callNative(&PAWN::TextDrawDestroy, text);
}

void TextDrawLetterSize(int text, float x, float y) {
	g_Invoke->callNative(&PAWN::TextDrawLetterSize, text, x, y);
}

void TextDrawTextSize(int text, float x, float y) {
	g_Invoke->callNative(&PAWN::TextDrawTextSize, text, x, y);
}

void TextDrawAlignment(int text, int alignment) {
	g_Invoke->callNative(&PAWN::TextDrawAlignment, text, alignment);
}

void TextDrawColor(int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::TextDrawColor, text, color);
}

void TextDrawUseBox(int text, int use) {
	g_Invoke->callNative(&PAWN::TextDrawUseBox, text, use);
}

void TextDrawBoxColor(int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::TextDrawBoxColor, text, color);
}

void TextDrawSetShadow(int text, int size) {
	g_Invoke->callNative(&PAWN::TextDrawSetShadow, text, size);
}

void TextDrawSetOutline(int text, int size) {
	g_Invoke->callNative(&PAWN::TextDrawSetOutline, text, size);
}

void TextDrawBackgroundColor(int text, unsigned int color) {
	g_Invoke->callNative(&PAWN::TextDrawBackgroundColor, text, color);
}

void TextDrawFont(int text, int font) {
	g_Invoke->callNative(&PAWN::TextDrawFont, text, font);
}

void TextDrawSetProportional(int text, int set) {
	g_Invoke->callNative(&PAWN::TextDrawSetProportional, text, set);
}

void TextDrawSetSelectable(int text, int set) {
	g_Invoke->callNative(&PAWN::TextDrawSetSelectable, text, set);
}

void TextDrawShowForPlayer(int playerid, int text) {
	g_Invoke->callNative(&PAWN::TextDrawShowForPlayer, playerid, text);
}

void TextDrawHideForPlayer(int playerid, int text) {
	g_Invoke->callNative(&PAWN::TextDrawHideForPlayer, playerid, text);
}

void TextDrawShowForAll(int text) {
	g_Invoke->callNative(&PAWN::TextDrawShowForAll, text);
}

void TextDrawHideForAll(int text) {
	g_Invoke->callNative(&PAWN::TextDrawHideForAll, text);
}

void TextDrawSetString(int text, char* string) {
	g_Invoke->callNative(&PAWN::TextDrawSetString, text, string);
}

int GangZoneCreate(float minx, float miny, float maxx, float maxy) {
	return g_Invoke->callNative(&PAWN::GangZoneCreate, minx, miny, maxx, maxy);
}

void GangZoneDestroy(int zone) {
	g_Invoke->callNative(&PAWN::GangZoneDestroy, zone);
}

void GangZoneShowForPlayer(int playerid, int zone, unsigned int color) {
	g_Invoke->callNative(&PAWN::GangZoneShowForPlayer, playerid, zone, color);
}

int GangZoneShowForAll(int zone, unsigned int color) {
	return g_Invoke->callNative(&PAWN::GangZoneShowForAll, zone, color);
}

void GangZoneHideForPlayer(int playerid, int zone) {
	g_Invoke->callNative(&PAWN::GangZoneHideForPlayer, playerid, zone);
}

void GangZoneHideForAll(int zone) {
	g_Invoke->callNative(&PAWN::GangZoneHideForAll, zone);
}

void GangZoneFlashForPlayer(int playerid, int zone, unsigned int flashcolor) {
	g_Invoke->callNative(&PAWN::GangZoneFlashForPlayer, playerid, zone, flashcolor);
}

void GangZoneFlashForAll(int zone, unsigned int flashcolor) {
	g_Invoke->callNative(&PAWN::GangZoneFlashForAll, zone, flashcolor);
}

void GangZoneStopFlashForPlayer(int playerid, int zone) {
	g_Invoke->callNative(&PAWN::GangZoneStopFlashForPlayer, playerid, zone);
}

void GangZoneStopFlashForAll(int zone) {
	g_Invoke->callNative(&PAWN::GangZoneStopFlashForAll, zone);
}

int Create3DTextLabel(char* text, unsigned int color, float x, float y, float z, float drawdistance, int virtualworld, int testLOS) {
	return g_Invoke->callNative(&PAWN::Create3DTextLabel, text, color, x, y, z, drawdistance, virtualworld, testLOS);
}

int Delete3DTextLabel(int id) {
	return g_Invoke->callNative(&PAWN::Delete3DTextLabel, id);
}

void Attach3DTextLabelToPlayer(int id, int playerid, float offsetx, float offsety, float offsetz) {
	g_Invoke->callNative(&PAWN::Attach3DTextLabelToPlayer, id, playerid, offsetx, offsety, offsetz);
}

void Attach3DTextLabelToVehicle(int id, int vehicleid, float offsetx, float offsety, float offsetz) {
	g_Invoke->callNative(&PAWN::Attach3DTextLabelToVehicle, id, vehicleid, offsetx, offsety, offsetz);
}

void Update3DTextLabelText(int id, unsigned int color, char* text) {
	g_Invoke->callNative(&PAWN::Update3DTextLabelText, id, color, text);
}

int CreatePlayer3DTextLabel(int playerid, char* text, unsigned int color, float x, float y, float z, float drawdistance, int attachedplayer, int attachedvehicle, int testLOS) {
	return g_Invoke->callNative(&PAWN::CreatePlayer3DTextLabel, playerid, text, color, x, y, z, drawdistance, attachedplayer, attachedvehicle, testLOS);
}

void DeletePlayer3DTextLabel(int playerid, int id) {
	g_Invoke->callNative(&PAWN::DeletePlayer3DTextLabel, playerid, id);
}

void UpdatePlayer3DTextLabelText(int playerid, int id, unsigned int color, char* text) {
	g_Invoke->callNative(&PAWN::UpdatePlayer3DTextLabelText, playerid, id, color, text);
}

void ShowPlayerDialog(int playerid, int dialogid, int style, char* caption, char* info, char* button1, char* button2) {
	g_Invoke->callNative(&PAWN::ShowPlayerDialog, playerid, dialogid, style, caption, info, button1, button2);
}