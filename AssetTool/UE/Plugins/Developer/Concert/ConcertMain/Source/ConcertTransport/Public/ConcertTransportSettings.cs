namespace AssetTool
{
    [JsonAsset("ConcertEndpointConfig")]
    public class UConcertEndpointConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}