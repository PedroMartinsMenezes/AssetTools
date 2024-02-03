using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void USkinnedMeshComponent::Serialize(FArchive& Ar)")]
    public class USkinnedMeshComponent : UMeshComponent
    {
    }

    public static class USkinnedMeshComponentExt
    {
        public static void Write(this BinaryWriter writer, USkinnedMeshComponent item)
        {
            writer.Write((UMeshComponent)item);
        }

        public static USkinnedMeshComponent Read(this BinaryReader reader, USkinnedMeshComponent item)
        {
            reader.Read((UMeshComponent)item);
            return item;
        }
    }
}
