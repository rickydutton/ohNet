/* DO NOT EDIT THIS FILE - it is machine generated */
#include <jni.h>
/* Header for class openhome_net_core_Library */

#ifndef _Included_openhome_net_core_Library
#define _Included_openhome_net_core_Library
#ifdef __cplusplus
extern "C" {
#endif
/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetLibraryInitialise
 * Signature: (J)J
 */
JNIEXPORT jlong JNICALL Java_openhome_net_core_Library_OhNetLibraryInitialise
  (JNIEnv *, jobject, jlong);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetSubnetListCreate
 * Signature: ()J
 */
JNIEXPORT jlong JNICALL Java_openhome_net_core_Library_OhNetSubnetListCreate
  (JNIEnv *, jobject);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetSubnetAt
 * Signature: (JI)I
 */
JNIEXPORT jint JNICALL Java_openhome_net_core_Library_OhNetSubnetAt
  (JNIEnv *, jobject, jlong, jint);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetNetworkAdapterAddress
 * Signature: (J)I
 */
JNIEXPORT jint JNICALL Java_openhome_net_core_Library_OhNetNetworkAdapterAddress
  (JNIEnv *, jobject, jlong);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetNetworkAdapterSubnet
 * Signature: (J)I
 */
JNIEXPORT jint JNICALL Java_openhome_net_core_Library_OhNetNetworkAdapterSubnet
  (JNIEnv *, jobject, jlong);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetCurrentSubnetAdapter
 * Signature: ()J
 */
JNIEXPORT jlong JNICALL Java_openhome_net_core_Library_OhNetCurrentSubnetAdapter
  (JNIEnv *, jobject);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetSubnetListDestroy
 * Signature: (J)V
 */
JNIEXPORT void JNICALL Java_openhome_net_core_Library_OhNetSubnetListDestroy
  (JNIEnv *, jobject, jlong);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetLibraryStartCp
 * Signature: (I)V
 */
JNIEXPORT void JNICALL Java_openhome_net_core_Library_OhNetLibraryStartCp
  (JNIEnv *, jobject, jint);

/*
 * Class:     openhome_net_core_Library
 * Method:    OhNetLibraryClose
 * Signature: ()V
 */
JNIEXPORT void JNICALL Java_openhome_net_core_Library_OhNetLibraryClose
  (JNIEnv *, jobject);

#ifdef __cplusplus
}
#endif
#endif
