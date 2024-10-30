namespace AssetTool
{
    [JsonAsset("DataAssetFactory")]
    public class UDataAssetFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}