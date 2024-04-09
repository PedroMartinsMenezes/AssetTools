using System.Diagnostics;

namespace AssetTool
{
    public static class Log
    {
        static bool ReadLogOpened = false;

        public static int WriteFileNumber { get; set; }
        static bool[] WriteLogOpened = [false, false];

        public static string Info(string msg)
        {
            Console.WriteLine(msg);
            Debug.WriteLine(msg);
            return msg;
        }

        public static int Info(BinaryReader reader, int indent, FPropertyTag tag, long baseOffset)
        {
            if (reader.BaseStream.Position >= AppConfig.LogStartOffset && reader.BaseStream.Position < AppConfig.LogEndOffset)
            {
                (long startOffset, long endOffset) = (reader.BaseStream.Position, reader.BaseStream.Position + tag.Size);
                (string name, string structName, string type, string innerType, int size) = (tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size);
                string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                string prefix = type == "ArrayProperty" ? $"{innerType ?? type}[]" : type == "StructProperty" ? $"{structName ?? innerType}" : $"{type}{arrayIndex}:";
                //string msg = $"    {string.Empty.PadLeft(indent)}[{startOffset - baseOffset} - {endOffset - baseOffset}] {size,-5} {prefix} {name}";
                string msg = $"    {string.Empty.PadLeft(indent)} {size,-8} {prefix} {name}";
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
            return (tag.Type.Value is "StructProperty" or "ArrayProperty") ? 2 : 0;
        }

        public static int Info(BinaryWriter writer, int indent, FPropertyTag tag, long baseOffset)
        {
            if (WriteFileNumber == 0)
                return 0;

            if (writer.BaseStream.Position >= AppConfig.LogStartOffset && writer.BaseStream.Position < AppConfig.LogEndOffset)
            {
                (long startOffset, long endOffset) = (writer.BaseStream.Position, writer.BaseStream.Position + tag.Size);
                (string name, string structName, string type, string innerType, int size) = (tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size);
                string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                string prefix = type == "ArrayProperty" ? $"{innerType ?? type}[]" : type == "StructProperty" ? $"{structName ?? innerType}" : $"{type}{arrayIndex}:";
                ///string msg = $"    {string.Empty.PadLeft(indent)}[{startOffset - baseOffset} - {endOffset - baseOffset}] {size,-5} {prefix} {name}";
                string msg = $"    {string.Empty.PadLeft(indent)} {size,-8} {prefix} {name}";
                if (!WriteLogOpened[WriteFileNumber - 1])
                {
                    WriteLogOpened[WriteFileNumber - 1] = true;
                    File.WriteAllLines($"C:/Temp/Write{WriteFileNumber}.log", [msg]);
                }
                else
                {
                    File.AppendAllLines($"C:/Temp/Write{WriteFileNumber}.log", [msg]);
                }
            }
            return (tag.Type.Value is "StructProperty" or "ArrayProperty") ? 2 : 0;
        }
    }
}
