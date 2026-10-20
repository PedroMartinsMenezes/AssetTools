namespace AssetTool
{
    [JsonAsset("SplineComponent")]
    public class USplineComponent : UPrimitiveComponent
    {
        [Location("void USplineComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
