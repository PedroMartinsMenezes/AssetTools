using System.Diagnostics;

namespace AssetTool
{
    public static class Log
    {
        public static string Info(string msg)
        {
            Console.WriteLine(msg);
            Debug.WriteLine(msg);
            return msg;
        }
    }
}
