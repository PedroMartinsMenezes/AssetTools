namespace AssetTool
{
    [JsonAsset("ConcertClientObjectFactory")]
    public class UConcertClientObjectFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}