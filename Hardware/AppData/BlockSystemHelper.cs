using System;
using System.Windows.Threading;

namespace Hardware.AppData
{
    internal class BlockSystemHelper
    {
        public static int incorrectInput = 0;
        public static DispatcherTimer timer = new DispatcherTimer()
        {
            Interval = new TimeSpan(0, 0, 1)
        };
        public static int IncreaseIncorrectInput() => ++incorrectInput;
    }
}
