#ifndef A_SAMP_H
#define A_SAMP_H

#include <stdio.h>

#include "common.h"

#include "SDK/amx/amx.h"
#include "SDK/plugincommon.h"
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
PLUGIN_EXPORT void _samp_SendClientMessage(int playerid, unsigned int color, char* message);
PLUGIN_EXPORT void _samp_SendClientMessageToAll(unsigned int color, char* message);
PLUGIN_EXPORT void _samp_SendPlayerMessageToPlayer(int playerid, int senderid, char* message);
PLUGIN_EXPORT void _samp_SendPlayerMessageToAll(int senderid, char* message);
PLUGIN_EXPORT void _samp_SendDeathMessage(int killer, int killee, int weapon);
PLUGIN_EXPORT void _samp_GameTextForAll(char* string, int time, int style);
PLUGIN_EXPORT void _samp_GameTextForPlayer(int playerid, char* string, int time, int style);
PLUGIN_EXPORT int  _samp_GetTickCount();
PLUGIN_EXPORT int  _samp_GetMaxPlayers();

// Game
PLUGIN_EXPORT void _samp_SetGameModeText(char* string);
PLUGIN_EXPORT void _samp_SetTeamCount(int count); // No effect
PLUGIN_EXPORT int  _samp_AddPlayerClass(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
PLUGIN_EXPORT int  _samp_AddPlayerClassEx(int teamid, int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
PLUGIN_EXPORT int  _samp_AddStaticVehicle(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2rt);
PLUGIN_EXPORT int  _samp_AddStaticVehicleEx(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int color1, int color2, int respawn_delay);
PLUGIN_EXPORT int  _samp_AddStaticPickup(int model, int type, float x, float y, float z, int virtualworld=0);
PLUGIN_EXPORT int  _samp_CreatePickup(int model, int type, float x, float y, float z, int virtualworld=0);
PLUGIN_EXPORT void _samp_DestroyPickup(int pickup);
PLUGIN_EXPORT void _samp_ShowNameTags(int show);
PLUGIN_EXPORT void _samp_ShowPlayerMarkers(int mode);
PLUGIN_EXPORT void _samp_GameModeExit();
PLUGIN_EXPORT void _samp_SetWorldTime(int hour);
PLUGIN_EXPORT void _samp_GetWeaponName(int weaponid, char* weapon, int len);
PLUGIN_EXPORT void _samp_EnableTirePopping(int enable); // Deprecated
PLUGIN_EXPORT void _samp_AllowInteriorWeapons(int allow);
PLUGIN_EXPORT void _samp_SetWeather(int weatherid);
PLUGIN_EXPORT void _samp_SetGravity(float gravity);
PLUGIN_EXPORT void _samp_AllowAdminTeleport(int allow); // Deprecated
PLUGIN_EXPORT void _samp_SetDeathDropAmount(int amount); // Deprecated
PLUGIN_EXPORT void _samp_CreateExplosion(float x, float y, float z, int type, float radius);
PLUGIN_EXPORT void _samp_EnableZoneNames(int enable);
PLUGIN_EXPORT void _samp_UsePlayerPedAnims();
PLUGIN_EXPORT void _samp_DisableInteriorEnterExits();
PLUGIN_EXPORT void _samp_SetNameTagDrawDistance(float distance);
PLUGIN_EXPORT void _samp_DisableNameTagLOS();
PLUGIN_EXPORT void _samp_LimitGlobalChatRadius(float chat_radius);
PLUGIN_EXPORT void _samp_LimitPlayerMarkerRadius(float marker_radius);

// Npc
PLUGIN_EXPORT void _samp_ConnectNPC(char* name, char* script);
PLUGIN_EXPORT int  _samp_IsPlayerNPC(int playerid);

// Admin
PLUGIN_EXPORT int  _samp_IsPlayerAdmin(int playerid);
PLUGIN_EXPORT void _samp_Kick(int playerid);
PLUGIN_EXPORT void _samp_Ban(int playerid);
PLUGIN_EXPORT void _samp_BanEx(int playerid, char* reason);
PLUGIN_EXPORT void _samp_SendRconCommand(char* command);
PLUGIN_EXPORT void _samp_GetServerVarAsString(char* varname, char* buffer, int len);
PLUGIN_EXPORT int  _samp_GetServerVarAsInt(char* varname);
PLUGIN_EXPORT int  _samp_GetServerVarAsBool(char* varname);
PLUGIN_EXPORT void _samp_GetPlayerNetworkStats(int playerid, char* retstr, int retstr_size);
PLUGIN_EXPORT void _samp_GetNetworkStats(char* retstr, int retstr_size);
PLUGIN_EXPORT int  _samp_GetPlayerVersion(int playerid, char* version, int len);

// Menu
PLUGIN_EXPORT int  _samp_CreateMenu(char* title, int columns, float x, float y, float col1width, float col2width=0.0);
PLUGIN_EXPORT int  _samp_DestroyMenu(int menuid);
PLUGIN_EXPORT void _samp_AddMenuItem(int menuid, int column, char* menutext);
PLUGIN_EXPORT void _samp_SetMenuColumnHeader(int menuid, int column, char* columnheader);
PLUGIN_EXPORT void _samp_ShowMenuForPlayer(int menuid, int playerid);
PLUGIN_EXPORT void _samp_HideMenuForPlayer(int menuid, int playerid);
PLUGIN_EXPORT int  _samp_IsValidMenu(int menuid);
PLUGIN_EXPORT void _samp_DisableMenu(int menuid);
PLUGIN_EXPORT void _samp_DisableMenuRow(int menuid, int row);
PLUGIN_EXPORT int  _samp_GetPlayerMenu(int playerid);

// Text Draw
PLUGIN_EXPORT int  _samp_TextDrawCreate(float x, float y, char* text);
PLUGIN_EXPORT void _samp_TextDrawDestroy(int text);
PLUGIN_EXPORT void _samp_TextDrawLetterSize(int text, float x, float y);
PLUGIN_EXPORT void _samp_TextDrawTextSize(int text, float x, float y);
PLUGIN_EXPORT void _samp_TextDrawAlignment(int text, int alignment);
PLUGIN_EXPORT void _samp_TextDrawColor(int text, unsigned int color);
PLUGIN_EXPORT void _samp_TextDrawUseBox(int text, int use);
PLUGIN_EXPORT void _samp_TextDrawBoxColor(int text, int color);
PLUGIN_EXPORT void _samp_TextDrawSetShadow(int text, int size);
PLUGIN_EXPORT void _samp_TextDrawSetOutline(int text, int size);
PLUGIN_EXPORT void _samp_TextDrawBackgroundColor(int text, unsigned int color);
PLUGIN_EXPORT void _samp_TextDrawFont(int text, int font);
PLUGIN_EXPORT void _samp_TextDrawSetProportional(int text, int set);
PLUGIN_EXPORT void _samp_TextDrawSetSelectable(int text, int set);
PLUGIN_EXPORT void _samp_TextDrawShowForPlayer(int playerid, int text);
PLUGIN_EXPORT void _samp_TextDrawHideForPlayer(int playerid, int text);
PLUGIN_EXPORT void _samp_TextDrawShowForAll(int text);
PLUGIN_EXPORT void _samp_TextDrawHideForAll(int text);
PLUGIN_EXPORT void _samp_TextDrawSetString(int text, char* string);

// Gang Zones
PLUGIN_EXPORT int  _samp_GangZoneCreate(float minx, float miny, float maxx, float maxy);
PLUGIN_EXPORT void _samp_GangZoneDestroy(int zone);
PLUGIN_EXPORT void _samp_GangZoneShowForPlayer(int playerid, int zone, unsigned int color);
PLUGIN_EXPORT int  _samp_GangZoneShowForAll(int zone, unsigned int color);
PLUGIN_EXPORT void _samp_GangZoneHideForPlayer(int playerid, int zone);
PLUGIN_EXPORT void _samp_GangZoneHideForAll(int zone);
PLUGIN_EXPORT void _samp_GangZoneFlashForPlayer(int playerid, int zone, unsigned int flashcolor);
PLUGIN_EXPORT void _samp_GangZoneFlashForAll(int zone, unsigned int flashcolor);
PLUGIN_EXPORT void _samp_GangZoneStopFlashForPlayer(int playerid, int zone);
PLUGIN_EXPORT void _samp_GangZoneStopFlashForAll(int zone);

// Global 3D Text Labels
PLUGIN_EXPORT int  _samp_Create3DTextLabel(char* text, int color, float x, float y, float z, float drawdistance, int virtualworld, int testlos=0);
PLUGIN_EXPORT int  _samp_Delete3DTextLabel(int id);
PLUGIN_EXPORT void _samp_Attach3DTextLabelToPlayer(int id, int playerid, float offsetx, float offsety, float offsetz);
PLUGIN_EXPORT void _samp_Attach3DTextLabelToVehicle(int id, int vehicleid, float offsetx, float offsety, float offsetz);
PLUGIN_EXPORT void _samp_Update3DTextLabelText(int id, int color, char* text);

// Per-player 3D Text Labels
PLUGIN_EXPORT int  _samp_CreatePlayer3DTextLabel(int playerid, char* text, int color, float x, float y, float z, float drawdistance, int attachedplayer=INVALID_PLAYER_ID, int attachedvehicle=INVALID_VEHICLE_ID, int testlos=0);
PLUGIN_EXPORT void _samp_DeletePlayer3DTextLabel(int playerid, int id);
PLUGIN_EXPORT void _samp_UpdatePlayer3DTextLabelText(int playerid, int id, int color, char* text);

// Player GUI Dialog
PLUGIN_EXPORT void _samp_ShowPlayerDialog(int playerid, int dialogid, int style, char* caption, char* info, char* button1, char* button2);

#endif // A_SAMP_H

