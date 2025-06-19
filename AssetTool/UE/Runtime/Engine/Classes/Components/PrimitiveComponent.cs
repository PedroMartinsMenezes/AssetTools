namespace AssetTool
{
    [JsonAsset("PrimitiveComponent")]
    public class UPrimitiveComponent : USceneComponent
    {
        [Location("void UPrimitiveComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}