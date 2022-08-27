#ifndef _A_VEHICLES_H
#define _A_VEHICLES_H

int CreateVehicle(int vehicletype, float x, float y, float z, float rotation, int color1, int color2, int respawn_delay);
void DestroyVehicle(int vehicleid);
void IsVehicleStreamedIn(int vehicleid, int forplayerid);
void GetVehiclePos(int vehicleid, float& x, float& y, float& z);
void SetVehiclePos(int vehicleid, float x, float y, float z);
void GetVehicleZAngle(int vehicleid, float& z_angle);
void GetVehicleRotationQuat(int vehicleid, float& w, float& x, float& y, float& z);
void GetVehicleDistanceFromPoint(int vehicleid, float x, float y, float z);
void SetVehicleZAngle(int vehicleid, float z_angle);
void SetVehicleParamsForPlayer(int vehicleid, int playerid, int objective, int doorslocked);
void ManualVehicleEngineAndLights(int );
void SetVehicleParamsEx(int vehicleid, int engine, int lights, int alarm, int doors, int bonnet, int boot, int objective);
void GetVehicleParamsEx(int vehicleid, int& engine, int& lights, int& alarm, int& doors, int& bonnet, int& boot, int& objective);
void SetVehicleToRespawn(int vehicleid);
void LinkVehicleToInterior(int vehicleid, int interiorid);
void AddVehicleComponent(int vehicleid, int componentid);
void RemoveVehicleComponent(int vehicleid, int componentid);
void ChangeVehicleColor(int vehicleid, int color1, int color2);
void ChangeVehiclePaintjob(int vehicleid, int paintjobid);
void SetVehicleHealth(int vehicleid, float health);
void GetVehicleHealth(int vehicleid, float& health);
void AttachTrailerToVehicle(int trailerid, int vehicleid);
void DetachTrailerFromVehicle(int vehicleid);
int IsTrailerAttachedToVehicle(int vehicleid);
int GetVehicleTrailer(int vehicleid);
void SetVehicleNumberPlate(int vehicleid, char* numberplate);
int GetVehicleModel(int vehicleid);
int GetVehicleComponentInSlot(int vehicleid, int slot);
int GetVehicleComponentType(int component);
void RepairVehicle(int vehicleid);
void GetVehicleVelocity(int vehicleid, float& x, float& y, float& z);
void SetVehicleVelocity(int vehicleid, float x, float y, float z);
void SetVehicleAngularVelocity(int vehicleid, float x, float y, float z);
void GetVehicleDamageStatus(int vehicleid, int& panels, int& doors, int& lights, int& tires);
void UpdateVehicleDamageStatus(int vehicleid, int panels, int doors, int lights, int tires);
void GetVehicleModelInfo(int vehiclemodel, int infotype, float& x, float& y, float& z);
void SetVehicleVirtualWorld(int vehicleid, int worldid);
int GetVehicleVirtualWorld(int vehicleid);

#endif //_A_VEHICLES_H