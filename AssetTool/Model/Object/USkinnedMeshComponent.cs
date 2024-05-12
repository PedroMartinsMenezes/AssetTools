using System.ComponentModel;

namespace AssetTool
{
    [Description("void USkinnedMeshComponent::Serialize(FArchive& Ar)")]
    public class USkinnedMeshComponent : UMeshComponent
    {
        public new USkinnedMeshComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
