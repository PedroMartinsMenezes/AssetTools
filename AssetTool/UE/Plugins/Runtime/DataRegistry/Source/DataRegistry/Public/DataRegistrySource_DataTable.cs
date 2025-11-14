namespace AssetTool
{
    [JsonAsset("DataRegistrySource_DataTable")]
    public class UDataRegistrySource_DataTable : UDataRegistrySource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaDataRegistrySource_DataTable")]
    public class UMetaDataRegistrySource_DataTable : UMetaDataRegistrySource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}