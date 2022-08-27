#include "a_samp.h"

int CreateObject(int modelid, float x, float y, float z, float rx, float ry, float rz, float drawdistance) {
	return g_Invoke->callNative(&PAWN::CreateObject, modelid, x, y, z, rx, ry, rz, drawdistance);
}

void AttachObjectToVehicle(int objectid, int vehicleid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz) {
	g_Invoke->callNative(&PAWN::AttachObjectToVehicle, objectid, vehicleid, offsetx, offsety, offsetz, rotx, roty, rotz);
}

void AttachObjectToObject(int objectid, int attachtoid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz, int SyncRotation) {
	g_Invoke->callNative(&PAWN::AttachObjectToObject, objectid, attachtoid, offsetx, offsety, offsetz, rotx, roty, rotz, SyncRotation);
}

void AttachObjectToPlayer(int objectid, int playerid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz) {
	g_Invoke->callNative(&PAWN::AttachObjectToPlayer, objectid, playerid, offsetx, offsety, offsetz, rotx, roty, rotz);
}

void SetObjectPos(int objectid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetObjectPos, objectid, x, y, z);
}

void GetObjectPos(int objectid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetObjectPos, objectid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void SetObjectRot(int objectid, float rotx, float roty, float rotz) {
	g_Invoke->callNative(&PAWN::SetObjectRot, objectid, rotx, roty, rotz);
}

void GetObjectRot(int objectid, float& rotx, float& roty, float& rotz) {
	float _rotx = NULL;
	float _roty = NULL;
	float _rotz = NULL;
	g_Invoke->callNative(&PAWN::GetObjectRot, objectid, &_rotx, &_roty, &_rotz);
	rotx = _rotx;
	roty = _roty;
	rotz = _rotz;
}

int IsValidObject(int objectid) {
	return g_Invoke->callNative(&PAWN::IsValidObject, objectid);
}

void DestroyObject(int objectid) {
	g_Invoke->callNative(&PAWN::DestroyObject, objectid);
}

void MoveObject(int objectid, float x, float y, float z, float speed, float rotx, float roty, float rotz) {
	g_Invoke->callNative(&PAWN::MoveObject, objectid, x, y, z, speed, rotx, roty, rotz);
}

void StopObject(int objectid) {
	g_Invoke->callNative(&PAWN::StopObject, objectid);
}

int IsObjectMoving(int objectid) {
	return g_Invoke->callNative(&PAWN::IsObjectMoving, objectid);
}

void EditObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::EditObject, playerid, objectid);
}

void EditPlayerObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::EditPlayerObject, playerid, objectid);
}

void SelectObject(int playerid) {
	g_Invoke->callNative(&PAWN::SelectObject, playerid);
}

void CancelEdit(int playerid) {
	g_Invoke->callNative(&PAWN::CancelEdit, playerid);
}

int CreatePlayerObject(int playerid, int modelid, float x, float y, float z, float rx, float ry, float rz, float drawdistance) {
	return g_Invoke->callNative(&PAWN::CreatePlayerObject, playerid, modelid, x, y, z, rx, ry, rz, drawdistance);
}

void AttachPlayerObjectToVehicle(int playerid, int objectid, int vehicleid, float foffsetx, float foffsety, float foffsetz, float frotx, float froty, float rotz) {
	g_Invoke->callNative(&PAWN::AttachPlayerObjectToVehicle, playerid, objectid, vehicleid, foffsetx, foffsety, foffsetz, frotx, froty, rotz);
}

void SetPlayerObjectPos(int playerid, int objectid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetPlayerObjectPos, playerid, objectid, x, y, z);
}

void GetPlayerObjectPos(int playerid, int objectid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerObjectPos, playerid, objectid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void SetPlayerObjectRot(int playerid, int objectid, float rotx, float roty, float rotz) {
	g_Invoke->callNative(&PAWN::SetPlayerObjectRot, playerid, objectid, rotx, roty, rotz);
}

void GetPlayerObjectRot(int playerid, int objectid, float& rotx, float& roty, float& rotz) {
	float _rotx = NULL;
	float _roty = NULL;
	float _rotz = NULL;
	g_Invoke->callNative(&PAWN::GetPlayerObjectRot, playerid, objectid, &_rotx, &_roty, &_rotz);
	rotx = _rotx;
	roty = _roty;
	rotz = _rotz;
}

void IsValidPlayerObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::IsValidPlayerObject, playerid, objectid);
}

void DestroyPlayerObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::DestroyPlayerObject, playerid, objectid);
}

void MovePlayerObject(int playerid, int objectid, float x, float y, float z, float speed, float rotx, float roty, float rotz) {
	g_Invoke->callNative(&PAWN::MovePlayerObject, playerid, objectid, x, y, z, speed, rotx, roty, rotz);
}

void StopPlayerObject(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::StopPlayerObject, playerid, objectid);
}

void IsPlayerObjectMoving(int playerid, int objectid) {
	g_Invoke->callNative(&PAWN::IsPlayerObjectMoving, playerid, objectid);
}

void AttachPlayerObjectToPlayer(int objectplayer, int objectid, int attachplayer, float offsetx, float offsety, float offsetz, float rx, float ry, float rz) {
	g_Invoke->callNative(&PAWN::AttachPlayerObjectToPlayer, objectplayer, objectid, attachplayer, offsetx, offsety, offsetz, rx, ry, rz);
}

void SetObjectMaterial(int objectid, int materialindex, int modelid, char* txdname, char* texturename, int materialcolor) {
	g_Invoke->callNative(&PAWN::SetObjectMaterial, objectid, materialindex, modelid, txdname, texturename, materialcolor);
}

void SetPlayerObjectMaterial(int playerid, int objectid, int materialindex, int modelid, char* txdname, char* texturename, int materialcolor) {
	g_Invoke->callNative(&PAWN::SetPlayerObjectMaterial, playerid, objectid, materialindex, modelid, txdname, texturename, materialcolor);
}

void SetObjectMaterialText(int objectid, char* text, int materialindex, int materialsize, char* fontface, int fontsize, int bold, unsigned int fontcolor, int backcolor, int textalignment) {
	g_Invoke->callNative(&PAWN::SetObjectMaterialText, objectid, text, materialindex, materialsize, fontface, fontsize, bold, fontcolor, backcolor, textalignment);
}

void SetPlayerObjectMaterialText(int playerid, int objectid, char* text, int materialindex, int materialsize, char* fontface, int fontsize, int bold, unsigned int fontcolor, int backcolor, int textalignment) {
	g_Invoke->callNative(&PAWN::SetPlayerObjectMaterialText, playerid, objectid, text, materialindex, materialsize, fontface, fontsize, bold, fontcolor, backcolor, textalignment);
}