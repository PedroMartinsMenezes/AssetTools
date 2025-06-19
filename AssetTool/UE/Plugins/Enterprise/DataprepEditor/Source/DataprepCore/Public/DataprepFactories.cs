namespace AssetTool
{
    [JsonAsset("DataprepAssetFactory")]
    public class UDataprepAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepAssetInstanceFactory")]
    public class UDataprepAssetInstanceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}