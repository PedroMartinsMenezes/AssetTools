namespace AssetTool
{
    [JsonAsset("DataRegistrySource")]
    public class UDataRegistrySource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaDataRegistrySource")]
    public class UMetaDataRegistrySource : UDataRegistrySource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}