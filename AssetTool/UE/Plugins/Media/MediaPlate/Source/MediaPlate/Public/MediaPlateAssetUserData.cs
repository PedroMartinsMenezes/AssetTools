namespace AssetTool
{
    [JsonAsset("MediaPlateAssetUserData")]
    public class UMediaPlateAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}