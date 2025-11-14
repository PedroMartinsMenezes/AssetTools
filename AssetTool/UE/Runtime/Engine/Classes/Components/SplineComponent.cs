namespace AssetTool
{
    [JsonAsset("SplineMetadata")]
    public class USplineMetadata : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SplineComponent")]
    public class USplineComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}