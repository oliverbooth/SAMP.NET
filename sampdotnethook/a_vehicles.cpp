#include "a_samp.h"

int CreateVehicle(int vehicletype, float x, float y, float z, float rotation, int color1, int color2, int respawn_delay) {
	return g_Invoke->callNative(&PAWN::CreateVehicle, vehicletype, x, y, z, rotation, color1, color2, respawn_delay);
}

void DestroyVehicle(int vehicleid) {
	g_Invoke->callNative(&PAWN::DestroyVehicle, vehicleid);
}

void IsVehicleStreamedIn(int vehicleid, int forplayerid) {
	g_Invoke->callNative(&PAWN::IsVehicleStreamedIn, vehicleid, forplayerid);
}

void GetVehiclePos(int vehicleid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetVehiclePos, vehicleid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void SetVehiclePos(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetVehiclePos, vehicleid, x, y, z);
}

void GetVehicleZAngle(int vehicleid, float& z_angle) {
	float _z_angle = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleZAngle, vehicleid, &_z_angle);
	z_angle = _z_angle;
}

void GetVehicleRotationQuat(int vehicleid, float& w, float& x, float& y, float& z) {
	float _w = NULL;
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleRotationQuat, vehicleid, &_w, &_x, &_y, &_z);
	w = _w;
	x = _x;
	y = _y;
	z = _z;
}

void GetVehicleDistanceFromPoint(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::GetVehicleDistanceFromPoint, vehicleid, x, y, z);
}

void SetVehicleZAngle(int vehicleid, float z_angle) {
	g_Invoke->callNative(&PAWN::SetVehicleZAngle, vehicleid, z_angle);
}

void SetVehicleParamsForPlayer(int vehicleid, int playerid, int objective, int doorslocked) {
	g_Invoke->callNative(&PAWN::SetVehicleParamsForPlayer, vehicleid, playerid, objective, doorslocked);
}

void ManualVehicleEngineAndLights() {
	//g_Invoke->callNative(&PAWN::ManualVehicleEngineAndLights);
}

void SetVehicleParamsEx(int vehicleid, int engine, int lights, int alarm, int doors, int bonnet, int boot, int objective) {
	g_Invoke->callNative(&PAWN::SetVehicleParamsEx, vehicleid, engine, lights, alarm, doors, bonnet, boot, objective);
}

void GetVehicleParamsEx(int vehicleid, int& engine, int& lights, int& alarm, int& doors, int& bonnet, int& boot, int& objective) {
	int _engine = NULL;
	int _lights = NULL;
	int _alarm = NULL;
	int _doors = NULL;
	int _bonnet = NULL;
	int _boot = NULL;
	int _objective = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleParamsEx, vehicleid, &_engine, &_lights, &_alarm, &_doors, &_bonnet, &_boot, &_objective);
	engine = _engine;
	lights = _lights;
	alarm = _alarm;
	doors = _doors;
	bonnet = _bonnet;
	boot = _boot;
	objective = _objective;
}

void SetVehicleToRespawn(int vehicleid) {
	g_Invoke->callNative(&PAWN::SetVehicleToRespawn, vehicleid);
}

void LinkVehicleToInterior(int vehicleid, int interiorid) {
	g_Invoke->callNative(&PAWN::LinkVehicleToInterior, vehicleid, interiorid);
}

void AddVehicleComponent(int vehicleid, int componentid) {
	g_Invoke->callNative(&PAWN::AddVehicleComponent, vehicleid, componentid);
}

void RemoveVehicleComponent(int vehicleid, int componentid) {
	g_Invoke->callNative(&PAWN::RemoveVehicleComponent, vehicleid, componentid);
}

void ChangeVehicleColor(int vehicleid, int color1, int color2) {
	g_Invoke->callNative(&PAWN::ChangeVehicleColor, vehicleid, color1, color2);
}

void ChangeVehiclePaintjob(int vehicleid, int paintjobid) {
	g_Invoke->callNative(&PAWN::ChangeVehiclePaintjob, vehicleid, paintjobid);
}

void SetVehicleHealth(int vehicleid, float health) {
	g_Invoke->callNative(&PAWN::SetVehicleHealth, vehicleid, health);
}

void GetVehicleHealth(int vehicleid, float& health) {
	float _health = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleHealth, vehicleid, &_health);
	health = _health;
}

void AttachTrailerToVehicle(int trailerid, int vehicleid) {
	g_Invoke->callNative(&PAWN::AttachTrailerToVehicle, trailerid, vehicleid);
}

void DetachTrailerFromVehicle(int vehicleid) {
	g_Invoke->callNative(&PAWN::DetachTrailerFromVehicle, vehicleid);
}

int IsTrailerAttachedToVehicle(int vehicleid) {
	return g_Invoke->callNative(&PAWN::IsTrailerAttachedToVehicle, vehicleid);
}

int GetVehicleTrailer(int vehicleid) {
	return g_Invoke->callNative(&PAWN::GetVehicleTrailer, vehicleid);
}

void SetVehicleNumberPlate(int vehicleid, char* numberplate) {
	g_Invoke->callNative(&PAWN::SetVehicleNumberPlate, vehicleid, numberplate);
}

int GetVehicleModel(int vehicleid) {
	return g_Invoke->callNative(&PAWN::GetVehicleModel, vehicleid);
}

int GetVehicleComponentInSlot(int vehicleid, int slot) {
	return g_Invoke->callNative(&PAWN::GetVehicleComponentInSlot, vehicleid, slot);
}

int GetVehicleComponentType(int component) {
	return g_Invoke->callNative(&PAWN::GetVehicleComponentType, component);
}

void RepairVehicle(int vehicleid) {
	g_Invoke->callNative(&PAWN::RepairVehicle, vehicleid);
}

void GetVehicleVelocity(int vehicleid, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleVelocity, vehicleid, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void SetVehicleVelocity(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetVehicleVelocity, vehicleid, x, y, z);
}

void SetVehicleAngularVelocity(int vehicleid, float x, float y, float z) {
	g_Invoke->callNative(&PAWN::SetVehicleAngularVelocity, vehicleid, x, y, z);
}

void GetVehicleDamageStatus(int vehicleid, int& panels, int& doors, int& lights, int& tires) {
	int _panels = NULL;
	int _doors = NULL;
	int _lights = NULL;
	int _tires = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleDamageStatus, vehicleid, &_panels, &_doors, &_lights, &_tires);
	panels = _panels;
	doors = _doors;
	lights = _lights;
	tires = _tires;
}

void UpdateVehicleDamageStatus(int vehicleid, int panels, int doors, int lights, int tires) {
	g_Invoke->callNative(&PAWN::UpdateVehicleDamageStatus, vehicleid, panels, doors, lights, tires);
}

void GetVehicleModelInfo(int vehiclemodel, int infotype, float& x, float& y, float& z) {
	float _x = NULL;
	float _y = NULL;
	float _z = NULL;
	g_Invoke->callNative(&PAWN::GetVehicleModelInfo, vehiclemodel, infotype, &_x, &_y, &_z);
	x = _x;
	y = _y;
	z = _z;
}

void SetVehicleVirtualWorld(int vehicleid, int worldid) {
	g_Invoke->callNative(&PAWN::SetVehicleVirtualWorld, vehicleid, worldid);
}

int GetVehicleVirtualWorld(int vehicleid) {
	return g_Invoke->callNative(&PAWN::GetVehicleVirtualWorld, vehicleid);
}