using System.Diagnostics;

namespace AssetTool
{
    public static class Log
    {
        public static void Info(string msg)
        {
            Console.WriteLine(msg);
            Debug.WriteLine(msg);
        }
    }
}
