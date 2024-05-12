namespace AssetTool
{
    [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
    public class UPrimitiveComponent : USceneComponent
    {
        public new UPrimitiveComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
