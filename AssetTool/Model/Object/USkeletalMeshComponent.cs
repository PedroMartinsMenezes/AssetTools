using System.ComponentModel;

namespace AssetTool
{
    [Description("void USkeletalMeshComponent::Serialize(FArchive& Ar)")]
    public class USkeletalMeshComponent : USkinnedMeshComponent
    {
        public new const string TypeName = "SkeletalMeshComponent";
    }

    public static class USkeletalMeshComponentExt
    {
        public static void Write(this BinaryWriter writer, USkeletalMeshComponent item)
        {
            writer.Write((USkinnedMeshComponent)item);
        }

        public static USkeletalMeshComponent Read(this BinaryReader reader, USkeletalMeshComponent item)
        {
            reader.Read((USkinnedMeshComponent)item);
            return item;
        }
    }
}
