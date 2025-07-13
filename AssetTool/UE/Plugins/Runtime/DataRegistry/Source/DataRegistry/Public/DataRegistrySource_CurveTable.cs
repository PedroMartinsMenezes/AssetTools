namespace AssetTool
{
    [JsonAsset("DataRegistrySource_CurveTable")]
    public class UDataRegistrySource_CurveTable : UDataRegistrySource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaDataRegistrySource_CurveTable")]
    public class UMetaDataRegistrySource_CurveTable : UMetaDataRegistrySource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}