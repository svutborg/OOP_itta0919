using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3f._7
{
    // for exercise 3f.7
    class Phone
    {
        string model;
        string manufacturer;
        double price;
        string owner;

        string batteryModel;
        TimeSpan batteryIdleTime;
        TimeSpan batteryHoursTalk;

        int screenSize;
        int screenNumColors;

        // for exercise 3f.9
        BatteryType batteryType;

        // for exercise 3f.B
        List<Call> CallHistory;

    }

    // for exercise 3f.9
    enum BatteryType { LiIon, NiMH, NiCd }
}
