using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SystemMonitor
{
    public class SysMon
    {
        public float GetCoreUsageByPercent 
        { 
            get 
            {
                PerformanceCounter _Core1 = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                return _Core1.NextValue();
            }
        }

        public float GetMemoryCount
        {
            get
            {
                PerformanceCounter Mem1 = new PerformanceCounter("Memory", "Available MBytes");
                return Mem1.NextValue();
            }
        }
    }
}
