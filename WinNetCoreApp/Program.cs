using System;
using System.Runtime.InteropServices;
using WinLogicLib;

namespace WinNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var result = Win.ReadEnvironmentVariable("Path").Split(';');
                Console.WriteLine($"The Path value is:");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
