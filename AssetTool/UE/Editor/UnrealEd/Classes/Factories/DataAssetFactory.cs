namespace AssetTool
{
    [JsonAsset("DataAssetFactory")]
    public class UDataAssetFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}