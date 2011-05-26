#include <C/DvProvider.h>
#include <DvProvider.h>
#include <DviService.h>
#include <C/DviDeviceC.h>
#include <Core/DvDevice.h>
#include <FunctorDviInvocation.h>

using namespace OpenHome;
using namespace OpenHome::Net;

class DvProviderWrapper : public DvProvider
{
public:
    DvProviderWrapper(DviDevice& aDevice, const TChar* aDomain, const TChar* aType, TUint aVersion) : DvProvider(aDevice, aDomain, aType, aVersion) {}
    ~DvProviderWrapper() {}
    void AddAction(OpenHome::Net::Action* aAction, FunctorDviInvocation aInvocation) { iService->AddAction(aAction, aInvocation); }
    void AddProperty(OpenHome::Net::Property* aProperty) { iService->AddProperty(aProperty); }
    bool SetPropertyInt(PropertyInt& aProperty, TInt aValue) { return DvProvider::SetPropertyInt(aProperty, aValue); }
    bool SetPropertyUint(PropertyUint& aProperty, TUint aValue) { return DvProvider::SetPropertyUint(aProperty, aValue); }
    bool SetPropertyBool(PropertyBool& aProperty, TBool aValue) { return DvProvider::SetPropertyBool(aProperty, aValue); }
    bool SetPropertyString(PropertyString& aProperty, const Brx& aValue) { return DvProvider::SetPropertyString(aProperty, aValue); }
    bool SetPropertyBinary(PropertyBinary& aProperty, const Brx& aValue) { return DvProvider::SetPropertyBinary(aProperty, aValue); }
};

static DvProviderWrapper* ProviderFromHandle(DvProviderC aProvider)
{
    DvProviderWrapper* provider = reinterpret_cast<DvProviderWrapper*>(aProvider);
    ASSERT(provider != NULL);
    return provider;
}

DvProviderC DvProviderCreate(DvDeviceC aDevice, const char* aDomain, const char* aType, uint32_t aVersion)
{
    DvDevice* d = DviDeviceC::DeviceFromHandle(aDevice);
    DviDevice& device = d->Device();
    return (DvProviderC)new DvProviderWrapper(device, aDomain, aType, aVersion);
}

void DvProviderDestroy(DvProviderC aProvider)
{
    delete reinterpret_cast<DvProviderWrapper*>(aProvider);
}

void DvProviderAddAction(DvProviderC aProvider, ServiceAction aAction, OhNetCallbackDvInvocation aCallback, void* aPtr)
{
    OhNetFunctorDviInvocation cb = reinterpret_cast<OhNetFunctorDviInvocation>(aCallback);
    FunctorDviInvocation functor = MakeFunctorDviInvocation(aPtr, cb);
    OpenHome::Net::Action* action = reinterpret_cast<OpenHome::Net::Action*>(aAction);
    ProviderFromHandle(aProvider)->AddAction(action, functor);
}

void DvProviderPropertiesLock(DvProviderC aProvider)
{
    ProviderFromHandle(aProvider)->PropertiesLock();
}

void DvProviderPropertiesUnlock(DvProviderC aProvider)
{
    ProviderFromHandle(aProvider)->PropertiesUnlock();
}

void DvProviderAddProperty(DvProviderC aProvider, ServiceProperty aProperty)
{
    OpenHome::Net::Property* prop = reinterpret_cast<OpenHome::Net::Property*>(aProperty);
    ASSERT(prop != NULL);
    ProviderFromHandle(aProvider)->AddProperty(prop);
}

int32_t DvProviderSetPropertyInt(DvProviderC aProvider, ServiceProperty aProperty, int32_t aValue, uint32_t* aChanged)
{
    try {
        PropertyInt* prop = reinterpret_cast<PropertyInt*>(aProperty);
        ASSERT(prop != NULL);
        TBool changed = ProviderFromHandle(aProvider)->SetPropertyInt(*prop, aValue);
        *aChanged = (changed? 1 : 0);
    }
    catch (ParameterValidationError&) {
        return -1;
    }
    return 0;
}

int32_t DvProviderSetPropertyUint(DvProviderC aProvider, ServiceProperty aProperty, uint32_t aValue, uint32_t* aChanged)
{
    try {
        PropertyUint* prop = reinterpret_cast<PropertyUint*>(aProperty);
        ASSERT(prop != NULL);
        TBool changed = ProviderFromHandle(aProvider)->SetPropertyUint(*prop, aValue);
        *aChanged = (changed? 1 : 0);
    }
    catch (ParameterValidationError&) {
        return -1;
    }
    return 0;
}

