namespace AssetTool
{
    [JsonAsset("ConcertTakeSynchronization")]
    public class UConcertTakeSynchronization : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConcertSessionRecordSettings")]
    public class UConcertSessionRecordSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}