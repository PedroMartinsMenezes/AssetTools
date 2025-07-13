namespace AssetTool
{
    [JsonAsset("ConcertTakeSynchronization")]
    public class UConcertTakeSynchronization : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConcertSessionRecordSettings")]
    public class UConcertSessionRecordSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}