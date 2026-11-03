// NativeLib.cpp

extern "C" __declspec(dllexport)
int Voltage(int current, int resistance)
{
    return current * resistance;
}

extern "C" __declspec(dllexport)
int Current(int voltage, int resistance)
{
    return voltage / resistance;
}

extern "C" __declspec(dllexport)
int Resistance(int voltage, int current)
{
    return voltage / current;
}