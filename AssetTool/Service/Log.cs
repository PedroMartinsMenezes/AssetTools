using System.Diagnostics;

namespace AssetTool
{
    public static class Log
    {
        public static bool Enabled { get; set; } = false;
        public static int WriteFileNumber { get; set; }

        public static string Info(string msg)
        {
            if (Enabled)
            {
                Console.WriteLine(msg);
                Debug.WriteLine(msg);
            }
            return msg;
        }

        public static string Error(string msg)
        {
            if (Enabled)
            {
                var currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
                Console.ForegroundColor = currentColor;

                Debug.WriteLine(msg);
            }
            return msg;
        }

        public static int InfoRead(FPropertyTag tag)
        {
            return (tag.Type.Value is "StructProperty" or "ArrayProperty" or "MapProperty" or "SetProperty") ? 1 : 0;
        }

        private static int InfoWrite1(FPropertyTag tag)
        {
            return (tag.Type.Value is "StructProperty" or "ArrayProperty" or "MapProperty" or "SetProperty") ? 1 : 0;
        }

        private static int InfoWrite2(FPropertyTag tag)
        {
            if (WriteFileNumber == 0)
                return 0;
            return (tag.Type.Value is "StructProperty" or "ArrayProperty" or "MapProperty" or "SetProperty") ? 1 : 0;
        }

        public static int InfoWrite(FPropertyTag tag, bool force)
        {
            if (force)
                return InfoWrite1(tag);

            if (WriteFileNumber == 0)
                return 0;
            else if (WriteFileNumber == 1)
                return InfoWrite1(tag);
            else
                return InfoWrite2(tag);
        }
    }
}
