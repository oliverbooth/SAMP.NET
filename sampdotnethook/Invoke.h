/*
    SA-MP Streamer Plugin v2.5.2
    Copyright © 2010 Incognito

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#pragma once

#ifdef _WIN32
	#include <windows.h>
#endif
#include <algorithm>
#include <bitset>
#include <limits>
#include <list>
#include <map>
#include <math.h>
#include <set>
#include <stdarg.h>
#include <string>
#include <string.h>
#include <vector>
#include "SDK\amx\amx.h"
#include "SDK\plugincommon.h"

using namespace std;

namespace PAWN
{
	struct Native
	{
		const char * name;
		const char * data;
	};

	static const char * const names[] =
	{
		// a_samp.inc
		#pragma region a_samp.inc
		"SendClientMessage",
		"SendClientMessageToAll",
		"SendPlayerMessageToPlayer",
		"SendPlayerMessageToAll",
		"SendDeathMessage",
		"GameTextForAll",
		"GameTextForPlayer",
		"GetTickCount",
		"GetMaxPlayers",
		"SetGameModeText",
		"SetTeamCount",
		"AddPlayerClass",
		"AddPlayerClassEx",
		"AddStaticVehicle",
		"AddStaticVehicleEx",
		"AddStaticPickup",
		"CreatePickup",
		"DestroyPickup",
		"ShowNameTags",
		"ShowPlayerMarkers",
		"GameModeExit",
		"SetWorldTime",
		"GetWeaponName",
		"EnableTirePopping",
		"AllowInteriorWeapons",
		"SetWeather",
		"SetGravity",
		"AllowAdminTeleport",
		"SetDeathDropAmount",
		"CreateExplosion",
		"EnableZoneNames",
		"UsePlayerPedAnims",
		"DisableInteriorEnterExits",
		"SetNameTagDrawDistance",
		"DisableNameTagLOS",
		"LimitGlobalChatRadius",
		"LimitPlayerMarkerRadius",
		"ConnectNPC",
		"IsPlayerNPC",
		"IsPlayerAdmin",
		"Kick",
		"Ban",
		"BanEx",
		"SendRconCommand",
		"GetServerVarAsString",
		"GetServerVarAsInt",
		"GetServerVarAsBool",
		"GetPlayerNetworkStats",
		"GetNetworkStats",
		"GetPlayerVersion",
		"CreateMenu",
		"DestroyMenu",
		"AddMenuItem",
		"SetMenuColumnHeader",
		"ShowMenuForPlayer",
		"HideMenuForPlayer",
		"IsValidMenu",
		"DisableMenu",
		"DisableMenuRow",
		"GetPlayerMenu",
		"TextDrawCreate",
		"TextDrawDestroy",
		"TextDrawLetterSize",
		"TextDrawTextSize",
		"TextDrawAlignment",
		"TextDrawColor",
		"TextDrawUseBox",
		"TextDrawBoxColor",
		"TextDrawSetShadow",
		"TextDrawSetOutline",
		"TextDrawBackgroundColor",
		"TextDrawFont",
		"TextDrawSetProportional",
		"TextDrawSetSelectable",
		"TextDrawShowForPlayer",
		"TextDrawHideForPlayer",
		"TextDrawShowForAll",
		"TextDrawHideForAll",
		"TextDrawSetString",
		"GangZoneCreate",
		"GangZoneDestroy",
		"GangZoneShowForPlayer",
		"GangZoneShowForAll",
		"GangZoneHideForPlayer",
		"GangZoneHideForAll",
		"GangZoneFlashForPlayer",
		"GangZoneFlashForAll",
		"GangZoneStopFlashForPlayer",
		"GangZoneStopFlashForAll",
		"Create3DTextLabel",
		"Delete3DTextLabel",
		"Attach3DTextLabelToPlayer",
		"Attach3DTextLabelToVehicle",
		"Update3DTextLabelText",
		"CreatePlayer3DTextLabel",
		"DeletePlayer3DTextLabel",
		"UpdatePlayer3DTextLabelText",
		"ShowPlayerDialog",
		#pragma endregion

		//a_players.inc
		#pragma region a_players.inc
		"SetSpawnInfo",
		"SpawnPlayer",
		"SetPlayerPos",
		"SetPlayerPosFindZ",
		"GetPlayerPos",
		"SetPlayerFacingAngle",
		"GetPlayerFacingAngle",
		//"IsPlayerInRangeOfPoint",
		//"GetPlayerDistanceFromPoint",
		"IsPlayerStreamedIn",
		"SetPlayerInterior",
		"GetPlayerInterior",
		"SetPlayerHealth",
		"GetPlayerHealth",
		"SetPlayerArmour",
		"GetPlayerArmour",
		"SetPlayerAmmo",
		"GetPlayerAmmo",
		"GetPlayerWeaponState",
		"GetPlayerTargetPlayer",
		"SetPlayerTeam",
		"GetPlayerTeam",
		"SetPlayerScore",
		"GetPlayerScore",
		"GetPlayerDrunkLevel",
		"SetPlayerDrunkLevel",
		"SetPlayerColor",
		"GetPlayerColor",
		"SetPlayerSkin",
		"GetPlayerSkin",
		"GivePlayerWeapon",
		"ResetPlayerWeapons",
		"SetPlayerArmedWeapon",
		"GetPlayerWeaponData",
		"GivePlayerMoney",
		"ResetPlayerMoney",
		"SetPlayerName",
		"GetPlayerMoney",
		"GetPlayerState",
		"GetPlayerIp",
		"GetPlayerPing",
		"GetPlayerWeapon",
		"GetPlayerKeys",
		"GetPlayerName",
		"SetPlayerTime",
		"GetPlayerTime",
		"TogglePlayerClock",
		"SetPlayerWeather",
		"ForceClassSelection",
		"SetPlayerWantedLevel",
		"GetPlayerWantedLevel",
		"SetPlayerFightingStyle",
		"GetPlayerFightingStyle",
		"SetPlayerVelocity",
		"GetPlayerVelocity",
		"PlayCrimeReportForPlayer",
		"PlayAudioStreamForPlayer",
		"StopAudioStreamForPlayer",
		"SetPlayerShopName",
		"SetPlayerSkillLevel",
		"GetPlayerSurfingVehicleID",
		"GetPlayerSurfingObjectID",
		"RemoveBuildingForPlayer",
		"SetPlayerAttachedObject",
		"RemovePlayerAttachedObject",
		"IsPlayerAttachedObjectSlotUsed",
		"EditAttachedObject",
		"CreatePlayerTextDraw",
		"PlayerTextDrawDestroy",
		"PlayerTextDrawLetterSize",
		"PlayerTextDrawTextSize",
		"PlayerTextDrawAlignment",
		"PlayerTextDrawColor",
		"PlayerTextDrawUseBox",
		"PlayerTextDrawBoxColor",
		"PlayerTextDrawSetShadow",
		"PlayerTextDrawSetOutline",
		"PlayerTextDrawBackgroundColor",
		"PlayerTextDrawFont",
		"PlayerTextDrawSetProportional",
		"PlayerTextDrawSetSelectable",
		"PlayerTextDrawShow",
		"PlayerTextDrawHide",
		"PlayerTextDrawSetString",
		"SetPVarInt",
		"GetPVarInt",
		"SetPVarString",
		"GetPVarString",
		"SetPVarFloat",
		"GetPVarFloat",
		"DeletePVar",
		"GetPVarsUpperIndex",
		"GetPVarNameAtIndex",
		"GetPVarType",
		"SetPlayerChatBubble",
		"PutPlayerInVehicle",
		"GetPlayerVehicleID",
		"GetPlayerVehicleSeat",
		"RemovePlayerFromVehicle",
		"TogglePlayerControllable",
		"PlayerPlaySound",
		"ApplyAnimation",
		"ClearAnimations",
		"GetPlayerAnimationIndex",
		"GetAnimationName",
		"GetPlayerSpecialAction",
		"SetPlayerSpecialAction",
		"SetPlayerCheckpoint",
		"DisablePlayerCheckpoint",
		"SetPlayerRaceCheckpoint",
		"DisablePlayerRaceCheckpoint",
		"SetPlayerWorldBounds",
		"SetPlayerMarkerForPlayer",
		"ShowPlayerNameTagForPlayer",
		"SetPlayerMapIcon",
		"RemovePlayerMapIcon",
		"AllowPlayerTeleport",
		"SetPlayerCameraPos",
		"SetPlayerCameraLookAt",
		"SetCameraBehindPlayer",
		"GetPlayerCameraPos",
		"GetPlayerCameraFrontVector",
		"GetPlayerCameraMode",
		"AttachCameraToObject",
		"AttachCameraToPlayerObject",
		"InterpolateCameraPos",
		"InterpolateCameraLookAt",
		"IsPlayerConnected",
		"IsPlayerInVehicle",
		"IsPlayerInAnyVehicle",
		"IsPlayerInCheckpoint",
		"IsPlayerInRaceCheckpoint",
		"SetPlayerVirtualWorld",
		"GetPlayerVirtualWorld",
		"EnableStuntBonusForPlayer",
		"EnableStuntBonusForAll",
		"TogglePlayerSpectating",
		"PlayerSpectatePlayer",
		"PlayerSpectateVehicle",
		"StartRecordingPlayerData",
		"StopRecordingPlayerData",
		"SelectTextDraw",
		"CancelSelectTextDraw",
		#pragma endregion

		// a_vehicle.inc
		#pragma region a_vehicle.inc
		"CreateVehicle",
		"DestroyVehicle",
		"IsVehicleStreamedIn",
		"GetVehiclePos",
		"SetVehiclePos",
		"GetVehicleZAngle",
		"GetVehicleRotationQuat",
		"GetVehicleDistanceFromPoint",
		"SetVehicleZAngle",
		"SetVehicleParamsForPlayer",
		"ManualVehicleEngineAndLights",
		"SetVehicleParamsEx",
		"GetVehicleParamsEx",
		"SetVehicleToRespawn",
		"LinkVehicleToInterior",
		"AddVehicleComponent",
		"RemoveVehicleComponent",
		"ChangeVehicleColor",
		"ChangeVehiclePaintjob",
		"SetVehicleHealth",
		"GetVehicleHealth",
		"AttachTrailerToVehicle",
		"DetachTrailerFromVehicle",
		"IsTrailerAttachedToVehicle",
		"GetVehicleTrailer",
		"SetVehicleNumberPlate",
		"GetVehicleModel",
		"GetVehicleComponentInSlot",
		"GetVehicleComponentType",
		"RepairVehicle",
		"GetVehicleVelocity",
		"SetVehicleVelocity",
		"SetVehicleAngularVelocity",
		"GetVehicleDamageStatus",
		"UpdateVehicleDamageStatus",
		"GetVehicleModelInfo",
		"SetVehicleVirtualWorld",
		"GetVehicleVirtualWorld",
		#pragma endregion

		//a_objects.inc
		#pragma region a_objects.inc
		"CreateObject",
		"AttachObjectToVehicle",
		"AttachObjectToObject",
		"AttachObjectToPlayer",
		"SetObjectPos",
		"GetObjectPos",
		"SetObjectRot",
		"GetObjectRot",
		"IsValidObject",
		"DestroyObject",
		"MoveObject",
		"StopObject",
		"IsObjectMoving",
		"EditObject",
		"EditPlayerObject",
		"SelectObject",
		"CancelEdit",
		"CreatePlayerObject",
		"AttachPlayerObjectToVehicle",
		"SetPlayerObjectPos",
		"GetPlayerObjectPos",
		"SetPlayerObjectRot",
		"GetPlayerObjectRot",
		"IsValidPlayerObject",
		"DestroyPlayerObject",
		"MovePlayerObject",
		"StopPlayerObject",
		"IsPlayerObjectMoving",
		"AttachPlayerObjectToPlayer",
		"SetObjectMaterial",
		"SetPlayerObjectMaterial",
		"SetObjectMaterialText",
		"SetPlayerObjectMaterialText",
		#pragma endregion
	};
	
	// a_samp.inc
	#pragma region a_samp.inc

	// Util
	static const Native SendClientMessage           = { "SendClientMessage",           "iis" };
	static const Native SendClientMessageToAll      = { "SendClientMessageToAll",      "is" };
	static const Native SendPlayerMessageToPlayer   = { "SendPlayerMessageToPlayer",   "iis" };
	static const Native SendPlayerMessageToAll      = { "SendPlayerMessageToAll",      "is" };
	static const Native SendDeathMessage            = { "SendDeathMessage",            "iii" };
	static const Native GameTextForAll              = { "GameTextForAll",              "sii" };
	static const Native GameTextForPlayer           = { "GameTextForPlayer",           "isii" };
	static const Native GetTickCount                = { "GetTickCount",                "i" };
	static const Native GetMaxPlayers               = { "GetMaxPlayers",               "i" };

	// Game
	static const Native SetGameModeText             = { "SetGameModeText",             "s" };
	static const Native SetTeamCount                = { "SetTeamCount",                "i" };
	static const Native AddPlayerClass              = { "AddPlayerClass",              "iffffiiiiii" };
	static const Native AddPlayerClassEx            = { "AddPlayerClassEx",            "iiffffiiiiii" };
	static const Native AddStaticVehicle            = { "AddStaticVehicle",            "iffffii" };
	static const Native AddStaticVehicleEx          = { "AddStaticVehicleEx",          "iffffiii" };
	static const Native AddStaticPickup             = { "AddStaticPickup",             "iifffi" };
	static const Native CreatePickup                = { "CreatePickup",                "iifffi" };
	static const Native DestroyPickup               = { "DestroyPickup",               "i" };
	static const Native ShowNameTags                = { "ShowNameTags",                "i" };
	static const Native ShowPlayerMarkers           = { "ShowPlayerMarkers",           "i" };
	static const Native GameModeExit                = { "GameModeExit",                "i" };
	static const Native SetWorldTime                = { "SetWorldTime",                "i" };
	static const Native GetWeaponName               = { "GetWeaponName",               "ipi" };
	static const Native EnableTirePopping           = { "EnableTirePopping",           "i" };
	static const Native AllowInteriorWeapons        = { "AllowInteriorWeapons",        "i" };
	static const Native SetWeather                  = { "SetWeather",                  "i" };
	static const Native SetGravity                  = { "SetGravity",                  "f" };
	static const Native AllowAdminTeleport          = { "AllowAdminTeleport",          "i" };
	static const Native SetDeathDropAmount          = { "SetDeathDropAmount",          "i" };
	static const Native CreateExplosion             = { "CreateExplosion",             "fffif" };
	static const Native EnableZoneNames             = { "EnableZoneNames",             "i" };
	static const Native UsePlayerPedAnims           = { "UsePlayerPedAnims",           "i" };
	static const Native DisableInteriorEnterExits   = { "DisableInteriorEnterExits",   "i" };
	static const Native SetNameTagDrawDistance      = { "SetNameTagDrawDistance",      "f" };
	static const Native DisableNameTagLOS           = { "DisableNameTagLOS",           "i" };
	static const Native LimitGlobalChatRadius       = { "LimitGlobalChatRadius",       "f" };
	static const Native LimitPlayerMarkerRadius     = { "LimitPlayerMarkerRadius",     "f" };

	// Npc
	static const Native ConnectNPC                  = { "ConnectNPC",                  "ss" };
	static const Native IsPlayerNPC                 = { "IsPlayerNPC",                 "i" };

	// Admin
	static const Native IsPlayerAdmin               = { "IsPlayerAdmin",               "i" };
	static const Native Kick                        = { "Kick",                        "i" };
	static const Native Ban                         = { "Ban",                         "i" };
	static const Native BanEx                       = { "BanEx",                       "is" };
	static const Native SendRconCommand             = { "SendRconCommand",             "s" };
	static const Native GetServerVarAsString        = { "GetServerVarAsString",        "spi" };
	static const Native GetServerVarAsInt           = { "GetServerVarAsInt",           "s" };
	static const Native GetServerVarAsBool          = { "GetServerVarAsBool",          "s" };
	static const Native GetPlayerNetworkStats       = { "GetPlayerNetworkStats",       "isi" };
	static const Native GetNetworkStats             = { "GetNetworkStats",             "si" };
	static const Native GetPlayerVersion            = { "GetPlayerVersion",            "ipi" };

	// Menu
	static const Native CreateMenu                  = { "CreateMenu",                  "siffff" };
	static const Native DestroyMenu                 = { "DestroyMenu",                 "i" };
	static const Native AddMenuItem                 = { "AddMenuItem",                 "iis" };
	static const Native SetMenuColumnHeader         = { "SetMenuColumnHeader",         "iis" };
	static const Native ShowMenuForPlayer           = { "ShowMenuForPlayer",           "ii" };
	static const Native HideMenuForPlayer           = { "HideMenuForPlayer",           "ii" };
	static const Native IsValidMenu                 = { "IsValidMenu",                 "i" };
	static const Native DisableMenu                 = { "DisableMenu",                 "i" };
	static const Native DisableMenuRow              = { "DisableMenuRow",              "ii" };
	static const Native GetPlayerMenu               = { "GetPlayerMenu",               "i" };

	// Text Draw
	static const Native TextDrawCreate              = { "TextDrawCreate",              "ffs" };
	static const Native TextDrawDestroy             = { "TextDrawDestroy",             "i" };
	static const Native TextDrawLetterSize          = { "TextDrawLetterSize",          "iff" };
	static const Native TextDrawTextSize            = { "TextDrawTextSize",            "iff" };
	static const Native TextDrawAlignment           = { "TextDrawAlignment",           "ii" };
	static const Native TextDrawColor               = { "TextDrawColor",               "ii" };
	static const Native TextDrawUseBox              = { "TextDrawUseBox",              "ii" };
	static const Native TextDrawBoxColor            = { "TextDrawBoxColor",            "ii" };
	static const Native TextDrawSetShadow           = { "TextDrawSetShadow",           "ii" };
	static const Native TextDrawSetOutline          = { "TextDrawSetOutline",          "ii" };
	static const Native TextDrawBackgroundColor     = { "TextDrawBackgroundColor",     "ii" };
	static const Native TextDrawFont                = { "TextDrawFont",                "ii" };
	static const Native TextDrawSetProportional     = { "TextDrawSetProportional",     "ii" };
	static const Native TextDrawSetSelectable       = { "TextDrawSetSelectable",       "ii" };
	static const Native TextDrawShowForPlayer       = { "TextDrawShowForPlayer",       "ii" };
	static const Native TextDrawHideForPlayer       = { "TextDrawHideForPlayer",       "ii" };
	static const Native TextDrawShowForAll          = { "TextDrawShowForAll",          "i" };
	static const Native TextDrawHideForAll          = { "TextDrawHideForAll",          "i" };
	static const Native TextDrawSetString           = { "TextDrawSetString",           "is" };

	// Gang Zones
	static const Native GangZoneCreate              = { "GangZoneCreate",              "ffff" };
	static const Native GangZoneDestroy             = { "GangZoneDestroy",             "i" };
	static const Native GangZoneShowForPlayer       = { "GangZoneShowForPlayer",       "iii" };
	static const Native GangZoneShowForAll          = { "GangZoneShowForAll",          "ii" };
	static const Native GangZoneHideForPlayer       = { "GangZoneHideForPlayer",       "ii" };
	static const Native GangZoneHideForAll          = { "GangZoneHideForAll",          "i" };
	static const Native GangZoneFlashForPlayer      = { "GangZoneFlashForPlayer",      "iii" };
	static const Native GangZoneFlashForAll         = { "GangZoneFlashForAll",         "ii" };
	static const Native GangZoneStopFlashForPlayer  = { "GangZoneStopFlashForPlayer",  "ii" };
	static const Native GangZoneStopFlashForAll     = { "GangZoneStopFlashForAll",     "i" };

	// Global 3D Text Labels
	static const Native Create3DTextLabel           = { "Create3DTextLabel",           "siffffii" };
	static const Native Delete3DTextLabel           = { "Delete3DTextLabel",           "i" };
	static const Native Attach3DTextLabelToPlayer   = { "Attach3DTextLabelToPlayer",   "iifff" };
	static const Native Attach3DTextLabelToVehicle  = { "Attach3DTextLabelToVehicle",  "iifff" };
	static const Native Update3DTextLabelText       = { "Update3DTextLabelText",       "iis" };

	// Per-player 3D Text Labels
	static const Native CreatePlayer3DTextLabel     = { "CreatePlayer3DTextLabel",     "isiffffiii" };
	static const Native DeletePlayer3DTextLabel     = { "DeletePlayer3DTextLabel",     "ii" };
	static const Native UpdatePlayer3DTextLabelText = { "UpdatePlayer3DTextLabelText", "iiis" };

	// Player GUI Dialog
	static const Native ShowPlayerDialog            = { "ShowPlayerDialog",            "iiissss" };
	#pragma endregion
	
	// a_players.inc
	#pragma region a_players.inc
	
	// Player
	static const Native SetSpawnInfo                   = { "SetSpawnInfo",                   "iiiffffiiiiii" };
	static const Native SpawnPlayer                    = { "SpawnPlayer",                    "i" };

	// Player info
	static const Native SetPlayerPos                   = { "SetPlayerPos",                   "ifff" };
	static const Native SetPlayerPosFindZ              = { "SetPlayerPosFindZ",              "ifff" };
	static const Native GetPlayerPos                   = { "GetPlayerPos",                   "ivvv" };
	static const Native SetPlayerFacingAngle           = { "SetPlayerFacingAngle",           "if" };
	static const Native GetPlayerFacingAngle           = { "GetPlayerFacingAngle",           "iv" };
	static const Native IsPlayerInRangeOfPoint         = { "IsPlayerInRangeOfPoint",         "iffff" };
	static const Native GetPlayerDistanceFromPoint     = { "GetPlayerDistanceFromPoint",     "ifff" };
	static const Native IsPlayerStreamedIn             = { "IsPlayerStreamedIn",             "ii" };
	static const Native SetPlayerInterior              = { "SetPlayerInterior",              "ii" };
	static const Native GetPlayerInterior              = { "GetPlayerInterior",              "i" };
	static const Native SetPlayerHealth                = { "SetPlayerHealth",                "if" };
	static const Native GetPlayerHealth                = { "GetPlayerHealth",                "iv" };
	static const Native SetPlayerArmour                = { "SetPlayerArmour",                "if" };
	static const Native GetPlayerArmour                = { "GetPlayerArmour",                "iv" };
	static const Native SetPlayerAmmo                  = { "SetPlayerAmmo",                  "iii" };
	static const Native GetPlayerAmmo                  = { "GetPlayerAmmo",                  "i" };
	static const Native GetPlayerWeaponState           = { "GetPlayerWeaponState",           "i" };
	static const Native GetPlayerTargetPlayer          = { "GetPlayerTargetPlayer",          "i" };
	static const Native SetPlayerTeam                  = { "SetPlayerTeam",                  "ii" };
	static const Native GetPlayerTeam                  = { "GetPlayerTeam",                  "i" };
	static const Native SetPlayerScore                 = { "SetPlayerScore",                 "ii" };
	static const Native GetPlayerScore                 = { "GetPlayerScore",                 "i" };
	static const Native GetPlayerDrunkLevel            = { "GetPlayerDrunkLevel",            "i" };
	static const Native SetPlayerDrunkLevel            = { "SetPlayerDrunkLevel",            "ii" };
	static const Native SetPlayerColor                 = { "SetPlayerColor",                 "ii" };
	static const Native GetPlayerColor                 = { "GetPlayerColor",                 "i" };
	static const Native SetPlayerSkin                  = { "SetPlayerSkin",                  "ii" };
	static const Native GetPlayerSkin                  = { "GetPlayerSkin",                  "i" };
	static const Native GivePlayerWeapon               = { "GivePlayerWeapon",               "iii" };
	static const Native ResetPlayerWeapons             = { "ResetPlayerWeapons",             "i" };
	static const Native SetPlayerArmedWeapon           = { "SetPlayerArmedWeapon",           "ii" };
	static const Native GetPlayerWeaponData            = { "GetPlayerWeaponData",            "iivv" };
	static const Native GivePlayerMoney                = { "GivePlayerMoney",                "ii" };
	static const Native ResetPlayerMoney               = { "ResetPlayerMoney",               "i" };
	static const Native SetPlayerName                  = { "SetPlayerName",                  "is" };
	static const Native GetPlayerMoney                 = { "GetPlayerMoney",                 "i" };
	static const Native GetPlayerState                 = { "GetPlayerState",                 "i" };
	static const Native GetPlayerIp                    = { "GetPlayerIp",                    "ipi" };
	static const Native GetPlayerPing                  = { "GetPlayerPing",                  "i" };
	static const Native GetPlayerWeapon                = { "GetPlayerWeapon",                "i" };
	static const Native GetPlayerKeys                  = { "GetPlayerKeys",                  "ivvv" };
	static const Native GetPlayerName                  = { "GetPlayerName",                  "ipi" };
	static const Native SetPlayerTime                  = { "SetPlayerTime",                  "iii" };
	static const Native GetPlayerTime                  = { "GetPlayerTime",                  "ivv" };
	static const Native TogglePlayerClock              = { "TogglePlayerClock",              "ii" };
	static const Native SetPlayerWeather               = { "SetPlayerWeather",               "ii" };
	static const Native ForceClassSelection            = { "ForceClassSelection",            "i" };
	static const Native SetPlayerWantedLevel           = { "SetPlayerWantedLevel",           "ii" };
	static const Native GetPlayerWantedLevel           = { "GetPlayerWantedLevel",           "i" };
	static const Native SetPlayerFightingStyle         = { "SetPlayerFightingStyle",         "ii" };
	static const Native GetPlayerFightingStyle         = { "GetPlayerFightingStyle",         "i" };
	static const Native SetPlayerVelocity              = { "SetPlayerVelocity",              "ifff" };
	static const Native GetPlayerVelocity              = { "GetPlayerVelocity",              "ivvv" };
	static const Native PlayCrimeReportForPlayer       = { "PlayCrimeReportForPlayer",       "iii" };
	static const Native PlayAudioStreamForPlayer       = { "PlayAudioStreamForPlayer",       "isffffi" };
	static const Native StopAudioStreamForPlayer       = { "StopAudioStreamForPlayer",       "i" };
	static const Native SetPlayerShopName              = { "SetPlayerShopName",              "is" };
	static const Native SetPlayerSkillLevel            = { "SetPlayerSkillLevel",            "iii" };
	static const Native GetPlayerSurfingVehicleID      = { "GetPlayerSurfingVehicleID",      "i" };
	static const Native GetPlayerSurfingObjectID       = { "GetPlayerSurfingObjectID",       "i" };
	static const Native RemoveBuildingForPlayer        = { "RemoveBuildingForPlayer",        "iiffff" };

	// Attached to bone objects
	static const Native SetPlayerAttachedObject        = { "SetPlayerAttachedObject",        "iiiifffffffffii" };
	static const Native RemovePlayerAttachedObject     = { "RemovePlayerAttachedObject",     "ii" };
	static const Native IsPlayerAttachedObjectSlotUsed = { "IsPlayerAttachedObjectSlotUsed", "ii" };
	static const Native EditAttachedObject             = { "EditAttachedObject",             "ii" };

	// Per-player TextDraws
	static const Native CreatePlayerTextDraw           = { "CreatePlayerTextDraw",           "iffs" };
	static const Native PlayerTextDrawDestroy          = { "PlayerTextDrawDestroy",          "ii" };
	static const Native PlayerTextDrawLetterSize       = { "PlayerTextDrawLetterSize",       "iiff" };
	static const Native PlayerTextDrawTextSize         = { "PlayerTextDrawTextSize",         "iiff" };
	static const Native PlayerTextDrawAlignment        = { "PlayerTextDrawAlignment",        "iii" };
	static const Native PlayerTextDrawColor            = { "PlayerTextDrawColor",            "iii" };
	static const Native PlayerTextDrawUseBox           = { "PlayerTextDrawUseBox",           "iii" };
	static const Native PlayerTextDrawBoxColor         = { "PlayerTextDrawBoxColor",         "iii" };
	static const Native PlayerTextDrawSetShadow        = { "PlayerTextDrawSetShadow",        "iii" };
	static const Native PlayerTextDrawSetOutline       = { "PlayerTextDrawSetOutline",       "iii" };
	static const Native PlayerTextDrawBackgroundColor  = { "PlayerTextDrawBackgroundColor",  "iii" };
	static const Native PlayerTextDrawFont             = { "PlayerTextDrawFont",             "iii" };
	static const Native PlayerTextDrawSetProportional  = { "PlayerTextDrawSetProportional",  "iii" };
	static const Native PlayerTextDrawSetSelectable    = { "PlayerTextDrawSetSelectable",    "iii" };
	static const Native PlayerTextDrawShow             = { "PlayerTextDrawShow",             "ii" };
	static const Native PlayerTextDrawHide             = { "PlayerTextDrawHide",             "ii" };
	static const Native PlayerTextDrawSetString        = { "PlayerTextDrawSetString",        "iis" };

	// Per-player variable system (PVars)
	static const Native SetPVarInt                     = { "SetPVarInt",                     "isi" };
	static const Native GetPVarInt                     = { "GetPVarInt",                     "is" };
	static const Native SetPVarString                  = { "SetPVarString",                  "iss" };
	static const Native GetPVarString                  = { "GetPVarString",                  "ispi" };
	static const Native SetPVarFloat                   = { "SetPVarFloat",                   "isf" };
	static const Native GetPVarFloat                   = { "GetPVarFloat",                   "is" };
	static const Native DeletePVar                     = { "DeletePVar",                     "is" };

	// PVar enumeration
	static const Native GetPVarsUpperIndex             = { "GetPVarsUpperIndex",             "i" };
	static const Native GetPVarNameAtIndex             = { "GetPVarNameAtIndex",             "iisi" };
	static const Native GetPVarType                    = { "GetPVarType",                    "is" };

	// Chat bubble (does this belong in a group?)
	static const Native SetPlayerChatBubble            = { "SetPlayerChatBubble",            "isifi" };

	// Player controls
	static const Native PutPlayerInVehicle             = { "PutPlayerInVehicle",             "iii" };
	static const Native GetPlayerVehicleID             = { "GetPlayerVehicleID",             "i" };
	static const Native GetPlayerVehicleSeat           = { "GetPlayerVehicleSeat",           "i" };
	static const Native RemovePlayerFromVehicle        = { "RemovePlayerFromVehicle",        "i" };
	static const Native TogglePlayerControllable       = { "TogglePlayerControllable",       "ii" };
	static const Native PlayerPlaySound                = { "PlayerPlaySound",                "iifff" };
	static const Native ApplyAnimation                 = { "ApplyAnimation",                 "issfiiiiii" };
	static const Native ClearAnimations                = { "ClearAnimations",                "ii" };
	static const Native GetPlayerAnimationIndex        = { "GetPlayerAnimationIndex",        "i" };
	static const Native GetAnimationName               = { "GetAnimationName",               "isisi" };
	static const Native GetPlayerSpecialAction         = { "GetPlayerSpecialAction",         "i" };
	static const Native SetPlayerSpecialAction         = { "SetPlayerSpecialAction",         "ii" };

	// Player world/map related
	static const Native SetPlayerCheckpoint            = { "SetPlayerCheckpoint",            "iffff" };
	static const Native DisablePlayerCheckpoint        = { "DisablePlayerCheckpoint",        "i" };
	static const Native SetPlayerRaceCheckpoint        = { "SetPlayerRaceCheckpoint",        "iifffffff" };
	static const Native DisablePlayerRaceCheckpoint    = { "DisablePlayerRaceCheckpoint",    "i" };
	static const Native SetPlayerWorldBounds           = { "SetPlayerWorldBounds",           "iffff" };
	static const Native SetPlayerMarkerForPlayer       = { "SetPlayerMarkerForPlayer",       "iii" };
	static const Native ShowPlayerNameTagForPlayer     = { "ShowPlayerNameTagForPlayer",     "iii" };
	static const Native SetPlayerMapIcon               = { "SetPlayerMapIcon",               "iifffiii" };
	static const Native RemovePlayerMapIcon            = { "RemovePlayerMapIcon",            "ii" };
	static const Native AllowPlayerTeleport            = { "AllowPlayerTeleport",            "ii" };

	// Player camera
	static const Native SetPlayerCameraPos             = { "SetPlayerCameraPos",             "ifff" };
	static const Native SetPlayerCameraLookAt          = { "SetPlayerCameraLookAt",          "ifffi" };
	static const Native SetCameraBehindPlayer          = { "SetCameraBehindPlayer",          "i" };
	static const Native GetPlayerCameraPos             = { "GetPlayerCameraPos",             "ivvv" };
	static const Native GetPlayerCameraFrontVector     = { "GetPlayerCameraFrontVector",     "ivvv" };
	static const Native GetPlayerCameraMode            = { "GetPlayerCameraMode",            "i" };
	static const Native AttachCameraToObject           = { "AttachCameraToObject",           "ii" };
	static const Native AttachCameraToPlayerObject     = { "AttachCameraToPlayerObject",     "ii" };
	static const Native InterpolateCameraPos           = { "InterpolateCameraPos",           "iffffffii" };
	static const Native InterpolateCameraLookAt        = { "InterpolateCameraLookAt",        "iffffffii" };

	// Player conditionals
	static const Native IsPlayerConnected              = { "IsPlayerConnected",              "i" };
	static const Native IsPlayerInVehicle              = { "IsPlayerInVehicle",              "ii" };
	static const Native IsPlayerInAnyVehicle           = { "IsPlayerInAnyVehicle",           "i" };
	static const Native IsPlayerInCheckpoint           = { "IsPlayerInCheckpoint",           "i" };
	static const Native IsPlayerInRaceCheckpoint       = { "IsPlayerInRaceCheckpoint",       "i" };

	// Virtual Worlds
	static const Native SetPlayerVirtualWorld          = { "SetPlayerVirtualWorld",          "ii" };
	static const Native GetPlayerVirtualWorld          = { "GetPlayerVirtualWorld",          "i" };

	// Insane Stunts
	static const Native EnableStuntBonusForPlayer      = { "EnableStuntBonusForPlayer",      "ii" };
	static const Native EnableStuntBonusForAll         = { "EnableStuntBonusForAll",         "i" };

	// Spectating
	static const Native TogglePlayerSpectating         = { "TogglePlayerSpectating",         "ii" };
	static const Native PlayerSpectatePlayer           = { "PlayerSpectatePlayer",           "iii" };
	static const Native PlayerSpectateVehicle          = { "PlayerSpectateVehicle",          "iii" };

	// Recording for NPC playback
	static const Native StartRecordingPlayerData       = { "StartRecordingPlayerData",       "iis" };
	static const Native StopRecordingPlayerData        = { "StopRecordingPlayerData",        "i" };
	static const Native SelectTextDraw                 = { "SelectTextDraw",                 "ii" };
	static const Native CancelSelectTextDraw           = { "CancelSelectTextDraw",           "i" };
	#pragma endregion
	
	// a_vehicles.inc
	#pragma region a_vehicles.inc
	
	// Vehicle
	static const Native CreateVehicle                = { "CreateVehicle",                "iffffiii" };
	static const Native DestroyVehicle               = { "DestroyVehicle",               "i" };
	static const Native IsVehicleStreamedIn          = { "IsVehicleStreamedIn",          "ii" };
	static const Native GetVehiclePos                = { "GetVehiclePos",                "ivvv" };
	static const Native SetVehiclePos                = { "SetVehiclePos",                "ifff" };
	static const Native GetVehicleZAngle             = { "GetVehicleZAngle",             "iv" };
	static const Native GetVehicleRotationQuat       = { "GetVehicleRotationQuat",       "ivvvv" };
	static const Native GetVehicleDistanceFromPoint  = { "GetVehicleDistanceFromPoint",  "ifff" };
	static const Native SetVehicleZAngle             = { "SetVehicleZAngle",             "if" };
	static const Native SetVehicleParamsForPlayer    = { "SetVehicleParamsForPlayer",    "iiii" };
	static const Native ManualVehicleEngineAndLights = { "ManualVehicleEngineAndLights", "" };
	static const Native SetVehicleParamsEx           = { "SetVehicleParamsEx",           "iiiiiiii" };
	static const Native GetVehicleParamsEx           = { "GetVehicleParamsEx",           "ivvvvvvv" };
	static const Native SetVehicleToRespawn          = { "SetVehicleToRespawn",          "i" };
	static const Native LinkVehicleToInterior        = { "LinkVehicleToInterior",        "ii" };
	static const Native AddVehicleComponent          = { "AddVehicleComponent",          "ii" };
	static const Native RemoveVehicleComponent       = { "RemoveVehicleComponent",       "ii" };
	static const Native ChangeVehicleColor           = { "ChangeVehicleColor",           "iii" };
	static const Native ChangeVehiclePaintjob        = { "ChangeVehiclePaintjob",        "ii" };
	static const Native SetVehicleHealth             = { "SetVehicleHealth",             "if" };
	static const Native GetVehicleHealth             = { "GetVehicleHealth",             "iv" };
	static const Native AttachTrailerToVehicle       = { "AttachTrailerToVehicle",       "ii" };
	static const Native DetachTrailerFromVehicle     = { "DetachTrailerFromVehicle",     "i" };
	static const Native IsTrailerAttachedToVehicle   = { "IsTrailerAttachedToVehicle",   "i" };
	static const Native GetVehicleTrailer            = { "GetVehicleTrailer",            "i" };
	static const Native SetVehicleNumberPlate        = { "SetVehicleNumberPlate",        "is" };
	static const Native GetVehicleModel              = { "GetVehicleModel",              "i" };
	static const Native GetVehicleComponentInSlot    = { "GetVehicleComponentInSlot",    "ii" };
	static const Native GetVehicleComponentType      = { "GetVehicleComponentType",      "i" };
	static const Native RepairVehicle                = { "RepairVehicle",                "i" };
	static const Native GetVehicleVelocity           = { "GetVehicleVelocity",           "ivvv" };
	static const Native SetVehicleVelocity           = { "SetVehicleVelocity",           "ifff" };
	static const Native SetVehicleAngularVelocity    = { "SetVehicleAngularVelocity",    "ifff" };
	static const Native GetVehicleDamageStatus       = { "GetVehicleDamageStatus",       "ivvvv" };
	static const Native UpdateVehicleDamageStatus    = { "UpdateVehicleDamageStatus",    "iiiii" };
	static const Native GetVehicleModelInfo          = { "GetVehicleModelInfo",          "iivvv" };
	static const Native SetVehicleVirtualWorld       = { "SetVehicleVirtualWorld",       "ii" };
	static const Native GetVehicleVirtualWorld       = { "GetVehicleVirtualWorld",       "i" };
	#pragma endregion
	
	// a_objects.inc
	#pragma region a_objects.inc
	
	// Objects
	static const Native CreateObject                = { "CreateObject",                "ifffffff" };
	static const Native AttachObjectToVehicle       = { "AttachObjectToVehicle",       "iiffffff" };
	static const Native AttachObjectToObject        = { "AttachObjectToObject",        "iiffffffi" };
	static const Native AttachObjectToPlayer        = { "AttachObjectToPlayer",        "iiffffff" };
	static const Native SetObjectPos                = { "SetObjectPos",                "ifff" };
	static const Native GetObjectPos                = { "GetObjectPos",                "ivvv" };
	static const Native SetObjectRot                = { "SetObjectRot",                "ifff" };
	static const Native GetObjectRot                = { "GetObjectRot",                "ivvv" };
	static const Native IsValidObject               = { "IsValidObject",               "i" };
	static const Native DestroyObject               = { "DestroyObject",               "i" };
	static const Native MoveObject                  = { "MoveObject",                  "ifffffff" };
	static const Native StopObject                  = { "StopObject",                  "i" };
	static const Native IsObjectMoving              = { "IsObjectMoving",              "i" };
	static const Native EditObject                  = { "EditObject",                  "ii" };
	static const Native EditPlayerObject            = { "EditPlayerObject",            "ii" };
	static const Native SelectObject                = { "SelectObject",                "i" };
	static const Native CancelEdit                  = { "CancelEdit",                  "i" };
	static const Native CreatePlayerObject          = { "CreatePlayerObject",          "iifffffff" };
	static const Native AttachPlayerObjectToVehicle = { "AttachPlayerObjectToVehicle", "iiiffffff" };
	static const Native SetPlayerObjectPos          = { "SetPlayerObjectPos",          "iifff" };
	static const Native GetPlayerObjectPos          = { "GetPlayerObjectPos",          "iivvv" };
	static const Native SetPlayerObjectRot          = { "SetPlayerObjectRot",          "iifff" };
	static const Native GetPlayerObjectRot          = { "GetPlayerObjectRot",          "iivvv" };
	static const Native IsValidPlayerObject         = { "IsValidPlayerObject",         "ii" };
	static const Native DestroyPlayerObject         = { "DestroyPlayerObject",         "ii" };
	static const Native MovePlayerObject            = { "MovePlayerObject",            "iifffffff" };
	static const Native StopPlayerObject            = { "StopPlayerObject",            "ii" };
	static const Native IsPlayerObjectMoving        = { "IsPlayerObjectMoving",        "ii" };
	static const Native AttachPlayerObjectToPlayer  = { "AttachPlayerObjectToPlayer",  "iiiffffff" };
	static const Native SetObjectMaterial           = { "SetObjectMaterial",           "iiissi" };
	static const Native SetPlayerObjectMaterial     = { "SetPlayerObjectMaterial",     "iiiissi" };
	static const Native SetObjectMaterialText       = { "SetObjectMaterialText",       "isiiiiiiii" };
	static const Native SetPlayerObjectMaterialText = { "SetPlayerObjectMaterialText", "iisiiiiiiii" };
	#pragma endregion
};

class
	Invoke
{
public:
	Invoke()
	{
		gotAddresses = false;
	}


	int callNative(const PAWN::Native * native, ...);
	int getAddresses();

	int amx_idx;

	std::list<AMX *> amx_list;
private:
	bool gotAddresses;

	std::map<std::string, unsigned int> amx_map;
};

typedef int (* amx_Function_t)(AMX * amx, cell * params);

extern Invoke *g_Invoke;
