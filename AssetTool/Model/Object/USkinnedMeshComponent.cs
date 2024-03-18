using System.ComponentModel;

namespace AssetTool
{
    [Description("void USkinnedMeshComponent::Serialize(FArchive& Ar)")]
    public class USkinnedMeshComponent : UMeshComponent
    {
        public new USkinnedMeshComponent Read(BinaryReader reader)
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
