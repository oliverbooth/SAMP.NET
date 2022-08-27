#ifndef _MAIN_H
#define _MAIN_H

#include "callbacks.h"
#include "a_samp.h"
#include "Mono.h"
#include "add.h"

#define __SDNH_VERSION_ ("0.6-dev")

PLUGIN_EXPORT void _samp_logprintf(char *message);
PLUGIN_EXPORT unsigned int PLUGIN_CALL Supports();
PLUGIN_EXPORT bool PLUGIN_CALL Load(void** ppData);
PLUGIN_EXPORT void PLUGIN_CALL Unload();
PLUGIN_EXPORT int PLUGIN_CALL AmxLoad(AMX* amx);
PLUGIN_EXPORT int PLUGIN_CALL AmxUnload(AMX* amx);

#endif // _MAIN_H

