namespace AssetTool
{
    [JsonAsset("ConcertSyncConfig")]
    public class UConcertSyncConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}