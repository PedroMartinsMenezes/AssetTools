namespace AssetTool
{
    [JsonAsset("LandscapeInfoMap")]
    public class ULandscapeInfoMap : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}