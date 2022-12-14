#ifndef A_PLAYERS_H
#define A_PLAYERS_H

PLUGIN_EXPORT void         _samp_SetSpawnInfo(int playerid, int team, int skin, float x, float y, float z, float rotation, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
PLUGIN_EXPORT void         _samp_SpawnPlayer(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerPos(int playerid, float x, float y, float z);
PLUGIN_EXPORT void         _samp_SetPlayerPosFindZ(int playerid, float x, float y, float z);
PLUGIN_EXPORT void         _samp_GetPlayerPos(int playerid, float& x, float& y, float& z);
PLUGIN_EXPORT void         _samp_SetPlayerFacingAngle(int playerid, float ang);
PLUGIN_EXPORT void         _samp_GetPlayerFacingAngle(int playerid, float& ang);
//void IsPlayerInRangeOfPoint(int playerid, float range, float x, float y, float z);
//float GetPlayerDistanceFromPoint(int playerid, float x, float y, float z);
PLUGIN_EXPORT int          _samp_IsPlayerStreamedIn(int playerid, int forplayerid);
PLUGIN_EXPORT void         _samp_SetPlayerInterior(int playerid, int interiorid);
PLUGIN_EXPORT int          _samp_GetPlayerInterior(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerHealth(int playerid, float health);
PLUGIN_EXPORT void         _samp_GetPlayerHealth(int playerid, float& health);
PLUGIN_EXPORT void         _samp_SetPlayerArmour(int playerid, float armour);
PLUGIN_EXPORT void         _samp_GetPlayerArmour(int playerid, float& armour);
PLUGIN_EXPORT void         _samp_SetPlayerAmmo(int playerid, int weaponslot, int ammo);
PLUGIN_EXPORT int          _samp_GetPlayerAmmo(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerWeaponState(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerTargetPlayer(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerTeam(int playerid, int teamid);
PLUGIN_EXPORT int          _samp_GetPlayerTeam(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerScore(int playerid, int score);
PLUGIN_EXPORT int          _samp_GetPlayerScore(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerDrunkLevel(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerDrunkLevel(int playerid, int level);
PLUGIN_EXPORT void         _samp_SetPlayerColor(int playerid, int color);
PLUGIN_EXPORT unsigned int _samp_GetPlayerColor(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerSkin(int playerid, int skinid);
PLUGIN_EXPORT int          _samp_GetPlayerSkin(int playerid);
PLUGIN_EXPORT void         _samp_GivePlayerWeapon(int playerid, int weaponid, int ammo);
PLUGIN_EXPORT void         _samp_ResetPlayerWeapons(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerArmedWeapon(int playerid, int weaponid);
PLUGIN_EXPORT void         _samp_GetPlayerWeaponData(int playerid, int slot, int& weapons, int& ammo);
PLUGIN_EXPORT void         _samp_GivePlayerMoney(int playerid, int money);
PLUGIN_EXPORT void         _samp_ResetPlayerMoney(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerName(int playerid, char* name);
PLUGIN_EXPORT int          _samp_GetPlayerMoney(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerState(int playerid);
PLUGIN_EXPORT void         _samp_GetPlayerIp(int playerid, char* name, int len);
PLUGIN_EXPORT int          _samp_GetPlayerPing(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerWeapon(int playerid);
PLUGIN_EXPORT void         _samp_GetPlayerKeys(int playerid, int& keys, int& updown, int& leftright);
PLUGIN_EXPORT void         _samp_GetPlayerName(int playerid, char* name, int len);
PLUGIN_EXPORT void         _samp_SetPlayerTime(int playerid, int hour, int minute);
PLUGIN_EXPORT void         _samp_GetPlayerTime(int playerid, int& hour, int& minute);
PLUGIN_EXPORT void         _samp_TogglePlayerClock(int playerid, int toggle);
PLUGIN_EXPORT void         _samp_SetPlayerWeather(int playerid, int weather);
PLUGIN_EXPORT void         _samp_ForceClassSelection(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerWantedLevel(int playerid, int level);
PLUGIN_EXPORT int          _samp_GetPlayerWantedLevel(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerFightingStyle(int playerid, int style);
PLUGIN_EXPORT int          _samp_GetPlayerFightingStyle(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerVelocity(int playerid, float x, float y, float z);
PLUGIN_EXPORT void         _samp_GetPlayerVelocity(int playerid, float& x, float& y, float& z);
PLUGIN_EXPORT void         _samp_PlayCrimeReportForPlayer(int playerid, int suspectid, int crime);
PLUGIN_EXPORT void         _samp_PlayAudioStreamForPlayer(int playerid, char* url, float posx=0.0, float posy=0.0, float posz=0.0, float distance=50.0, int usepos=0);
PLUGIN_EXPORT void         _samp_StopAudioStreamForPlayer(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerShopName(int playerid, char* shopname);
PLUGIN_EXPORT void         _samp_SetPlayerSkillLevel(int playerid, int skill, int level);
PLUGIN_EXPORT int          _samp_GetPlayerSurfingVehicleID(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerSurfingObjectID(int playerid);
PLUGIN_EXPORT void         _samp_RemoveBuildingForPlayer(int playerid, int modelid, float fx, float fy, float fz, float fradius);
PLUGIN_EXPORT void         _samp_SetPlayerAttachedObject(int playerid, int index, int modelid, int bone, float foffsetx=0.0, float foffsety=0.0, float foffsetz=0.0, float frotx=0.0, float froty=0.0, float frotz=0.0, float fscalex=1.0, float fscaley=1.0, float fscalez=1.0, int materialcolor1=0, int materialcolor2=0);
PLUGIN_EXPORT void         _samp_RemovePlayerAttachedObject(int playerid, int index);
PLUGIN_EXPORT void         _samp_IsPlayerAttachedObjectSlotUsed(int playerid, int index);
PLUGIN_EXPORT void         _samp_EditAttachedObject(int playerid, int index);
PLUGIN_EXPORT int          _samp_CreatePlayerTextDraw(int playerid, float x, float y, char* text);
PLUGIN_EXPORT void         _samp_PlayerTextDrawDestroy(int playerid, int text);
PLUGIN_EXPORT void         _samp_PlayerTextDrawLetterSize(int playerid, int text, float x, float y);
PLUGIN_EXPORT void         _samp_PlayerTextDrawTextSize(int playerid, int text, float x, float y);
PLUGIN_EXPORT void         _samp_PlayerTextDrawAlignment(int playerid, int text, int alignment);
PLUGIN_EXPORT void         _samp_PlayerTextDrawColor(int playerid, int text, int color);
PLUGIN_EXPORT void         _samp_PlayerTextDrawUseBox(int playerid, int text, int use);
PLUGIN_EXPORT void         _samp_PlayerTextDrawBoxColor(int playerid, int text, int color);
PLUGIN_EXPORT void         _samp_PlayerTextDrawSetShadow(int playerid, int text, int size);
PLUGIN_EXPORT void         _samp_PlayerTextDrawSetOutline(int playerid, int text, int size);
PLUGIN_EXPORT void         _samp_PlayerTextDrawBackgroundColor(int playerid, int text, int color);
PLUGIN_EXPORT void         _samp_PlayerTextDrawFont(int playerid, int text, int font);
PLUGIN_EXPORT void         _samp_PlayerTextDrawSetProportional(int playerid, int text, int set);
PLUGIN_EXPORT void         _samp_PlayerTextDrawSetSelectable(int playerid, int text, int set);
PLUGIN_EXPORT void         _samp_PlayerTextDrawShow(int playerid, int text);
PLUGIN_EXPORT void         _samp_PlayerTextDrawHide(int playerid, int text);
PLUGIN_EXPORT void         _samp_PlayerTextDrawSetString(int playerid, int text, char* string);
PLUGIN_EXPORT void         _samp_SetPVarInt(int playerid, char* varname, int int_value);
PLUGIN_EXPORT void         _samp_GetPVarInt(int playerid, char* varname);
PLUGIN_EXPORT void         _samp_SetPVarString(int playerid, char* varname, char* string_value);
PLUGIN_EXPORT void         _samp_GetPVarString(int playerid, char* varname, char* string_return, int len);
PLUGIN_EXPORT void         _samp_SetPVarFloat(int playerid, char* varname, float float_value);
PLUGIN_EXPORT float        _samp_GetPVarFloat(int playerid, char* varname);
PLUGIN_EXPORT void         _samp_DeletePVar(int playerid, char* varname);
PLUGIN_EXPORT int          _samp_GetPVarsUpperIndex(int playerid);
PLUGIN_EXPORT void         _samp_GetPVarNameAtIndex(int playerid, int index, char* ret_varname, int ret_len);
PLUGIN_EXPORT int          _samp_GetPVarType(int playerid, char* varname);
PLUGIN_EXPORT void         _samp_SetPlayerChatBubble(int playerid, char* text, int color, float drawdistance, int expiretime);
PLUGIN_EXPORT void         _samp_PutPlayerInVehicle(int playerid, int vehicleid, int seatid);
PLUGIN_EXPORT int          _samp_GetPlayerVehicleID(int playerid);
PLUGIN_EXPORT int          _samp_GetPlayerVehicleSeat(int playerid);
PLUGIN_EXPORT void         _samp_RemovePlayerFromVehicle(int playerid);
PLUGIN_EXPORT void         _samp_TogglePlayerControllable(int playerid, int toggle);
PLUGIN_EXPORT void         _samp_PlayerPlaySound(int playerid, int soundid, float x, float y, float z);
PLUGIN_EXPORT void         _samp_ApplyAnimation(int playerid, char* animlib, char* animname, float fdelta, int loop, int lockx, int locky, int freeze, int time, int forcesync=0);
PLUGIN_EXPORT void         _samp_ClearAnimations(int playerid, int forcesync=0);
PLUGIN_EXPORT int          _samp_GetPlayerAnimationIndex(int playerid);
PLUGIN_EXPORT void         _samp_GetAnimationName(int index, char* animlib, int len1, char* animname, int len2);
PLUGIN_EXPORT int          _samp_GetPlayerSpecialAction(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerSpecialAction(int playerid, int actionid);
PLUGIN_EXPORT void         _samp_SetPlayerCheckpoint(int playerid, float x, float y, float z, float size);
PLUGIN_EXPORT void         _samp_DisablePlayerCheckpoint(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerRaceCheckpoint(int playerid, int type, float x, float y, float z, float nextx, float nexty, float nextz, float size);
PLUGIN_EXPORT void         _samp_DisablePlayerRaceCheckpoint(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerWorldBounds(int playerid, float x_max, float x_min, float y_max, float y_min);
PLUGIN_EXPORT void         _samp_SetPlayerMarkerForPlayer(int playerid, int showplayerid, int color);
PLUGIN_EXPORT void         _samp_ShowPlayerNameTagForPlayer(int playerid, int showplayerid, int show);
PLUGIN_EXPORT void         _samp_SetPlayerMapIcon(int playerid, int iconid, float x, float y, float z, int markertype, int color, int style=0);
PLUGIN_EXPORT void         _samp_RemovePlayerMapIcon(int playerid, int iconid);
PLUGIN_EXPORT void         _samp_AllowPlayerTeleport(int playerid, int allow);
PLUGIN_EXPORT void         _samp_SetPlayerCameraPos(int playerid, float x, float y, float z);
PLUGIN_EXPORT void         _samp_SetPlayerCameraLookAt(int playerid, float x, float y, float z, int cut=2);
PLUGIN_EXPORT void         _samp_SetCameraBehindPlayer(int playerid);
PLUGIN_EXPORT void         _samp_GetPlayerCameraPos(int playerid, float& x, float& y, float& z);
PLUGIN_EXPORT void         _samp_GetPlayerCameraFrontVector(int playerid, float& x, float& y, float& z);
PLUGIN_EXPORT int          _samp_GetPlayerCameraMode(int playerid);
PLUGIN_EXPORT void         _samp_AttachCameraToObject(int playerid, int objectid);
PLUGIN_EXPORT void         _samp_AttachCameraToPlayerObject(int playerid, int playerobjectid);
PLUGIN_EXPORT void         _samp_InterpolateCameraPos(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut=2);
PLUGIN_EXPORT void         _samp_InterpolateCameraLookAt(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut=2);
PLUGIN_EXPORT int          _samp_IsPlayerConnected(int playerid);
PLUGIN_EXPORT int          _samp_IsPlayerInVehicle(int playerid, int vehicleid);
PLUGIN_EXPORT int          _samp_IsPlayerInAnyVehicle(int playerid);
PLUGIN_EXPORT int          _samp_IsPlayerInCheckpoint(int playerid);
PLUGIN_EXPORT int          _samp_IsPlayerInRaceCheckpoint(int playerid);
PLUGIN_EXPORT void         _samp_SetPlayerVirtualWorld(int playerid, int worldid);
PLUGIN_EXPORT int          _samp_GetPlayerVirtualWorld(int playerid);
PLUGIN_EXPORT void         _samp_EnableStuntBonusForPlayer(int playerid, int enable);
PLUGIN_EXPORT void         _samp_EnableStuntBonusForAll(int enable);
PLUGIN_EXPORT void         _samp_TogglePlayerSpectating(int playerid, int toggle);
PLUGIN_EXPORT void         _samp_PlayerSpectatePlayer(int playerid, int targetplayerid, int mode=1);
PLUGIN_EXPORT void         _samp_PlayerSpectateVehicle(int playerid, int targetvehicleid, int mode=1);
PLUGIN_EXPORT void         _samp_StartRecordingPlayerData(int playerid, int recordtype, char* recordname);
PLUGIN_EXPORT void         _samp_StopRecordingPlayerData(int playerid);
PLUGIN_EXPORT void         _samp_SelectTextDraw(int playerid, int hovercolor);
PLUGIN_EXPORT void         _samp_CancelSelectTextDraw(int playerid);

#endif // A_PLAYERS_H

