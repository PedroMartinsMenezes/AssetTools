using System.ComponentModel;

namespace AssetTool
{
    [Description("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UMeshComponent : UPrimitiveComponent
    {
        public new UMeshComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
