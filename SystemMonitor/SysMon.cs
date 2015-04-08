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
                PerformanceCounter _Core1 = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
                return _Core1.RawValue;
            }
        }

        public float GetMemoryCount
        {
            get
            {
                PerformanceCounter _Core1 = new PerformanceCounter("Memory", "Available MBytes");
                return _Core1.NextValue();
            }
        }
    }
}
