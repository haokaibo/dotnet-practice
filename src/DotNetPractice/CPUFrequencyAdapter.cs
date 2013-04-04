using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace DotNetPractice
{
    class CPUFrequencyAdapter
    {
        private const int sampleCount = 200;
        public void CPUSpeed()
        {
            RegistryKey myRegistryKey = Registry.LocalMachine;
            myRegistryKey = myRegistryKey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            Object cpuSpeed = myRegistryKey.GetValue("~MHz");
            Object cpuType = myRegistryKey.GetValue("VendorIdentifier");
            Console.WriteLine("You have a {0} running at {1} MHz.", cpuType, cpuSpeed);
        }

        private Stopwatch sw = new Stopwatch();

        public void StaticAdjustFrequencyOfSingleCPU(float frequencyOfCPU)
        {
            while (true)
            {
                // 2.66 GHz = 2.66 * pow(10,9) / (5 code lines for one loop)
                int loopCount = (int)(frequencyOfCPU * Math.Pow(10, 9) * 2 / 5);
                for (int i = 0; i < loopCount; i++)
                {

                }
                Thread.Sleep(10);
            }
        }

        public void StaticAdjustFrequencyOfSingleCPU2(TimeSpan busyTime, TimeSpan idleTime)
        {
            while (true)
            {
                sw.Restart();
                while (sw.Elapsed < busyTime)
                {
                    Console.WriteLine(sw.Elapsed);
                }
                sw.Stop();
                Thread.Sleep(idleTime);
            }
        }

        public void DynamicAdjustFrequencyOfSingleCPU(float level, int idleTime)
        {
            PerformanceCounter pc = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            while (true)
            {
                if (pc.NextValue() > level)
                {
                    Thread.Sleep(idleTime);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", pc.InstanceName, pc.NextValue());
                }
            }
        }

        private uint GetTickCount()
        {
            Stopwatch stopWatch = new Stopwatch();
            return 0;
        }

        public void AdjustFrenquecyOfCPUToDrawSINCurve()
        {

            double PI = 3.1415926535;
            int totalAmplitude = 3000; // 每个抽样点对应的时间片
            uint[] busySpan = new uint[sampleCount];
            double radian = 0.0;
            int amplitude = totalAmplitude / 2;
            double radianIncrement = 2.0 / (double)sampleCount;// SAMPLE radian INCREMENT
            for (int i = 0; i < sampleCount; i++, radian += radianIncrement)
            {
                busySpan[i] = (uint)(amplitude + Math.Sin(PI * radian) * amplitude);
                Console.WriteLine("busySpan: {0}\t idleSpan: {1}", busySpan[i], totalAmplitude - busySpan[i]);
            }
            Thread.BeginThreadAffinity();
            for (int j = 0; ; j = (j + 1) % sampleCount)
            {
                sw.Restart();
                while (sw.ElapsedTicks < busySpan[j])
                {
                    Console.WriteLine(sw.Elapsed);
                }
                sw.Stop();
                Thread.Sleep((int)(totalAmplitude - busySpan[j]));
            }
            Thread.EndThreadAffinity();
        }
    }
}
