namespace AssetTool
{
    [JsonAsset("CineSplineMetadata")]
    public class UCineSplineMetadata : USplineMetadata
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}