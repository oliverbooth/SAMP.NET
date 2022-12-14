#include "Mono.h"

Mono *g_Mono;

void Mono::init() {
    /*#ifndef __win32__
    mono_set_dirs ("../lib/", "/etc/mono");
	#endif*/

	// Set up domain
	this->domain   = mono_jit_init_version("sampdotnet", "v2.0.50727");

	// Set up assembly, image and class for Script.dll invoke
	this->assembly = mono_domain_assembly_open(this->domain, "Script.dll");
	this->image    = mono_assembly_get_image(this->assembly);
	this->klass    = mono_class_from_name(this->image, "Script", "Script");

	// Invoke the loading method for Script.dll
	this->callMethod("Script:Load", 0);

	// That last method invoke was the last time we'll be calling to Script.dll
	this->assembly = mono_domain_assembly_open (this->domain,  "sampdotnet.dll");
	this->image    = mono_assembly_get_image   (this->assembly);
	this->klass    = 0; // We don't need this anymore
}

MonoString* Mono::createString(const char* string) {
	return mono_string_new(this->domain, string);
}

int Mono::callReturn(const char* name, void* args[]) {
	// Set method parameters
	MonoMethodDesc* desc    = mono_method_desc_new(name, false);
	MonoMethod*     method  = 0;

	// Determine if we're using the Class model or Image model
	if(this->klass != 0) {
		method = mono_method_desc_search_in_class(desc, this->klass);
	} else {
		method = mono_method_desc_search_in_image(desc, this->image);
	}

	// Free MonoMethodDesc object
	mono_method_desc_free(desc);

	// Invoke and return the value
	MonoObject* result      = mono_runtime_invoke(method, this->klass, args, 0);
	int int_result = 0;
	int_result = *(int*)mono_object_unbox(result);
	return int_result;
}

void Mono::callMethod(const char* name, void* args[]) {
	// Set method parameters
	MonoMethodDesc* desc    = mono_method_desc_new(name, false);
	MonoMethod*     method  = 0;

	// Determine if we're using the Class model or Image model
	if(this->klass != 0) {
		method = mono_method_desc_search_in_class(desc, this->klass);
	} else {
		method = mono_method_desc_search_in_image(desc, this->image);
	}

	// Free MonoMethodDesc object
	mono_method_desc_free(desc);

	// Invoke
	mono_runtime_invoke(method, this->klass, args, 0);
}

