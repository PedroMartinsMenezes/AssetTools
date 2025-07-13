namespace AssetTool
{
    [JsonAsset("ConcertClientConfig")]
    public class UConcertClientConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}