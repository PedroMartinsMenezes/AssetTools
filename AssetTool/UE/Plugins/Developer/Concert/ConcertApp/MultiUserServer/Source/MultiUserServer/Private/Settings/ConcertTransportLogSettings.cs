namespace AssetTool
{
    [JsonAsset("ConcertTransportLogSettings")]
    public class UConcertTransportLogSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}