#include <jni.h>
#include <malloc.h>
#include <stdlib.h>
#include "Parameter.h"
#include "C/Service.h"

/*
 * Class:     ohnet_Parameter
 * Method:    ServiceParameterCreateInt
 * Signature: (Ljava/lang/String;III)J
 */
JNIEXPORT jlong JNICALL Java_ohnet_Parameter_ServiceParameterCreateInt
  (JNIEnv *env, jobject obj, jstring name, jint minVal, jint maxVal, jint step)
{
	const char* nativeName = (*env)->GetStringUTFChars(env, name, NULL);
	
	ServiceParameter param = ServiceParameterCreateInt(nativeName, minVal, maxVal, step);
	
	(*env)->ReleaseStringUTFChars(env, name, nativeName);
	
	return (jlong) param;
}

/*
 * Class:     ohnet_Parameter
 * Method:    ServiceParameterCreateUint
 * Signature: (Ljava/lang/String;JJJ)J
 */
JNIEXPORT jlong JNICALL Java_ohnet_Parameter_ServiceParameterCreateUint
  (JNIEnv *env, jobject obj, jstring name, jlong minVal, jlong maxVal, jlong step)
{
	const char* nativeName = (*env)->GetStringUTFChars(env, name, NULL);
	
	ServiceParameter param = ServiceParameterCreateUint(nativeName, minVal, maxVal, step);
	
	(*env)->ReleaseStringUTFChars(env, name, nativeName);
	
	return (jlong) param;
}

/*
 * Class:     ohnet_Parameter
 * Method:    ServiceParameterCreateBool
 * Signature: (Ljava/lang/String;)J
 */
JNIEXPORT jlong JNICALL Java_ohnet_Parameter_ServiceParameterCreateBool
  (JNIEnv *env, jobject obj, jstring name)
{
	const char* nativeName = (*env)->GetStringUTFChars(env, name, NULL);
	
	ServiceParameter param = ServiceParameterCreateBool(nativeName);
	
	(*env)->ReleaseStringUTFChars(env, name, nativeName);
	
	return (jlong) param;
}

/*
 * Class:     ohnet_Parameter
 * Method:    ServiceParameterCreateString
 * Signature: (Ljava/lang/String;[Ljava/lang/String;I)J
 */
JNIEXPORT jlong JNICALL Java_ohnet_Parameter_ServiceParameterCreateString
  (JNIEnv *env, jobject obj, jstring name, jobjectArray allowedVals, jint count)
{
	const char* nativeName = (*env)->GetStringUTFChars(env, name, NULL);
	char** nativeAllowed = (char**) malloc(count * sizeof(char *));
	ServiceParameter param;
	
	int i = 0;
	
	for (i; i < count; i++)
	{
		jstring allowedString = (*env)->GetObjectArrayElement(env, allowedVals, i);
		const char* nativeAllowedString = (*env)->GetStringUTFChars(env, allowedString, NULL);
		
		nativeAllowed[i] = (char *) nativeAllowedString;
		
		// Should this be called after we are done with the method, in case it frees a value we are using?
		(*env)->ReleaseStringUTFChars(env, allowedString, nativeAllowed[i]);
	}

	param = ServiceParameterCreateString(nativeName, nativeAllowed, count);
	
	(*env)->ReleaseStringUTFChars(env, name, nativeName);
	
	//free(nativeAllowed);
	
	return (jlong) param;
}

/*
 * Class:     ohnet_Parameter
 * Method:    ServiceParameterCreateBinary
 * Signature: (Ljava/lang/String;)J
 */
JNIEXPORT jlong JNICALL Java_ohnet_Parameter_ServiceParameterCreateBinary
  (JNIEnv *env, jobject obj, jstring name)
{
	const char* nativeName = (*env)->GetStringUTFChars(env, name, NULL);
	
	ServiceParameter param = ServiceParameterCreateBinary(nativeName);
	
	(*env)->ReleaseStringUTFChars(env, name, nativeName);
	
	return (jlong) param;
}

/*
 * Class:     ohnet_Parameter
 * Method:    ServiceParameterCreateRelated
 * Signature: (Ljava/lang/String;J)J
 */
JNIEXPORT jlong JNICALL Java_ohnet_Parameter_ServiceParameterCreateRelated
  (JNIEnv *env, jobject obj, jstring name, jlong propPtr)
{
	const char* nativeName = (*env)->GetStringUTFChars(env, name, NULL);
	ServiceProperty property = (ServiceProperty) propPtr;
	
	ServiceParameter param = ServiceParameterCreateRelated(nativeName, property);
	
	(*env)->ReleaseStringUTFChars(env, name, nativeName);
	
	return (jlong) param;
}
