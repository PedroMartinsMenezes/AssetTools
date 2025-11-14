namespace AssetTool
{
    [JsonAsset("LandscapeTextureHash")]
    public class ULandscapeTextureHash : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}