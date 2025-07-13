namespace AssetTool
{
    [JsonAsset("CineSplineMetadata")]
    public class UCineSplineMetadata : USplineMetadata
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}