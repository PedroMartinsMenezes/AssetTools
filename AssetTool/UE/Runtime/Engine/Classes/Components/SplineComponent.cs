namespace AssetTool
{
    [JsonAsset("SplineMetadata")]
    public class USplineMetadata : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SplineComponent")]
    public class USplineComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}