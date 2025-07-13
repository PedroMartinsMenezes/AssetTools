namespace AssetTool
{
    [JsonAsset("ConcertEndpointConfig")]
    public class UConcertEndpointConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}