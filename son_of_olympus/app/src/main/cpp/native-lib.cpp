#include <jni.h>
#include <string>

extern "C"
jstring
Java_com_son_1of_1olympus_MainActivity_stringFromJNI(
        JNIEnv* env,
        jobject /* this */) {
    std::string hello = "Hello from C++";
    return env->NewStringUTF(hello.c_str());
}
