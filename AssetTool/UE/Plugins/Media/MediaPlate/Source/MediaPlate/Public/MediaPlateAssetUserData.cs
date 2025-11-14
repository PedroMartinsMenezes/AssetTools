namespace AssetTool
{
    [JsonAsset("MediaPlateAssetUserData")]
    public class UMediaPlateAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}