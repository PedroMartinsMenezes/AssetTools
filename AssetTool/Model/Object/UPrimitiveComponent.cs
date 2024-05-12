namespace AssetTool
{
    [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UPrimitiveComponent : USceneComponent
    {
        public new UPrimitiveComponent Move(Transfer transfer) => (UPrimitiveComponent)base.Move(transfer);
    }
}
