namespace AssetTool
{
    [JsonAsset("LandscapeTextureHash")]
    public class ULandscapeTextureHash : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}