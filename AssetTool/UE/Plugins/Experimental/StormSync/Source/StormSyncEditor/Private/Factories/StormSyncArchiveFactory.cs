namespace AssetTool
{
    [JsonAsset("StormSyncArchiveData")]
    public class UStormSyncArchiveData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StormSyncArchiveFactory")]
    public class UStormSyncArchiveFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}