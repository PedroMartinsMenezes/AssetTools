using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UMeshComponent : UPrimitiveComponent
    {
    }

    public static class UMeshComponentExt
    {
        public static void Write(this BinaryWriter writer, UMeshComponent item)
        {
            writer.Write((UPrimitiveComponent)item);
        }

        public static UMeshComponent Read(this BinaryReader reader, UMeshComponent item)
        {
            reader.Read((UPrimitiveComponent)item);
            return item;
        }
    }
}
