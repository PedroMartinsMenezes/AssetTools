using System.ComponentModel;

namespace AssetTool
{
    [Description("void USkeletalMeshComponent::Serialize(FArchive& Ar)")]
    public class USkeletalMeshComponent : USkinnedMeshComponent
    {
        public new const string TypeName = "SkeletalMeshComponent";

        public new USkeletalMeshComponent Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
