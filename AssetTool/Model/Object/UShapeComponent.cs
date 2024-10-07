namespace AssetTool
{
    public class UShapeComponent : UPrimitiveComponent
    {
        [Location("void UShapeComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
