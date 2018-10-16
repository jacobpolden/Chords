#include "stdafx.h"
#include "SDKDLL.h"

using namespace System;

const auto device_index = DEV_MKeys_S_White;
const auto off = KEY_COLOR{ 0 ,0, 0 };
const auto on = KEY_COLOR{ 255 ,255, 255 };

int main(array<System::String ^> ^args)
{
    SetControlDevice(device_index);
    auto bPlug = IsDevicePlug();

    if (bPlug)
    {
        Console::WriteLine("Keyboard is plugged in");
    }
    else
    {
        return 0;
    }

    EnableLedControl(false, device_index);

    SetFullLedColor(off.r, off.g, off.b);
    SetFullLedColor(on.r, on.g, on.b);
    SetFullLedColor(off.r, off.g, off.b);

    EnableLedControl(false);

    Console::ReadLine();
    return 0;
}
