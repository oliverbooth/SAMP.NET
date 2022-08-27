using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SAMP.Core
{
    internal class Natives
    {
        [DllImport("__Internal", EntryPoint="fnlogprintf")]
        public static extern void logprintf(string message);

        // a_samp.inc
        #region a_samp.inc
        // Util
        [DllImport("__Internal", EntryPoint="SendClientMessage")]
        public static extern void SendClientMessage(int playerid, uint color, string message);
        [DllImport("__Internal", EntryPoint="SendClientMessageToAll")]
        public static extern void SendClientMessageToAll(uint color, string message);
        [DllImport("__Internal", EntryPoint="SendPlayerMessageToPlayer")]
        public static extern void SendPlayerMessageToPlayer(int playerid, int senderid, string message);
        [DllImport("__Internal", EntryPoint="SendPlayerMessageToAll")]
        public static extern void SendPlayerMessageToAll(int senderid, string message);
        [DllImport("__Internal", EntryPoint="SendDeathMessage")]
        public static extern void SendDeathMessage(int killer, int killee, int weapon);
        [DllImport("__Internal", EntryPoint="GameTextForAll")]
        public static extern void GameTextForAll(string str, int time, int style);
        [DllImport("__Internal", EntryPoint="GameTextForPlayer")]
        public static extern void GameTextForPlayer(int playerid, string str, int time, int style);
        [DllImport("__Internal", EntryPoint="_GetTickCount")]
        public static extern int GetTickCount();
        [DllImport("__Internal", EntryPoint="GetMaxPlayers")]
        public static extern int GetMaxPlayers();

        // Game
        [DllImport("__Internal", EntryPoint="SetGameModeText")]
        public static extern void SetGameModeText(string str);
        [DllImport("__Internal", EntryPoint="SetTeamCount")]
        public static extern void SetTeamCount(int count); // No effect
        [DllImport("__Internal", EntryPoint="AddPlayerClass")]
        public static extern int AddPlayerClass(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
        [DllImport("__Internal", EntryPoint="AddPlayerClassEx")]
        public static extern int AddPlayerClassEx(int teamid, int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
        [DllImport("__Internal", EntryPoint="AddStaticVehicle")]
        public static extern int AddStaticVehicle(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, uint color1, uint color2);
        [DllImport("__Internal", EntryPoint="AddStaticVehicleEx")]
        public static extern int AddStaticVehicleEx(int modelid, float spawn_x, float spawn_y, float spawn_z, float z_angle, uint color1, uint color2, int respawn_delay);
        [DllImport("__Internal", EntryPoint="AddStaticPickup")]
        public static extern int AddStaticPickup(int model, int type, float x, float y, float z, int virtualworld=0);
        [DllImport("__Internal", EntryPoint="CreatePickup")]
        public static extern int CreatePickup(int model, int type, float x, float y, float z, int virtualworld=0);
        [DllImport("__Internal", EntryPoint="DestroyPickup")]
        public static extern void DestroyPickup(int pickup);
        [DllImport("__Internal", EntryPoint="ShowNameTags")]
        public static extern void ShowNameTags(int show);
        [DllImport("__Internal", EntryPoint="ShowPlayerMarkers")]
        public static extern void ShowPlayerMarkers(int mode);
        [DllImport("__Internal", EntryPoint="GameModeExit")]
        public static extern void GameModeExit();
        [DllImport("__Internal", EntryPoint="SetWorldTime")]
        public static extern void SetWorldTime(int hour);
        [DllImport("__Internal", EntryPoint="GetWeaponName")]
        public static extern void GetWeaponName(int weaponid, StringBuilder weapon, int len);
        [Obsolete("This function was removed in SA-MP 0.3. Tire popping is enabled by default.", false)]
        [DllImport("__Internal", EntryPoint="EnableTirePopping")]
        public static extern void EnableTirePopping(int enable); // Deprecated
        [DllImport("__Internal", EntryPoint="AllowInteriorWeapons")]
        public static extern void AllowInteriorWeapons(int allow);
        [DllImport("__Internal", EntryPoint="SetWeather")]
        public static extern void SetWeather(int weatherid);
        [DllImport("__Internal", EntryPoint="SetGravity")]
        public static extern void SetGravity(float gravity);
        [Obsolete("This function is deprecated. Please see the SAMP.API.Player.OnClickMap event.", true)]
        [DllImport("__Internal", EntryPoint="AllowAdminTeleport")]
        public static extern void AllowAdminTeleport(int allow); // Deprecated
        [Obsolete("This function is deprecated.", true)]
        [DllImport("__Internal", EntryPoint="SetDeathDropAmount")]
        public static extern void SetDeathDropAmount(int amount); // Deprecated
        [DllImport("__Internal", EntryPoint="CreateExplosion")]
        public static extern int CreateExplosion(float x, float y, float z, int type, float radius);
        [DllImport("__Internal", EntryPoint="EnableZoneNames")]
        public static extern void EnableZoneNames(int enable);
        [DllImport("__Internal", EntryPoint="UsePlayerPedAnims")]
        public static extern void UsePlayerPedAnims();
        [DllImport("__Internal", EntryPoint="DisableInteriorEnterExits")]
        public static extern void DisableInteriorEnterExits();
        [DllImport("__Internal", EntryPoint="SetNameTagDrawDistance")]
        public static extern void SetNameTagDrawDistance(float distance);
        [DllImport("__Internal", EntryPoint="DisableNameTagLOS")]
        public static extern void DisableNameTagLOS();
        [DllImport("__Internal", EntryPoint="LimitGlobalChatRadius")]
        public static extern void LimitGlobalChatRadius(float chat_radius);
        [DllImport("__Internal", EntryPoint="LimitPlayerMarkerRadius")]
        public static extern void LimitPlayerMarkerRadius(float marker_radius);

        // Npc
        // These functions are not yet implemented into the SAMP.NET library
        [DllImport("__Internal", EntryPoint="ConnectNPC")]
        public static extern void ConnectNPC(string name, string script);
        [DllImport("__Internal", EntryPoint="IsPlayerNPC")]
        public static extern int IsPlayerNPC(int playerid);

        // Admin
        [DllImport("__Internal", EntryPoint="IsPlayerAdmin")]
        public static extern int IsPlayerAdmin(int playerid);
        [DllImport("__Internal", EntryPoint="Kick")]
        public static extern void Kick(int playerid);
        [DllImport("__Internal", EntryPoint="Ban")]
        public static extern void Ban(int playerid);
        [DllImport("__Internal", EntryPoint="BanEx")]
        public static extern void BanEx(int playerid, string reason);
        [DllImport("__Internal", EntryPoint="SendRconCommand")]
        public static extern void SendRconCommand(string command);
        [DllImport("__Internal", EntryPoint="GetServerVarAsString")]
        public static extern void GetServerVarAsString(string varname, StringBuilder buffer, int len);
        [DllImport("__Internal", EntryPoint="GetServerVarAsInt")]
        public static extern int GetServerVarAsInt(string varname);
        [DllImport("__Internal", EntryPoint="GetServerVarAsBool")]
        public static extern int GetServerVarAsBool(string varname);
        [DllImport("__Internal", EntryPoint="GetPlayerNetworkStats")]
        public static extern void GetPlayerNetworkStats(int playerid, StringBuilder retstr, int retstr_size);
        [DllImport("__Internal", EntryPoint="GetNetworkStats")]
        public static extern void GetNetworkStats(StringBuilder retstr, int retstr_size);
        [DllImport("__Internal", EntryPoint="GetPlayerVersion")]
        public static extern void GetPlayerVersion(int playerid, StringBuilder version, int len);

        // Menu
        [DllImport("__Internal", EntryPoint="CreateMenu")]
        public static extern int CreateMenu(string title, int columns, float x, float y, float col1width, float col2width=0.0f);
        [DllImport("__Internal", EntryPoint="DestroyMenu")]
        public static extern int DestroyMenu(int menuid);
        [DllImport("__Internal", EntryPoint="AddMenuItem")]
        public static extern void AddMenuItem(int menuid, int column, string menutext);
        [DllImport("__Internal", EntryPoint="SetMenuColumnHeader")]
        public static extern void SetMenuColumnHeader(int menuid, int column, string columnheader);
        [DllImport("__Internal", EntryPoint="ShowMenuForPlayer")]
        public static extern void ShowMenuForPlayer(int menuid, int playerid);
        [DllImport("__Internal", EntryPoint="HideMenuForPlayer")]
        public static extern void HideMenuForPlayer(int menuid, int playerid);
        [DllImport("__Internal", EntryPoint="IsValidMenu")]
        public static extern int IsValidMenu(int menuid);
        [DllImport("__Internal", EntryPoint="DisableMenu")]
        public static extern void DisableMenu(int menuid);
        [DllImport("__Internal", EntryPoint="DisableMenuRow")]
        public static extern void DisableMenuRow(int menuid, int row);
        [DllImport("__Internal", EntryPoint="GetPlayerMenu")]
        public static extern int GetPlayerMenu(int playerid);

        // Text Draw
        [DllImport("__Internal", EntryPoint="TextDrawCreate")]
        public static extern int TextDrawCreate(float x, float y, string text);
        [DllImport("__Internal", EntryPoint="TextDrawDestroy")]
        public static extern void TextDrawDestroy(int text);
        [DllImport("__Internal", EntryPoint="TextDrawLetterSize")]
        public static extern void TextDrawLetterSize(int text, float x, float y);
        [DllImport("__Internal", EntryPoint="TextDrawTextSize")]
        public static extern void TextDrawTextSize(int text, float x, float y);
        [DllImport("__Internal", EntryPoint="TextDrawAlignment")]
        public static extern void TextDrawAlignment(int text, int alignment);
        [DllImport("__Internal", EntryPoint="TextDrawColor")]
        public static extern void TextDrawColor(int text, uint color);
        [DllImport("__Internal", EntryPoint="TextDrawUseBox")]
        public static extern void TextDrawUseBox(int text, int use);
        [DllImport("__Internal", EntryPoint="TextDrawBoxColor")]
        public static extern void TextDrawBoxColor(int text, uint color);
        [DllImport("__Internal", EntryPoint="TextDrawSetShadow")]
        public static extern void TextDrawSetShadow(int text, int size);
        [DllImport("__Internal", EntryPoint="TextDrawSetOutline")]
        public static extern void TextDrawSetOutline(int text, int size);
        [DllImport("__Internal", EntryPoint="TextDrawBackgroundColor")]
        public static extern void TextDrawBackgroundColor(int text, uint color);
        [DllImport("__Internal", EntryPoint="TextDrawFont")]
        public static extern void TextDrawFont(int text, int font);
        [DllImport("__Internal", EntryPoint="TextDrawSetProportional")]
        public static extern void TextDrawSetProportional(int text, int set);
        [DllImport("__Internal", EntryPoint="TextDrawSetSelectable")]
        public static extern void TextDrawSetSelectable(int text, int set);
        [DllImport("__Internal", EntryPoint="TextDrawShowForPlayer")]
        public static extern void TextDrawShowForPlayer(int playerid, int text);
        [DllImport("__Internal", EntryPoint="TextDrawHideForPlayer")]
        public static extern void TextDrawHideForPlayer(int playerid, int text);
        [DllImport("__Internal", EntryPoint="TextDrawShowForAll")]
        public static extern void TextDrawShowForAll(int text);
        [DllImport("__Internal", EntryPoint="TextDrawHideForAll")]
        public static extern void TextDrawHideForAll(int text);
        [DllImport("__Internal", EntryPoint="TextDrawSetString")]
        public static extern void TextDrawSetString(int text, string str);

        // Gang Zones
        [DllImport("__Internal", EntryPoint="GangZoneCreate")]
        public static extern int GangZoneCreate(float minx, float miny, float maxx, float maxy);
        [DllImport("__Internal", EntryPoint="GangZoneDestroy")]
        public static extern void GangZoneDestroy(int zone);
        [DllImport("__Internal", EntryPoint="GangZoneShowForPlayer")]
        public static extern void GangZoneShowForPlayer(int playerid, int zone, uint color);
        [DllImport("__Internal", EntryPoint="GangZoneShowForAll")]
        public static extern int GangZoneShowForAll(int zone, uint color);
        [DllImport("__Internal", EntryPoint="GangZoneHideForPlayer")]
        public static extern void GangZoneHideForPlayer(int playerid, int zone);
        [DllImport("__Internal", EntryPoint="GangZoneHideForAll")]
        public static extern void GangZoneHideForAll(int zone);
        [DllImport("__Internal", EntryPoint="GangZoneFlashForPlayer")]
        public static extern void GangZoneFlashForPlayer(int playerid, int zone, uint flashcolor);
        [DllImport("__Internal", EntryPoint="GangZoneFlashForAll")]
        public static extern void GangZoneFlashForAll(int zone, uint flashcolor);
        [DllImport("__Internal", EntryPoint="GangZoneStopFlashForPlayer")]
        public static extern void GangZoneStopFlashForPlayer(int playerid, int zone);
        [DllImport("__Internal", EntryPoint="GangZoneStopFlashForAll")]
        public static extern void GangZoneStopFlashForAll(int zone);

        // Global 3D Text Labels
        [DllImport("__Internal", EntryPoint="Create3DTextLabel")]
        public static extern int Create3DTextLabel(string text, uint color, float x, float y, float z, float drawdistance, int virtualworld, int testlos=0);
        [DllImport("__Internal", EntryPoint="Delete3DTextLabel")]
        public static extern int Delete3DTextLabel(int id);
        [DllImport("__Internal", EntryPoint="Attach3DTextLabelToPlayer")]
        public static extern void Attach3DTextLabelToPlayer(int id, int playerid, float offsetx, float offsety, float offsetz);
        [DllImport("__Internal", EntryPoint="Attach3DTextLabelToVehicle")]
        public static extern void Attach3DTextLabelToVehicle(int id, int vehicleid, float offsetx, float offsety, float offsetz);
        [DllImport("__Internal", EntryPoint="Update3DTextLabelText")]
        public static extern void Update3DTextLabelText(int id, uint color, string text);

        // Per-player 3D Text Labels
        [DllImport("__Internal", EntryPoint="CreatePlayer3DTextLabel")]
        public static extern int CreatePlayer3DTextLabel(int playerid, string text, uint color, float x, float y, float z, float drawdistance, int attachedplayer=0xFFFF, int attachedvehicle=0xFFFF, int testlos=0);
        [DllImport("__Internal", EntryPoint="DeletePlayer3DTextLabel")]
        public static extern void DeletePlayer3DTextLabel(int playerid, int id);
        [DllImport("__Internal", EntryPoint="UpdatePlayer3DTextLabelText")]
        public static extern void UpdatePlayer3DTextLabelText(int playerid, int id, uint color, string text);

        // Player GUI Dialog
        [DllImport("__Internal", EntryPoint="ShowPlayerDialog")]
        public static extern void ShowPlayerDialog(int playerid, int dialogid, int style, string caption, string info, string button1, string button2);
        #endregion

        // a_players.inc
        #region a_players.inc
        // Player
        [DllImport("__Internal", EntryPoint="SetSpawnInfo")]
        public static extern void SetSpawnInfo(int playerid, int team, int skin, float x, float y, float z, float rotation, int weapon1, int weapon1_ammo, int weapon2, int weapon2_ammo, int weapon3, int weapon3_ammo);
        [DllImport("__Internal", EntryPoint="SpawnPlayer")]
        public static extern void SpawnPlayer(int playerid);

        // Player info
        [DllImport("__Internal", EntryPoint="SetPlayerPos")]
        public static extern void SetPlayerPos(int playerid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="SetPlayerPosFindZ")]
        public static extern void SetPlayerPosFindZ(int playerid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="GetPlayerPos")]
        public static extern void GetPlayerPos(int playerid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="SetPlayerFacingAngle")]
        public static extern void SetPlayerFacingAngle(int playerid, float ang);
        [DllImport("__Internal", EntryPoint="GetPlayerFacingAngle")]
        public static extern void GetPlayerFacingAngle(int playerid, ref float ang);
        //[DllImport("__Internal", EntryPoint="IsPlayerInRangeOfPoint")]
        //public static extern void IsPlayerInRangeOfPoint(int playerid, float range, float x, float y, float z);
        //[DllImport("__Internal", EntryPoint="GetPlayerDistanceFromPoint")]
        //public static extern void GetPlayerDistanceFromPoint(int playerid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="IsPlayerStreamedIn")]
        public static extern int IsPlayerStreamedIn(int playerid, int forplayerid);
        [DllImport("__Internal", EntryPoint="SetPlayerInterior")]
        public static extern void SetPlayerInterior(int playerid, int interiorid);
        [DllImport("__Internal", EntryPoint="GetPlayerInterior")]
        public static extern int GetPlayerInterior(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerHealth")]
        public static extern void SetPlayerHealth(int playerid, float health);
        [DllImport("__Internal", EntryPoint="GetPlayerHealth")]
        public static extern void GetPlayerHealth(int playerid, ref float health);
        [DllImport("__Internal", EntryPoint="SetPlayerArmour")]
        public static extern void SetPlayerArmour(int playerid, float armour);
        [DllImport("__Internal", EntryPoint="GetPlayerArmour")]
        public static extern void GetPlayerArmour(int playerid, ref float armour);
        [DllImport("__Internal", EntryPoint="SetPlayerAmmo")]
        public static extern void SetPlayerAmmo(int playerid, int weaponslot, int ammo);
        [DllImport("__Internal", EntryPoint="GetPlayerAmmo")]
        public static extern int GetPlayerAmmo(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerWeaponState")]
        public static extern int GetPlayerWeaponState(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerTargetPlayer")]
        public static extern int GetPlayerTargetPlayer(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerTeam")]
        public static extern void SetPlayerTeam(int playerid, int teamid);
        [DllImport("__Internal", EntryPoint="GetPlayerTeam")]
        public static extern int GetPlayerTeam(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerScore")]
        public static extern void SetPlayerScore(int playerid, int score);
        [DllImport("__Internal", EntryPoint="GetPlayerScore")]
        public static extern int GetPlayerScore(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerDrunkLevel")]
        public static extern int GetPlayerDrunkLevel(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerDrunkLevel")]
        public static extern void SetPlayerDrunkLevel(int playerid, int level);
        [DllImport("__Internal", EntryPoint="SetPlayerColor")]
        public static extern void SetPlayerColor(int playerid, uint color);
        [DllImport("__Internal", EntryPoint="GetPlayerColor")]
        public static extern int GetPlayerColor(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerSkin")]
        public static extern void SetPlayerSkin(int playerid, int skinid);
        [DllImport("__Internal", EntryPoint="GetPlayerSkin")]
        public static extern int GetPlayerSkin(int playerid);
        [DllImport("__Internal", EntryPoint="GivePlayerWeapon")]
        public static extern void GivePlayerWeapon(int playerid, int weaponid, int ammo);
        [DllImport("__Internal", EntryPoint="ResetPlayerWeapons")]
        public static extern void ResetPlayerWeapons(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerArmedWeapon")]
        public static extern void SetPlayerArmedWeapon(int playerid, int weaponid);
        [DllImport("__Internal", EntryPoint="GetPlayerWeaponData")]
        public static extern void GetPlayerWeaponData(int playerid, int slot, ref int weapons, ref int ammo);
        [DllImport("__Internal", EntryPoint="GivePlayerMoney")]
        public static extern void GivePlayerMoney(int playerid, int money);
        [DllImport("__Internal", EntryPoint="ResetPlayerMoney")]
        public static extern void ResetPlayerMoney(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerName")]
        public static extern void SetPlayerName(int playerid, string name);
        [DllImport("__Internal", EntryPoint="GetPlayerMoney")]
        public static extern int GetPlayerMoney(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerState")]
        public static extern int GetPlayerState(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerIp")]
        public static extern void GetPlayerIp(int playerid, StringBuilder name, int len);
        [DllImport("__Internal", EntryPoint="GetPlayerPing")]
        public static extern int GetPlayerPing(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerWeapon")]
        public static extern int GetPlayerWeapon(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerKeys")]
        public static extern void GetPlayerKeys(int playerid, ref int keys, ref int updown, ref int leftright);
        [DllImport("__Internal", EntryPoint="GetPlayerName")]
        public static extern void GetPlayerName(int playerid, StringBuilder name, int len);
        [DllImport("__Internal", EntryPoint="SetPlayerTime")]
        public static extern void SetPlayerTime(int playerid, int hour, int minute);
        [DllImport("__Internal", EntryPoint="GetPlayerTime")]
        public static extern void GetPlayerTime(int playerid, ref int hour, ref int minute);
        [DllImport("__Internal", EntryPoint="TogglePlayerClock")]
        public static extern void TogglePlayerClock(int playerid, int toggle);
        [DllImport("__Internal", EntryPoint="SetPlayerWeather")]
        public static extern void SetPlayerWeather(int playerid, int weather);
        [DllImport("__Internal", EntryPoint="ForceClassSelection")]
        public static extern void ForceClassSelection(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerWantedLevel")]
        public static extern void SetPlayerWantedLevel(int playerid, int level);
        [DllImport("__Internal", EntryPoint="GetPlayerWantedLevel")]
        public static extern int GetPlayerWantedLevel(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerFightingStyle")]
        public static extern void SetPlayerFightingStyle(int playerid, int style);
        [DllImport("__Internal", EntryPoint="GetPlayerFightingStyle")]
        public static extern int GetPlayerFightingStyle(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerVelocity")]
        public static extern void SetPlayerVelocity(int playerid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="GetPlayerVelocity")]
        public static extern void GetPlayerVelocity(int playerid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="PlayCrimeReportForPlayer")]
        public static extern void PlayCrimeReportForPlayer(int playerid, int suspectid, int crime);
        [DllImport("__Internal", EntryPoint="PlayAudioStreamForPlayer")]
        public static extern void PlayAudioStreamForPlayer(int playerid, string url, float posx=0.0f, float posy=0.0f, float posz=0.0f, float distance=50.0f, int usepos=0);
        [DllImport("__Internal", EntryPoint="StopAudioStreamForPlayer")]
        public static extern void StopAudioStreamForPlayer(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerShopName")]
        public static extern void SetPlayerShopName(int playerid, string shopname);
        [DllImport("__Internal", EntryPoint="SetPlayerSkillLevel")]
        public static extern void SetPlayerSkillLevel(int playerid, int skill, int level);
        [DllImport("__Internal", EntryPoint="GetPlayerSurfingVehicleID")]
        public static extern int GetPlayerSurfingVehicleID(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerSurfingObjectID")]
        public static extern int GetPlayerSurfingObjectID(int playerid);
        [DllImport("__Internal", EntryPoint="RemoveBuildingForPlayer")]
        public static extern void RemoveBuildingForPlayer(int playerid, int modelid, float fx, float fy, float fz, float fradius);

        // Attached to bone objects
        [DllImport("__Internal", EntryPoint="SetPlayerAttachedObject")]
        public static extern void SetPlayerAttachedObject(int playerid, int index, int modelid, int bone, float foffsetx=0.0f, float foffsety=0.0f, float foffsetz=0.0f, float frotx=0.0f, float froty=0.0f, float frotz=0.0f, float fscalex=1.0f, float fscaley=1.0f, float fscalez=1.0f, int materialcolor1=0, int materialcolor2=0);
        [DllImport("__Internal", EntryPoint="RemovePlayerAttachedObject")]
        public static extern void RemovePlayerAttachedObject(int playerid, int index);
        [DllImport("__Internal", EntryPoint="IsPlayerAttachedObjectSlotUsed")]
        public static extern void IsPlayerAttachedObjectSlotUsed(int playerid, int index);
        [DllImport("__Internal", EntryPoint="EditAttachedObject")]
        public static extern void EditAttachedObject(int playerid, int index);

        // Per-player TextDraws
        [DllImport("__Internal", EntryPoint="CreatePlayerTextDraw")]
        public static extern int CreatePlayerTextDraw(int playerid, float x, float y, string text);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawDestroy")]
        public static extern void PlayerTextDrawDestroy(int playerid, int text);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawLetterSize")]
        public static extern void PlayerTextDrawLetterSize(int playerid, int text, float x, float y);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawTextSize")]
        public static extern void PlayerTextDrawTextSize(int playerid, int text, float x, float y);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawAlignment")]
        public static extern void PlayerTextDrawAlignment(int playerid, int text, int alignment);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawColor")]
        public static extern void PlayerTextDrawColor(int playerid, int text, uint color);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawUseBox")]
        public static extern void PlayerTextDrawUseBox(int playerid, int text, int use);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawBoxColor")]
        public static extern void PlayerTextDrawBoxColor(int playerid, int text, uint color);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawSetShadow")]
        public static extern void PlayerTextDrawSetShadow(int playerid, int text, int size);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawSetOutline")]
        public static extern void PlayerTextDrawSetOutline(int playerid, int text, int size);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawBackgroundColor")]
        public static extern void PlayerTextDrawBackgroundColor(int playerid, int text, uint color);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawFont")]
        public static extern void PlayerTextDrawFont(int playerid, int text, int font);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawSetProportional")]
        public static extern void PlayerTextDrawSetProportional(int playerid, int text, int set);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawSetSelectable")]
        public static extern void PlayerTextDrawSetSelectable(int playerid, int text, int set);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawShow")]
        public static extern void PlayerTextDrawShow(int playerid, int text);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawHide")]
        public static extern void PlayerTextDrawHide(int playerid, int text);
        [DllImport("__Internal", EntryPoint="PlayerTextDrawSetString")]
        public static extern void PlayerTextDrawSetString(int playerid, int text, string str);

        // Per-player variable system (PVars)
        [DllImport("__Internal", EntryPoint="SetPVarInt")]
        public static extern void SetPVarInt(int playerid, string varname, int int_value);
        [DllImport("__Internal", EntryPoint="GetPVarInt")]
        public static extern int GetPVarInt(int playerid, string varname);
        [DllImport("__Internal", EntryPoint="SetPVarString")]
        public static extern void SetPVarString(int playerid, string varname, string string_value);
        [DllImport("__Internal", EntryPoint="GetPVarString")]
        public static extern void GetPVarString(int playerid, string varname, StringBuilder string_return, int len);
        [DllImport("__Internal", EntryPoint="SetPVarFloat")]
        public static extern void SetPVarFloat(int playerid, string varname, float float_value);
        [DllImport("__Internal", EntryPoint="GetPVarFloat")]
        public static extern float GetPVarFloat(int playerid, string varname);
        [DllImport("__Internal", EntryPoint="DeletePVar")]
        public static extern void DeletePVar(int playerid, string varname);
        [DllImport("__Internal", EntryPoint="GetPVarsUpperIndex")]
        public static extern int GetPVarsUpperIndex(int playerid);
        [DllImport("__Internal", EntryPoint="GetPVarNameAtIndex")]
        public static extern void GetPVarNameAtIndex(int playerid, int index, string ret_varname, int ret_len);
        [DllImport("__Internal", EntryPoint="GetPVarType")]
        public static extern void GetPVarType(int playerid, string varname);
        [DllImport("__Internal", EntryPoint="SetPlayerChatBubble")]
        public static extern void SetPlayerChatBubble(int playerid, string text, uint color, float drawdistance, int expiretime);
        [DllImport("__Internal", EntryPoint="PutPlayerInVehicle")]
        public static extern void PutPlayerInVehicle(int playerid, int vehicleid, int seatid);
        [DllImport("__Internal", EntryPoint="GetPlayerVehicleID")]
        public static extern int GetPlayerVehicleID(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerVehicleSeat")]
        public static extern int GetPlayerVehicleSeat(int playerid);
        [DllImport("__Internal", EntryPoint="RemovePlayerFromVehicle")]
        public static extern void RemovePlayerFromVehicle(int playerid);
        [DllImport("__Internal", EntryPoint="TogglePlayerControllable")]
        public static extern void TogglePlayerControllable(int playerid, int toggle);
        [DllImport("__Internal", EntryPoint="PlayerPlaySound")]
        public static extern void PlayerPlaySound(int playerid, int soundid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="ApplyAnimation")]
        public static extern void ApplyAnimation(int playerid, string animlib, string animname, float fdelta, int loop, int lockx, int locky, int freeze, int time, int forcesync=0);
        [DllImport("__Internal", EntryPoint="ClearAnimations")]
        public static extern void ClearAnimations(int playerid, int forcesync=0);
        [DllImport("__Internal", EntryPoint="GetPlayerAnimationIndex")]
        public static extern int GetPlayerAnimationIndex(int playerid);
        [DllImport("__Internal", EntryPoint="GetAnimationName")]
        public static extern void GetAnimationName(int index, string animlib, int len1, string animname, int len2);
        [DllImport("__Internal", EntryPoint="GetPlayerSpecialAction")]
        public static extern int GetPlayerSpecialAction(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerSpecialAction")]
        public static extern void SetPlayerSpecialAction(int playerid, int actionid);
        [DllImport("__Internal", EntryPoint="SetPlayerCheckpoint")]
        public static extern void SetPlayerCheckpoint(int playerid, float x, float y, float z, float size);
        [DllImport("__Internal", EntryPoint="DisablePlayerCheckpoint")]
        public static extern void DisablePlayerCheckpoint(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerRaceCheckpoint")]
        public static extern void SetPlayerRaceCheckpoint(int playerid, int type, float x, float y, float z, float nextx, float nexty, float nextz, float size);
        [DllImport("__Internal", EntryPoint="DisablePlayerRaceCheckpoint")]
        public static extern void DisablePlayerRaceCheckpoint(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerWorldBounds")]
        public static extern void SetPlayerWorldBounds(int playerid, float x_max, float x_min, float y_max, float y_min);
        [DllImport("__Internal", EntryPoint="SetPlayerMarkerForPlayer")]
        public static extern void SetPlayerMarkerForPlayer(int playerid, int showplayerid, uint color);
        [DllImport("__Internal", EntryPoint="ShowPlayerNameTagForPlayer")]
        public static extern void ShowPlayerNameTagForPlayer(int playerid, int showplayerid, int show);
        [DllImport("__Internal", EntryPoint="SetPlayerMapIcon")]
        public static extern void SetPlayerMapIcon(int playerid, int iconid, float x, float y, float z, int markertype, uint color, int style=0);
        [DllImport("__Internal", EntryPoint="RemovePlayerMapIcon")]
        public static extern void RemovePlayerMapIcon(int playerid, int iconid);
        [DllImport("__Internal", EntryPoint="AllowPlayerTeleport")]
        public static extern void AllowPlayerTeleport(int playerid, int allow);
        [DllImport("__Internal", EntryPoint="SetPlayerCameraPos")]
        public static extern void SetPlayerCameraPos(int playerid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="SetPlayerCameraLookAt")]
        public static extern void SetPlayerCameraLookAt(int playerid, float x, float y, float z, int cut=2);
        [DllImport("__Internal", EntryPoint="SetCameraBehindPlayer")]
        public static extern void SetCameraBehindPlayer(int playerid);
        [DllImport("__Internal", EntryPoint="GetPlayerCameraPos")]
        public static extern void GetPlayerCameraPos(int playerid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="GetPlayerCameraFrontVector")]
        public static extern void GetPlayerCameraFrontVector(int playerid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="GetPlayerCameraMode")]
        public static extern int GetPlayerCameraMode(int playerid);
        [DllImport("__Internal", EntryPoint="AttachCameraToObject")]
        public static extern void AttachCameraToObject(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="AttachCameraToPlayerObject")]
        public static extern void AttachCameraToPlayerObject(int playerid, int playerobjectid);
        [DllImport("__Internal", EntryPoint="InterpolateCameraPos")]
        public static extern void InterpolateCameraPos(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut=2);
        [DllImport("__Internal", EntryPoint="InterpolateCameraLookAt")]
        public static extern void InterpolateCameraLookAt(int playerid, float fromx, float fromy, float fromz, float tox, float toy, float toz, int time, int cut=2);
        [DllImport("__Internal", EntryPoint="IsPlayerConnected")]
        public static extern int IsPlayerConnected(int playerid);
        [DllImport("__Internal", EntryPoint="IsPlayerInVehicle")]
        public static extern int IsPlayerInVehicle(int playerid, int vehicleid);
        [DllImport("__Internal", EntryPoint="IsPlayerInAnyVehicle")]
        public static extern int IsPlayerInAnyVehicle(int playerid);
        [DllImport("__Internal", EntryPoint="IsPlayerInCheckpoint")]
        public static extern int IsPlayerInCheckpoint(int playerid);
        [DllImport("__Internal", EntryPoint="IsPlayerInRaceCheckpoint")]
        public static extern int IsPlayerInRaceCheckpoint(int playerid);
        [DllImport("__Internal", EntryPoint="SetPlayerVirtualWorld")]
        public static extern void SetPlayerVirtualWorld(int playerid, int worldid);
        [DllImport("__Internal", EntryPoint="GetPlayerVirtualWorld")]
        public static extern int GetPlayerVirtualWorld(int playerid);
        [DllImport("__Internal", EntryPoint="EnableStuntBonusForPlayer")]
        public static extern void EnableStuntBonusForPlayer(int playerid, int enable);
        [DllImport("__Internal", EntryPoint="EnableStuntBonusForAll")]
        public static extern void EnableStuntBonusForAll(int enable);
        [DllImport("__Internal", EntryPoint="TogglePlayerSpectating")]
        public static extern void TogglePlayerSpectating(int playerid, int toggle);
        [DllImport("__Internal", EntryPoint="PlayerSpectatePlayer")]
        public static extern void PlayerSpectatePlayer(int playerid, int targetplayerid, int mode=1);
        [DllImport("__Internal", EntryPoint="PlayerSpectateVehicle")]
        public static extern void PlayerSpectateVehicle(int playerid, int targetvehicleid, int mode=1);
        [DllImport("__Internal", EntryPoint="StartRecordingPlayerData")]
        public static extern void StartRecordingPlayerData(int playerid, int recordtype, string recordname);
        [DllImport("__Internal", EntryPoint="StopRecordingPlayerData")]
        public static extern void StopRecordingPlayerData(int playerid);
        [DllImport("__Internal", EntryPoint="SelectTextDraw")]
        public static extern void SelectTextDraw(int playerid, int hovercolor);
        [DllImport("__Internal", EntryPoint="CancelSelectTextDraw")]
        public static extern void CancelSelectTextDraw(int playerid);
        #endregion

        // a_vehicles.inc
        #region a_vehicles.inc
        // Vehicles
        [DllImport("__Internal", EntryPoint="CreateVehicle")]
        public static extern int CreateVehicle(int vehicletype, float x, float y, float z, float rotation, int color1, int color2, int respawn_delay);
        [DllImport("__Internal", EntryPoint="DestroyVehicle")]
        public static extern void DestroyVehicle(int vehicleid);
        [DllImport("__Internal", EntryPoint="IsVehicleStreamedIn")]
        public static extern void IsVehicleStreamedIn(int vehicleid, int forplayerid);
        [DllImport("__Internal", EntryPoint="GetVehiclePos")]
        public static extern void GetVehiclePos(int vehicleid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="SetVehiclePos")]
        public static extern void SetVehiclePos(int vehicleid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="GetVehicleZAngle")]
        public static extern void GetVehicleZAngle(int vehicleid, ref float z_angle);
        [DllImport("__Internal", EntryPoint="GetVehicleRotationQuat")]
        public static extern void GetVehicleRotationQuat(int vehicleid, ref float w, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="GetVehicleDistanceFromPoint")]
        public static extern void GetVehicleDistanceFromPoint(int vehicleid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="SetVehicleZAngle")]
        public static extern void SetVehicleZAngle(int vehicleid, float z_angle);
        [DllImport("__Internal", EntryPoint="SetVehicleParamsForPlayer")]
        public static extern void SetVehicleParamsForPlayer(int vehicleid, int playerid, int objective, int doorslocked);
        [DllImport("__Internal", EntryPoint="ManualVehicleEngineAndLights")]
        public static extern void ManualVehicleEngineAndLights();
        [DllImport("__Internal", EntryPoint="SetVehicleParamsEx")]
        public static extern void SetVehicleParamsEx(int vehicleid, int engine, int lights, int alarm, int doors, int bonnet, int boot, int objective);
        [DllImport("__Internal", EntryPoint="GetVehicleParamsEx")]
        public static extern void GetVehicleParamsEx(int vehicleid, ref int engine, ref int lights, ref int alarm, ref int doors, ref int bonnet, ref int boot, ref int objective);
        [DllImport("__Internal", EntryPoint="SetVehicleToRespawn")]
        public static extern void SetVehicleToRespawn(int vehicleid);
        [DllImport("__Internal", EntryPoint="LinkVehicleToInterior")]
        public static extern void LinkVehicleToInterior(int vehicleid, int interiorid);
        [DllImport("__Internal", EntryPoint="AddVehicleComponent")]
        public static extern void AddVehicleComponent(int vehicleid, int componentid);
        [DllImport("__Internal", EntryPoint="RemoveVehicleComponent")]
        public static extern void RemoveVehicleComponent(int vehicleid, int componentid);
        [DllImport("__Internal", EntryPoint="ChangeVehicleColor")]
        public static extern void ChangeVehicleColor(int vehicleid, int color1, int color2);
        [DllImport("__Internal", EntryPoint="ChangeVehiclePaintjob")]
        public static extern void ChangeVehiclePaintjob(int vehicleid, int paintjobid);
        [DllImport("__Internal", EntryPoint="SetVehicleHealth")]
        public static extern void SetVehicleHealth(int vehicleid, float health);
        [DllImport("__Internal", EntryPoint="GetVehicleHealth")]
        public static extern void GetVehicleHealth(int vehicleid, ref float health);
        [DllImport("__Internal", EntryPoint="AttachTrailerToVehicle")]
        public static extern void AttachTrailerToVehicle(int trailerid, int vehicleid);
        [DllImport("__Internal", EntryPoint="DetachTrailerFromVehicle")]
        public static extern void DetachTrailerFromVehicle(int vehicleid);
        [DllImport("__Internal", EntryPoint="IsTrailerAttachedToVehicle")]
        public static extern int IsTrailerAttachedToVehicle(int vehicleid);
        [DllImport("__Internal", EntryPoint="GetVehicleTrailer")]
        public static extern int GetVehicleTrailer(int vehicleid);
        [DllImport("__Internal", EntryPoint="SetVehicleNumberPlate")]
        public static extern void SetVehicleNumberPlate(int vehicleid, string numberplate);
        [DllImport("__Internal", EntryPoint="GetVehicleModel")]
        public static extern int GetVehicleModel(int vehicleid);
        [DllImport("__Internal", EntryPoint="GetVehicleComponentInSlot")]
        public static extern int GetVehicleComponentInSlot(int vehicleid, int slot);
        [DllImport("__Internal", EntryPoint="GetVehicleComponentType")]
        public static extern int GetVehicleComponentType(int component);
        [DllImport("__Internal", EntryPoint="RepairVehicle")]
        public static extern void RepairVehicle(int vehicleid);
        [DllImport("__Internal", EntryPoint="GetVehicleVelocity")]
        public static extern void GetVehicleVelocity(int vehicleid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="SetVehicleVelocity")]
        public static extern void SetVehicleVelocity(int vehicleid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="SetVehicleAngularVelocity")]
        public static extern void SetVehicleAngularVelocity(int vehicleid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="GetVehicleDamageStatus")]
        public static extern void GetVehicleDamageStatus(int vehicleid, ref int panels, ref int doors, ref int lights, ref int tires);
        [DllImport("__Internal", EntryPoint="UpdateVehicleDamageStatus")]
        public static extern void UpdateVehicleDamageStatus(int vehicleid, int panels, int doors, int lights, int tires);
        [DllImport("__Internal", EntryPoint="GetVehicleModelInfo")]
        public static extern void GetVehicleModelInfo(int vehiclemodel, int infotype, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="SetVehicleVirtualWorld")]
        public static extern void SetVehicleVirtualWorld(int vehicleid, int worldid);
        [DllImport("__Internal", EntryPoint="GetVehicleVirtualWorld")]
        public static extern int GetVehicleVirtualWorld(int vehicleid);
        #endregion

        // a_objects.inc
        #region a_objects.inc
        // Objects
        [DllImport("__Internal", EntryPoint="CreateObject")]
        public static extern int CreateObject(int modelid, float x, float y, float z, float rx, float ry, float rz, float drawdistance=0.0f);
        [DllImport("__Internal", EntryPoint="AttachObjectToVehicle")]
        public static extern void AttachObjectToVehicle(int objectid, int vehicleid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz);
        [DllImport("__Internal", EntryPoint="AttachObjectToObject")]
        public static extern void AttachObjectToObject(int objectid, int attachtoid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz, int syncrotation=1);
        [DllImport("__Internal", EntryPoint="AttachObjectToPlayer")]
        public static extern void AttachObjectToPlayer(int objectid, int playerid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz);
        [DllImport("__Internal", EntryPoint="SetObjectPos")]
        public static extern void SetObjectPos(int objectid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="GetObjectPos")]
        public static extern void GetObjectPos(int objectid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="SetObjectRot")]
        public static extern void SetObjectRot(int objectid, float rotx, float roty, float rotz);
        [DllImport("__Internal", EntryPoint="GetObjectRot")]
        public static extern void GetObjectRot(int objectid, ref float rotx, ref float roty, ref float rotz);
        [DllImport("__Internal", EntryPoint="IsValidObject")]
        public static extern int IsValidObject(int objectid);
        [DllImport("__Internal", EntryPoint="DestroyObject")]
        public static extern void DestroyObject(int objectid);
        [DllImport("__Internal", EntryPoint="MoveObject")]
        public static extern void MoveObject(int objectid, float x, float y, float z, float speed, float rotx=-1000.0f, float roty=-1000.0f, float rotz=-1000.0f);
        [DllImport("__Internal", EntryPoint="StopObject")]
        public static extern void StopObject(int objectid);
        [DllImport("__Internal", EntryPoint="IsObjectMoving")]
        public static extern int IsObjectMoving(int objectid);
        [DllImport("__Internal", EntryPoint="EditObject")]
        public static extern void EditObject(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="EditPlayerObject")]
        public static extern void EditPlayerObject(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="SelectObject")]
        public static extern void SelectObject(int playerid);
        [DllImport("__Internal", EntryPoint="CancelEdit")]
        public static extern void CancelEdit(int playerid);
        [DllImport("__Internal", EntryPoint="CreatePlayerObject")]
        public static extern int CreatePlayerObject(int playerid, int modelid, float x, float y, float z, float rx, float ry, float rz, float drawdistance=0.0f);
        [DllImport("__Internal", EntryPoint="AttachPlayerObjectToVehicle")]
        public static extern void AttachPlayerObjectToVehicle(int playerid, int objectid, int vehicleid, float foffsetx, float foffsety, float foffsetz, float frotx, float froty, float rotz);
        [DllImport("__Internal", EntryPoint="SetPlayerObjectPos")]
        public static extern void SetPlayerObjectPos(int playerid, int objectid, float x, float y, float z);
        [DllImport("__Internal", EntryPoint="GetPlayerObjectPos")]
        public static extern void GetPlayerObjectPos(int playerid, int objectid, ref float x, ref float y, ref float z);
        [DllImport("__Internal", EntryPoint="SetPlayerObjectRot")]
        public static extern void SetPlayerObjectRot(int playerid, int objectid, float rotx, float roty, float rotz);
        [DllImport("__Internal", EntryPoint="GetPlayerObjectRot")]
        public static extern void GetPlayerObjectRot(int playerid, int objectid, ref float rotx, ref float roty, ref float rotz);
        [DllImport("__Internal", EntryPoint="IsValidPlayerObject")]
        public static extern void IsValidPlayerObject(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="DestroyPlayerObject")]
        public static extern void DestroyPlayerObject(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="MovePlayerObject")]
        public static extern void MovePlayerObject(int playerid, int objectid, float x, float y, float z, float speed, float rotx=-1000.0f, float roty=-1000.0f, float rotz=-1000.0f);
        [DllImport("__Internal", EntryPoint="StopPlayerObject")]
        public static extern void StopPlayerObject(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="IsPlayerObjectMoving")]
        public static extern void IsPlayerObjectMoving(int playerid, int objectid);
        [DllImport("__Internal", EntryPoint="AttachPlayerObjectToPlayer")]
        public static extern void AttachPlayerObjectToPlayer(int objectplayer, int objectid, int attachplayer, float offsetx, float offsety, float offsetz, float rx, float ry, float rz);
        [DllImport("__Internal", EntryPoint="SetObjectMaterial")]
        public static extern void SetObjectMaterial(int objectid, int materialindex, int modelid, string txdname, string texturename, int materialcolor=0);
        [DllImport("__Internal", EntryPoint="SetPlayerObjectMaterial")]
        public static extern void SetPlayerObjectMaterial(int playerid, int objectid, int materialindex, int modelid, string txdname, string texturename, int materialcolor=0);
        [DllImport("__Internal", EntryPoint="SetObjectMaterialText")]
        public static extern void SetObjectMaterialText(int objectid, string text, int materialindex=0, int materialsize=90, string fontface="arial", int fontsize=24, int bold=1, uint fontcolor=0xffffffff, int backcolor=0, int textalignment=0);
        [DllImport("__Internal", EntryPoint="SetPlayerObjectMaterialText")]
        public static extern void SetPlayerObjectMaterialText(int playerid, int objectid, string text, int materialindex=0, int materialsize=90, string fontface="arial", int fontsize=24, int bold=1, uint fontcolor=0xffffffff, int backcolor=0, int textalignment=0);
        #endregion
    };
};