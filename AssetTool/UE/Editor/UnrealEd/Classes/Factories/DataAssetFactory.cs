namespace AssetTool
{
    [JsonAsset("DataAssetFactory")]
    public class UDataAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}