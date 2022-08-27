#include "a_samp.h"

int _samp_CreateVehicle(int vehicletype, float x, float y, float z, float rotation, int color1, int color2, int respawn_delay) {
	return g_Invoke->callNative(&PAWN::CreateVehicle, vehicletype, x, y, z, rotation, color1, color2, respawn_delay);
}

void _samp_DestroyVehicle(int vehicleid) {
	g_Invoke->callNative(&PAWN::DestroyVehicle, vehicleid);
}

void _samp_IsVehicleStreamedIn(int vehicleid, int forplayerid) {
	g_Invoke->callNative(&PAWN::IsVehicleStreamedIn, vehicleid, forplayerid);
}

void _samp_GetVehiclePos(int vehicleid, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetVehiclePos, vehicleid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void _samp_SetVehiclePos(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetVehiclePos, vehicleid, x, y, z);
}

void _samp_GetVehicleZAngle(int vehicleid, float& z_angle) {
	float _z_angle = 0.0;
	g_Invoke->callNative(&PAWN::GetVehicleZAngle, vehicleid, &_z_angle);
	z_angle = _z_angle;
}

void _samp_GetVehicleRotationQuat(int vehicleid, float& w, float& x, float& y, float& z) {
	float _w = 0.0;
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetVehicleRotationQuat, vehicleid, &_w, &_x, &_y, &_z);
	w = _w;
	x = _x;
	y = _y;
	z = _z;
}

void _samp_GetVehicleDistanceFromPoint(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::GetVehicleDistanceFromPoint, vehicleid, x, y, z);
}

void _samp_SetVehicleZAngle(int vehicleid, float z_angle) {
	g_Invoke->callNative(&PAWN::SetVehicleZAngle, vehicleid, z_angle);
}

void _samp_SetVehicleParamsForPlayer(int vehicleid, int playerid, int objective, int doorslocked) {
	g_Invoke->callNative(&PAWN::SetVehicleParamsForPlayer, vehicleid, playerid, objective, doorslocked);
}

void _samp_ManualVehicleEngineAndLights() {
	//g_Invoke->callNative(&PAWN::ManualVehicleEngineAndLights);
}

void _samp_SetVehicleParamsEx(int vehicleid, int engine, int lights, int alarm, int doors, int bonnet, int boot, int objective) {
	g_Invoke->callNative(&PAWN::SetVehicleParamsEx, vehicleid, engine, lights, alarm, doors, bonnet, boot, objective);
}

void _samp_GetVehicleParamsEx(int vehicleid, int& engine, int& lights, int& alarm, int& doors, int& bonnet, int& boot, int& objective) {
	int _engine = 0;
	int _lights = 0;
	int _alarm = 0;
	int _doors = 0;
	int _bonnet = 0;
	int _boot = 0;
	int _objective = 0;
	g_Invoke->callNative(&PAWN::GetVehicleParamsEx, vehicleid, &_engine, &_lights, &_alarm, &_doors, &_bonnet, &_boot, &_objective);
	engine = _engine;
	lights = _lights;
	alarm = _alarm;
	doors = _doors;
	bonnet = _bonnet;
	boot = _boot;
	objective = _objective;
}

void _samp_SetVehicleToRespawn(int vehicleid) {
	g_Invoke->callNative(&PAWN::SetVehicleToRespawn, vehicleid);
}

void _samp_LinkVehicleToInterior(int vehicleid, int interiorid) {
	g_Invoke->callNative(&PAWN::LinkVehicleToInterior, vehicleid, interiorid);
}

void _samp_AddVehicleComponent(int vehicleid, int componentid) {
	g_Invoke->callNative(&PAWN::AddVehicleComponent, vehicleid, componentid);
}

void _samp_RemoveVehicleComponent(int vehicleid, int componentid) {
	g_Invoke->callNative(&PAWN::RemoveVehicleComponent, vehicleid, componentid);
}

