namespace AssetTool
{
    [JsonAsset("NetTokenDataStream")]
    public class UNetTokenDataStream : UDataStream
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}