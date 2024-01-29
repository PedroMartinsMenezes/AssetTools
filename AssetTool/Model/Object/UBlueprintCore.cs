using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UBlueprintCore::Serialize(FArchive& Ar)")]
    public class UBlueprintCore : UObject
    {
    }

    public static class UBlueprintCoreExt
    {
        public static void Write(this BinaryWriter writer, UBlueprintCore item)
        {
            writer.Write((UObject)item);
        }

        public static UBlueprintCore Read(this BinaryReader reader, UBlueprintCore item)
        {
            reader.Read((UObject)item); //68364
            return item; //5134
        }
    }
}
