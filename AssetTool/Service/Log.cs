using System.Diagnostics;

namespace AssetTool
{
    public static class Log
    {
        public static bool Enabled { get; set; } = true;
        private static bool ReadLogOpened = false;
        public static int WriteFileNumber { get; set; }
        private static bool[] WriteLogOpened = [false, false];
        private static HashSet<string> UnknownStruct = [];

        static Log()
        {
            if (AppConfig.LogUnknownStruct)
            {
                File.WriteAllText("C:/Temp/UnknownStruct.txt", "");

                UnknownStruct.Add("BoneNode");
                UnknownStruct.Add("StaticSwitchParameter");
                UnknownStruct.Add("StaticParameterSetEditorOnlyData");
                UnknownStruct.Add("MaterialInstanceBasePropertyOverrides");
                UnknownStruct.Add("TextureParameterValue");
                UnknownStruct.Add("MaterialParameterInfo");
                UnknownStruct.Add("ScalarParameterAtlasInstanceData");
                UnknownStruct.Add("ScalarParameterValue");
            }
        }

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

        public static int InfoRead(long offset, int indent, FPropertyTag tag)
        {
            if (offset >= AppConfig.LogStartOffset && offset < AppConfig.LogEndOffset)
            {
                (string name, string structName, string type, string innerType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size);
                string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                string prefix = type == "ArrayProperty" ? $"{innerType ?? type}[]" : type == "StructProperty" ? $"{structName ?? innerType}" : $"{type}{arrayIndex}:";
                string msg = $"[{size,-8}] {string.Empty.PadLeft(indent, '.')}{prefix} {name}";
                Log.Info(msg);
                if (!ReadLogOpened)
                {
                    ReadLogOpened = true;
                    File.WriteAllLines("C:/Temp/Read.log", [msg]);
                }
                else
                {
                    File.AppendAllLines("C:/Temp/Read.log", [msg]);
                }
            }
            return (tag.Type.Value is "StructProperty" or "ArrayProperty" or "MapProperty") ? 2 : 0;
        }

        private static int InfoWrite1(long offset, int indent, FPropertyTag tag)
        {
            if (offset >= AppConfig.LogStartOffset && offset < AppConfig.LogEndOffset)
            {
                (string name, string structName, string type, string innerType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size);
                string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                string prefix = type == "ArrayProperty" ? $"{innerType ?? type}[]" : type == "StructProperty" ? $"{structName ?? innerType}" : $"{type}{arrayIndex}:";
                string msg = $"[{size,-8}] {string.Empty.PadLeft(indent, '.')}{prefix} {name}";
                if (!WriteLogOpened[WriteFileNumber - 1])
                {
                    WriteLogOpened[WriteFileNumber - 1] = true;
                    File.WriteAllLines($"C:/Temp/Write1.log", [msg]);
                }
                else
                {
                    File.AppendAllLines($"C:/Temp/Write1.log", [msg]);
                }
            }
            return (tag.Type.Value is "StructProperty" or "ArrayProperty" or "MapProperty") ? 2 : 0;
        }

        private static int InfoWrite2(long offset, int indent, FPropertyTag tag)
        {
            if (WriteFileNumber == 0)
                return 0;

            if (offset >= AppConfig.LogStartOffset && offset < AppConfig.LogEndOffset)
            {
                (string name, string structName, string type, string innerType, int size) = (tag.Name?.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size);
                string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                string prefix = type == "ArrayProperty" ? $"{innerType ?? type}[]" : type == "StructProperty" ? $"{structName ?? innerType}" : $"{type}{arrayIndex}:";
                string msg = $"[{size,-8}] {string.Empty.PadLeft(indent, '.')}{prefix} {name}";
                if (!WriteLogOpened[WriteFileNumber - 1])
                {
                    WriteLogOpened[WriteFileNumber - 1] = true;
                    File.WriteAllLines($"C:/Temp/Write2.log", [msg]);
                }
                else
                {
                    File.AppendAllLines($"C:/Temp/Write2.log", [msg]);
                }
            }
            return (tag.Type.Value is "StructProperty" or "ArrayProperty" or "MapProperty") ? 2 : 0;
        }

        public static int InfoWrite(long offset, int indent, FPropertyTag tag, bool force)
        {
            if (force)
                return InfoWrite1(offset, indent, tag);

            if (WriteFileNumber == 0)
                return 0;
            else if (WriteFileNumber == 1)
                return InfoWrite1(offset, indent, tag);
            else
                return InfoWrite2(offset, indent, tag);
        }

        public static void LogUnknownStruct(string structName)
        {
            if (AppConfig.LogUnknownStruct && !UnknownStruct.Contains(structName))
            {
                UnknownStruct.Add(structName);
                File.AppendAllLines("C:/Temp/UnknownStruct.txt", [$"TStructOpsTypeTraits<F{structName}>"]);
            }
        }
    }
}