int32_t DvProviderSetPropertyBool(DvProviderC aProvider, ServiceProperty aProperty, uint32_t aValue, uint32_t* aChanged)
{
    try {
        PropertyBool* prop = reinterpret_cast<PropertyBool*>(aProperty);
        ASSERT(prop != NULL);
        TBool value = (aValue != 0);
        TBool changed = ProviderFromHandle(aProvider)->SetPropertyBool(*prop, value);
        *aChanged = (changed? 1 : 0);
    }
    catch (ParameterValidationError&) {
        return -1;
    }
    return 0;
}

int32_t DvProviderSetPropertyString(DvProviderC aProvider, ServiceProperty aProperty, const char* aValue, uint32_t* aChanged)
{
    try {
        PropertyString* prop = reinterpret_cast<PropertyString*>(aProperty);
        ASSERT(prop != NULL);
        Brn value(aValue);
        TBool changed = ProviderFromHandle(aProvider)->SetPropertyString(*prop, value);
        *aChanged = (changed? 1 : 0);
    }
    catch (ParameterValidationError&) {
        return -1;
    }
    return 0;
}

int32_t DvProviderSetPropertyBinary(DvProviderC aProvider, ServiceProperty aProperty, const uint8_t* aData, uint32_t aLen, uint32_t* aChanged)
{
    try {
        PropertyBinary* prop = reinterpret_cast<PropertyBinary*>(aProperty);
        ASSERT(prop != NULL);
        TBool changed;
        if (aLen == 0)
        {
            changed = ProviderFromHandle(aProvider)->SetPropertyBinary(*prop, Brx::Empty());
        }
        else
        {
            Brn data(aData, aLen);
            changed = ProviderFromHandle(aProvider)->SetPropertyBinary(*prop, data);
        }
        *aChanged = (changed? 1 : 0);
    }
    catch (ParameterValidationError&) {
        return -1;
    }
    return 0;
}



static IDviInvocation* InvocationFromHandle(DvInvocationC aInvocation)
{
    IDviInvocation* invocation = reinterpret_cast<IDviInvocation*>(aInvocation);
    ASSERT(invocation != NULL);
    return invocation;
}

int32_t DvInvocationReadStart(DvInvocationC aInvocation)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationReadStart();
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReadInt(DvInvocationC aInvocation, const char* aName, int32_t* aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        *aValue = invocation->InvocationReadInt(aName);
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReadUint(DvInvocationC aInvocation, const char* aName, uint32_t* aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        *aValue = invocation->InvocationReadUint(aName);
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReadBool(DvInvocationC aInvocation, const char* aName, uint32_t* aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        TBool value = invocation->InvocationReadBool(aName);
        *aValue = (value? 1 : 0);
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReadString(DvInvocationC aInvocation, const char* aName, char** aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        Brhz value;
        invocation->InvocationReadString(aName, value);
        *aValue = value.Transfer();
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReadBinary(DvInvocationC aInvocation, const char* aName, uint8_t** aData, uint32_t* aLen)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        Brh value;
        invocation->InvocationReadBinary(aName, value);
        *aLen = value.Bytes();
        *aData = (uint8_t*)value.Extract();
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReadEnd(DvInvocationC aInvocation)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationReadEnd();
    }
    catch (InvocationError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationReportError(DvInvocationC aInvocation, uint32_t aCode, const char* aDescription)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        Brn desc(aDescription);
        invocation->InvocationReportError(aCode, desc);
    }
    catch (WriterError&) {
        return -1;
    }
    catch (InvocationError&) {}
    return 0;
}

int32_t DvInvocationWriteStart(DvInvocationC aInvocation)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteStart();
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteInt(DvInvocationC aInvocation, const char* aName, int32_t aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteInt(aName, aValue);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteUint(DvInvocationC aInvocation, const char* aName, uint32_t aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteUint(aName, aValue);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteBool(DvInvocationC aInvocation, const char* aName, uint32_t aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        TBool value = (aValue != 0);
        invocation->InvocationWriteBool(aName, value);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteStringStart(DvInvocationC aInvocation, const char* aName)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteStringStart(aName);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteString(DvInvocationC aInvocation, const char* aValue)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        Brn value(aValue);
        invocation->InvocationWriteString(value);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteStringEnd(DvInvocationC aInvocation, const char* aName)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteStringEnd(aName);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteBinaryStart(DvInvocationC aInvocation, const char* aName)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteBinaryStart(aName);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteBinary(DvInvocationC aInvocation, const uint8_t* aData, uint32_t aLen)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        Brn data(aData, aLen);
        invocation->InvocationWriteBinary(data);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteBinaryEnd(DvInvocationC aInvocation, const char* aName)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteBinaryEnd(aName);
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}

int32_t DvInvocationWriteEnd(DvInvocationC aInvocation)
{
    IDviInvocation* invocation = InvocationFromHandle(aInvocation);
    try {
        invocation->InvocationWriteEnd();
    }
    catch (WriterError&) {
        return -1;
    }
    return 0;
}
