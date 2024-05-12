namespace AssetTool
{
    [Location("void UShapeComponent::Serialize(FArchive& Ar)")]
    public class UShapeComponent : UPrimitiveComponent
    {
        public new UShapeComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
