using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
    public class UBlueprintGeneratedClass : USceneComponent
    {
    }

    public static class UBlueprintGeneratedClassExt
    {
        public static void Write(this BinaryWriter writer, UBlueprintGeneratedClass item)
        {
            writer.Write((USceneComponent)item);
        }

        public static UBlueprintGeneratedClass Read(this BinaryReader reader, UBlueprintGeneratedClass item)
        {
            reader.Read((USceneComponent)item);
            return item;
        }
    }
}
