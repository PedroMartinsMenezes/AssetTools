namespace AssetTool
{
    [JsonAsset("LandscapeInfo")]
    public class ULandscapeInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}