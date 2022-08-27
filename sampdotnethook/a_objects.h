#ifndef _A_OBJECTS_H
#define _A_OBJECTS_H

int CreateObject(int modelid, float x, float y, float z, float rx, float ry, float rz, float drawdistance=0.0);
void AttachObjectToVehicle(int objectid, int vehicleid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz);
void AttachObjectToObject(int objectid, int attachtoid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz, int syncrotation=1);
void AttachObjectToPlayer(int objectid, int playerid, float offsetx, float offsety, float offsetz, float rotx, float roty, float rotz);
void SetObjectPos(int objectid, float x, float y, float z);
void GetObjectPos(int objectid, float& x, float& y, float& z);
void SetObjectRot(int objectid, float rotx, float roty, float rotz);
void GetObjectRot(int objectid, float& rotx, float& roty, float& rotz);
int IsValidObject(int objectid);
void DestroyObject(int objectid);
void MoveObject(int objectid, float x, float y, float z, float speed, float rotx=-1000.0, float roty=-1000.0, float rotz=-1000.0);
void StopObject(int objectid);
int IsObjectMoving(int objectid);
void EditObject(int playerid, int objectid);
void EditPlayerObject(int playerid, int objectid);
void SelectObject(int playerid);
void CancelEdit(int playerid);
int CreatePlayerObject(int playerid, int modelid, float x, float y, float z, float rx, float ry, float rz, float drawdistance=0.0);
void AttachPlayerObjectToVehicle(int playerid, int objectid, int vehicleid, float foffsetx, float foffsety, float foffsetz, float frotx, float froty, float rotz);
void SetPlayerObjectPos(int playerid, int objectid, float x, float y, float z);
void GetPlayerObjectPos(int playerid, int objectid, float& x, float& y, float& z);
void SetPlayerObjectRot(int playerid, int objectid, float rotx, float roty, float rotz);
void GetPlayerObjectRot(int playerid, int objectid, float& rotx, float& roty, float& rotz);
void IsValidPlayerObject(int playerid, int objectid);
void DestroyPlayerObject(int playerid, int objectid);
void MovePlayerObject(int playerid, int objectid, float x, float y, float z, float speed, float rotx=-1000.0, float roty=-1000.0, float rotz=-1000.0);
void StopPlayerObject(int playerid, int objectid);
void IsPlayerObjectMoving(int playerid, int objectid);
void AttachPlayerObjectToPlayer(int objectplayer, int objectid, int attachplayer, float offsetx, float offsety, float offsetz, float rx, float ry, float rz);
void SetObjectMaterial(int objectid, int materialindex, int modelid, char* txdname, char* texturename, int materialcolor=0);
void SetPlayerObjectMaterial(int playerid, int objectid, int materialindex, int modelid, char* txdname, char* texturename, int materialcolor=0);
void SetObjectMaterialText(int objectid, char* text, int materialindex=0, int materialsize=90, char* fontface="arial", int fontsize=24, int bold=1, unsigned int fontcolor=0xffffffff, int backcolor=0, int textalignment=0);
void SetPlayerObjectMaterialText(int playerid, int objectid, char* text, int materialindex=0, int materialsize=90, char* fontface="arial", int fontsize=24, int bold=1, unsigned int fontcolor=0xffffffff, int backcolor=0, int textalignment=0);

#endif //_A_OBJECTS_H