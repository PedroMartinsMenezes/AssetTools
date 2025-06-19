namespace AssetTool
{
    [JsonAsset("ShapeComponent")]
    public class UShapeComponent : UPrimitiveComponent
    {
        [Location("void UShapeComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}