void _samp_ChangeVehicleColor(int vehicleid, int color1, int color2) {
	g_Invoke->callNative(&PAWN::ChangeVehicleColor, vehicleid, color1, color2);
}

void _samp_ChangeVehiclePaintjob(int vehicleid, int paintjobid) {
	g_Invoke->callNative(&PAWN::ChangeVehiclePaintjob, vehicleid, paintjobid);
}

void _samp_SetVehicleHealth(int vehicleid, float health) {
	g_Invoke->callNative(&PAWN::SetVehicleHealth, vehicleid, health);
}

void _samp_GetVehicleHealth(int vehicleid, float& health) {
	float _health = 0.0;
	g_Invoke->callNative(&PAWN::GetVehicleHealth, vehicleid, &_health);
	health = _health;
}

void _samp_AttachTrailerToVehicle(int trailerid, int vehicleid) {
	g_Invoke->callNative(&PAWN::AttachTrailerToVehicle, trailerid, vehicleid);
}

void _samp_DetachTrailerFromVehicle(int vehicleid) {
	g_Invoke->callNative(&PAWN::DetachTrailerFromVehicle, vehicleid);
}

int _samp_IsTrailerAttachedToVehicle(int vehicleid) {
	return g_Invoke->callNative(&PAWN::IsTrailerAttachedToVehicle, vehicleid);
}

int _samp_GetVehicleTrailer(int vehicleid) {
	return g_Invoke->callNative(&PAWN::GetVehicleTrailer, vehicleid);
}

void _samp_SetVehicleNumberPlate(int vehicleid, char* numberplate) {
	g_Invoke->callNative(&PAWN::SetVehicleNumberPlate, vehicleid, numberplate);
}

int _samp_GetVehicleModel(int vehicleid) {
	return g_Invoke->callNative(&PAWN::GetVehicleModel, vehicleid);
}

int _samp_GetVehicleComponentInSlot(int vehicleid, int slot) {
	return g_Invoke->callNative(&PAWN::GetVehicleComponentInSlot, vehicleid, slot);
}

int _samp_GetVehicleComponentType(int component) {
	return g_Invoke->callNative(&PAWN::GetVehicleComponentType, component);
}

void _samp_RepairVehicle(int vehicleid) {
	g_Invoke->callNative(&PAWN::RepairVehicle, vehicleid);
}

void _samp_GetVehicleVelocity(int vehicleid, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetVehicleVelocity, vehicleid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void _samp_SetVehicleVelocity(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetVehicleVelocity, vehicleid, x, y, z);
}

void _samp_SetVehicleAngularVelocity(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetVehicleAngularVelocity, vehicleid, x, y, z);
}

void _samp_GetVehicleDamageStatus(int vehicleid, int& panels, int& doors, int& lights, int& tires) {
	int _panels = 0;
	int _doors = 0;
	int _lights = 0;
	int _tires = 0;
	g_Invoke->callNative(&PAWN::GetVehicleDamageStatus, vehicleid, &_panels, &_doors, &_lights, &_tires);
	panels = _panels;
	doors = _doors;
	lights = _lights;
	tires = _tires;
}

void _samp_UpdateVehicleDamageStatus(int vehicleid, int panels, int doors, int lights, int tires) {
	g_Invoke->callNative(&PAWN::UpdateVehicleDamageStatus, vehicleid, panels, doors, lights, tires);
}

void _samp_GetVehicleModelInfo(int vehiclemodel, int infotype, float& x, float& y, float& z) {
	float _x = 0.0;
	float _y = 0.0;
	float _z = 0.0;
	g_Invoke->callNative(&PAWN::GetVehicleModelInfo, vehiclemodel, infotype, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void _samp_SetVehicleVirtualWorld(int vehicleid, int worldid) {
	g_Invoke->callNative(&PAWN::SetVehicleVirtualWorld, vehicleid, worldid);
}

int _samp_GetVehicleVirtualWorld(int vehicleid) {
	return g_Invoke->callNative(&PAWN::GetVehicleVirtualWorld, vehicleid);
}

