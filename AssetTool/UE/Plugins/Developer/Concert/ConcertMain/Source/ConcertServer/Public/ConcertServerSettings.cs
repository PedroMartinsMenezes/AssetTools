namespace AssetTool
{
    [JsonAsset("ConcertServerConfig")]
    public class UConcertServerConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}