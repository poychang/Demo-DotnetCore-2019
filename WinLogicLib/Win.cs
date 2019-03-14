using Microsoft.Win32;

namespace WinLogicLib
{
    public class Win
    {
        public static string ReadEnvironmentVariable(string key)
        {
            using (var registry = Registry.CurrentUser.OpenSubKey(@"Environment"))
            {
                if (registry?.GetValue(key) is string value)
                    return value;
            }

            return "Value not found.";
        }
    }
}
