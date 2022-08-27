#ifndef _A_VEHICLES_H
#define _A_VEHICLES_H

PLUGIN_EXPORT int  _samp_CreateVehicle(int vehicletype, float x, float y, float z, float rotation, int color1, int color2, int respawn_delay);
PLUGIN_EXPORT void _samp_DestroyVehicle(int vehicleid);
PLUGIN_EXPORT void _samp_IsVehicleStreamedIn(int vehicleid, int forplayerid);
PLUGIN_EXPORT void _samp_GetVehiclePos(int vehicleid, float& x, float& y, float& z);
PLUGIN_EXPORT void _samp_SetVehiclePos(int vehicleid, float x, float y, float z);
PLUGIN_EXPORT void _samp_GetVehicleZAngle(int vehicleid, float& z_angle);
PLUGIN_EXPORT void _samp_GetVehicleRotationQuat(int vehicleid, float& w, float& x, float& y, float& z);
PLUGIN_EXPORT void _samp_GetVehicleDistanceFromPoint(int vehicleid, float x, float y, float z);
PLUGIN_EXPORT void _samp_SetVehicleZAngle(int vehicleid, float z_angle);
PLUGIN_EXPORT void _samp_SetVehicleParamsForPlayer(int vehicleid, int playerid, int objective, int doorslocked);
PLUGIN_EXPORT void _samp_ManualVehicleEngineAndLights(int );
PLUGIN_EXPORT void _samp_SetVehicleParamsEx(int vehicleid, int engine, int lights, int alarm, int doors, int bonnet, int boot, int objective);
PLUGIN_EXPORT void _samp_GetVehicleParamsEx(int vehicleid, int& engine, int& lights, int& alarm, int& doors, int& bonnet, int& boot, int& objective);
PLUGIN_EXPORT void _samp_SetVehicleToRespawn(int vehicleid);
PLUGIN_EXPORT void _samp_LinkVehicleToInterior(int vehicleid, int interiorid);
PLUGIN_EXPORT void _samp_AddVehicleComponent(int vehicleid, int componentid);
PLUGIN_EXPORT void _samp_RemoveVehicleComponent(int vehicleid, int componentid);
PLUGIN_EXPORT void _samp_ChangeVehicleColor(int vehicleid, int color1, int color2);
PLUGIN_EXPORT void _samp_ChangeVehiclePaintjob(int vehicleid, int paintjobid);
PLUGIN_EXPORT void _samp_SetVehicleHealth(int vehicleid, float health);
PLUGIN_EXPORT void _samp_GetVehicleHealth(int vehicleid, float& health);
PLUGIN_EXPORT void _samp_AttachTrailerToVehicle(int trailerid, int vehicleid);
PLUGIN_EXPORT void _samp_DetachTrailerFromVehicle(int vehicleid);
PLUGIN_EXPORT int  _samp_IsTrailerAttachedToVehicle(int vehicleid);
PLUGIN_EXPORT int  _samp_GetVehicleTrailer(int vehicleid);
PLUGIN_EXPORT void _samp_SetVehicleNumberPlate(int vehicleid, char* numberplate);
PLUGIN_EXPORT int  _samp_GetVehicleModel(int vehicleid);
PLUGIN_EXPORT int  _samp_GetVehicleComponentInSlot(int vehicleid, int slot);
PLUGIN_EXPORT int  _samp_GetVehicleComponentType(int component);
PLUGIN_EXPORT void _samp_RepairVehicle(int vehicleid);
PLUGIN_EXPORT void _samp_GetVehicleVelocity(int vehicleid, float& x, float& y, float& z);
PLUGIN_EXPORT void _samp_SetVehicleVelocity(int vehicleid, float x, float y, float z);
PLUGIN_EXPORT void _samp_SetVehicleAngularVelocity(int vehicleid, float x, float y, float z);
PLUGIN_EXPORT void _samp_GetVehicleDamageStatus(int vehicleid, int& panels, int& doors, int& lights, int& tires);
PLUGIN_EXPORT void _samp_UpdateVehicleDamageStatus(int vehicleid, int panels, int doors, int lights, int tires);
PLUGIN_EXPORT void _samp_GetVehicleModelInfo(int vehiclemodel, int infotype, float& x, float& y, float& z);
PLUGIN_EXPORT void _samp_SetVehicleVirtualWorld(int vehicleid, int worldid);
PLUGIN_EXPORT int  _samp_GetVehicleVirtualWorld(int vehicleid);

#endif //_A_VEHICLES_H

