#ifndef A_SAMP_H
#define A_SAMP_H

#include <stdio.h>

#include "SDK\amx\amx.h"
#include "SDK\plugincommon.h"
#include "Invoke.h"

#include "a_players.h"
#include "a_vehicles.h"
#include "a_objects.h"

// Limits and internal constants
#define MAX_PLAYER_NAME							(24)
#define MAX_PLAYERS								(500)
#define MAX_VEHICLES							(2000)
#define INVALID_PLAYER_ID						(0xFFFF)
#define INVALID_VEHICLE_ID						(0xFFFF)
#define NO_TEAM									(255)
#define MAX_OBJECTS								(1000)
#define INVALID_OBJECT_ID						(0xFFFF)
#define MAX_GANG_ZONES							(1024)
#define MAX_TEXT_DRAWS							(2048)
#define MAX_PLAYER_TEXT_DRAWS					(256)
#define MAX_MENUS								(128)
#define MAX_3DTEXT_GLOBAL						(1024)
#define MAX_3DTEXT_PLAYER						(1024)
#define MAX_PICKUPS								(4096)
#define INVALID_MENU							(0xFF)
#define INVALID_TEXT_DRAW						(0xFFFF)
#define INVALID_GANG_ZONE						(-1)
#define INVALID_3DTEXT_ID						(0xFFFF)

// Util
void SendClientMessage(int playerid, unsigned int color, char* message);
void SendClientMessageToAll(unsigned int color, char* message);
void SendPlayerMessageToPlayer(int playerid, int senderid, char* message);
void SendPlayerMessageToAll(int senderid, char* message);
void SendDeathMessage(int killer, int killee, int weapon);
void GameTextForAll(char* string, int time, int style);
void GameTextForPlayer(int playerid, char* string, int time, int style);
int _GetTickCount();
int GetMaxPlayers();

// Game
void SetGameModeText(char* string);
void SetTeamCount(int count); // No effect
int AddPlayerClass(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
int AddPlayerClassEx(int teamid, int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
int AddStaticVehicle(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2);
int AddStaticVehicleEx(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2, int respawn_delay);
int AddStaticPickup(int model, int type, float x, float y, float z, int virtualworld=0);
int CreatePickup(int model, int type, float x, float y, float z, int virtualworld=0);
void DestroyPickup(int pickup);
void ShowNameTags(int show);
void ShowPlayerMarkers(int mode);
void GameModeExit();
void SetWorldTime(int hour);
void GetWeaponName(int weaponid, char* weapon, int len);
void EnableTirePopping(int enable); // Deprecated
void AllowInteriorWeapons(int allow);
void SetWeather(int weatherid);
void SetGravity(float gravity);
void AllowAdminTeleport(int allow); // Deprecated
void SetDeathDropAmount(int amount); // Deprecated
void CreateExplosion(float x, float y, float z, int type, float radius);
void EnableZoneNames(int enable);
void UsePlayerPedAnims();
void DisableInteriorEnterExits();
void SetNameTagDrawDistance(float distance);
void DisableNameTagLOS();
void LimitGlobalChatRadius(float chat_radius);
void LimitPlayerMarkerRadius(float marker_radius);

// Npc
void ConnectNPC(char* name, char* script);
int IsPlayerNPC(int playerid);

// Admin
int IsPlayerAdmin(int playerid);
void Kick(int playerid);
void Ban(int playerid);
void BanEx(int playerid, char* reason);
void SendRconCommand(char* command);
void GetServerVarAsString(char* varname, char* buffer, int len);
int GetServerVarAsInt(char* varname);
int GetServerVarAsBool(char* varname);
void GetPlayerNetworkStats(int playerid, char* retstr, int retstr_size);
void GetNetworkStats(char* retstr, int retstr_size);
void GetPlayerVersion(int playerid, char* version, int len);

// Menu
int CreateMenu(char* title, int columns, float x, float y, float col1width, float col2width=0.0);
int DestroyMenu(int menuid);
void AddMenuItem(int menuid, int column, char* menutext);
void SetMenuColumnHeader(int menuid, int column, char* columnheader);
void ShowMenuForPlayer(int menuid, int playerid);
void HideMenuForPlayer(int menuid, int playerid);
int IsValidMenu(int menuid);
void DisableMenu(int menuid);
void DisableMenuRow(int menuid, int row);
int GetPlayerMenu(int playerid);

// Text Draw
int TextDrawCreate(float x, float y, char* text);
void TextDrawDestroy(int text);
void TextDrawLetterSize(int text, float x, float y);
void TextDrawTextSize(int text, float x, float y);
void TextDrawAlignment(int text, int alignment);
void TextDrawColor(int text, unsigned int color);
void TextDrawUseBox(int text, int use);
void TextDrawBoxColor(int text, int color);
void TextDrawSetShadow(int text, int size);
void TextDrawSetOutline(int text, int size);
void TextDrawBackgroundColor(int text, unsigned int color);
void TextDrawFont(int text, int font);
void TextDrawSetProportional(int text, int set);
void TextDrawSetSelectable(int text, int set);
void TextDrawShowForPlayer(int playerid, int text);
void TextDrawHideForPlayer(int playerid, int text);
void TextDrawShowForAll(int text);
void TextDrawHideForAll(int text);
void TextDrawSetString(int text, char* string);

// Gang Zones
int GangZoneCreate(float minx, float miny, float maxx, float maxy);
void GangZoneDestroy(int zone);
void GangZoneShowForPlayer(int playerid, int zone, unsigned int color);
int GangZoneShowForAll(int zone, unsigned int color);
void GangZoneHideForPlayer(int playerid, int zone);
void GangZoneHideForAll(int zone);
void GangZoneFlashForPlayer(int playerid, int zone, unsigned int flashcolor);
void GangZoneFlashForAll(int zone, unsigned int flashcolor);
void GangZoneStopFlashForPlayer(int playerid, int zone);
void GangZoneStopFlashForAll(int zone);

// Global 3D Text Labels
int Create3DTextLabel(char* text, int color, float x, float y, float z, float drawdistance, int virtualworld, int testlos=0);
int Delete3DTextLabel(int id);
void Attach3DTextLabelToPlayer(int id, int playerid, float offsetx, float offsety, float offsetz);
void Attach3DTextLabelToVehicle(int id, int vehicleid, float offsetx, float offsety, float offsetz);
void Update3DTextLabelText(int id, int color, char* text);

// Per-player 3D Text Labels
int CreatePlayer3DTextLabel(int playerid, char* text, int color, float x, float y, float z, float drawdistance, int attachedplayer=INVALID_PLAYER_ID, int attachedvehicle=INVALID_VEHICLE_ID, int testlos=0);
void DeletePlayer3DTextLabel(int playerid, int id);
void UpdatePlayer3DTextLabelText(int playerid, int id, int color, char* text);

// Player GUI Dialog
void ShowPlayerDialog(int playerid, int dialogid, int style, char* caption, char* info, char* button1, char* button2);

#endif // A_SAMP_H