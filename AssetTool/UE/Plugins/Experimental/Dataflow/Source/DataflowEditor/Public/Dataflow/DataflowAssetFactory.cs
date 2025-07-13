namespace AssetTool
{
    [JsonAsset("DataflowAssetFactory")]
    public class UDataflowAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}