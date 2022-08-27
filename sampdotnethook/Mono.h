#ifndef _MONO_H
#define _MONO_H

// includes... duh...
#include <stdio.h>
#include <mono\jit\jit.h>
#include <mono\metadata\assembly.h>
#include <mono\metadata\debug-helpers.h>

class Mono {
public:
	void			init();
	MonoString*		createString(const char* string);
	int				callReturn(const char* name, void* args[]);
	void			callMethod(const char* name, void* args[]);
private:
	MonoDomain*		domain;
	MonoAssembly*	assembly;
	MonoImage*		image;
	MonoClass*		klass;
};

extern Mono *g_Mono;

#endif // _MONO_H