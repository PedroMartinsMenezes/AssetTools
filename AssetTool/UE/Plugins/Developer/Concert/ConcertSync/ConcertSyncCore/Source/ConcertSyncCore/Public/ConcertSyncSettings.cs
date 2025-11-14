namespace AssetTool
{
    [JsonAsset("ConcertSyncConfig")]
    public class UConcertSyncConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}