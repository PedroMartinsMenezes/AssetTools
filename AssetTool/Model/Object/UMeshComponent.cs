using System.ComponentModel;

namespace AssetTool
{
    [Description("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UMeshComponent : UPrimitiveComponent
    {
        public new UMeshComponent Read(BinaryReader reader)
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
