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

        public static int Info(BinaryReader reader, int indent, FPropertyTag tag)
        {
            if (reader.BaseStream.Position >= AppConfig.LogStartOffset && reader.BaseStream.Position < AppConfig.LogEndOffset)
            {
                (long startOffset, long endOffset) = (reader.BaseStream.Position, reader.BaseStream.Position + tag.Size);
                (string name, string structName, string type, string innerType, int size) = (tag.Name.Value, tag.StructName?.Value, tag.Type.Value, tag.InnerType?.Value, tag.Size);
                string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
                string prefix = type == "ArrayProperty" ? $"{innerType ?? type}[]" : type == "StructProperty" ? $"{structName ?? innerType}" : $"{type}{arrayIndex}:";
                Log.Info($"    {string.Empty.PadLeft(indent)}[{startOffset} - {endOffset}] {size,-5} {prefix} {name}");
            }
            return (tag.Type.Value is "StructProperty" or "ArrayProperty") ? 2 : 0;
        }
    }
}
