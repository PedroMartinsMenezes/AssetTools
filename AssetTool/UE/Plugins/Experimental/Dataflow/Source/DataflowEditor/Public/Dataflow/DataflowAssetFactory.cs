namespace AssetTool
{
    [JsonAsset("DataflowAssetFactory")]
    public class UDataflowAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}