namespace AssetTool
{
    [JsonAsset("NetTokenDataStream")]
    public class UNetTokenDataStream : UDataStream
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}