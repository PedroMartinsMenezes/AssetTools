namespace AssetTool
{
    [JsonAsset("LandscapeInfo")]
    public class ULandscapeInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}