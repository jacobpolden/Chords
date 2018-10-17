using System;

namespace Chords.CoreApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CoolerMasterSdkWrapper.SetControlDevice(CoolerMasterSdkWrapper.DeviceIndex.DevMKeysSWhite);

            Console.WriteLine(CoolerMasterSdkWrapper.IsDevicePlug());

            CoolerMasterSdkWrapper.EnableLedControl(true);
            CoolerMasterSdkWrapper.RefreshLed(false);

            Console.WriteLine(CoolerMasterSdkWrapper.SetLedColor(3, 1, 255, 255, 255));
            CoolerMasterSdkWrapper.SetLedColor(3, 1, 0, 0, 0);
            CoolerMasterSdkWrapper.SetLedColor(3, 1, 255, 255, 255);

            CoolerMasterSdkWrapper.EnableLedControl(false);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
