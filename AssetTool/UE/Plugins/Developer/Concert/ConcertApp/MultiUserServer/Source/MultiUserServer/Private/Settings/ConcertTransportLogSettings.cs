namespace AssetTool
{
    [JsonAsset("ConcertTransportLogSettings")]
    public class UConcertTransportLogSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}