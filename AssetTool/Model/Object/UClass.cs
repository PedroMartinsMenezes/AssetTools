using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UClass::Serialize( FArchive& Ar )")]
    public class UClass : UStruct
    {
    }

    public static class UClassExt
    {
        public static void Write(this BinaryWriter writer, UClass item)
        {
            writer.Write((UStruct)item);
        }

        public static UClass Read(this BinaryReader reader, UClass item)
        {
            reader.Read((UStruct)item);
            return item;
        }
    }
}
