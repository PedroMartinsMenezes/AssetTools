namespace AssetTool
{
    [JsonAsset("ConcertClientConfig")]
    public class UConcertClientConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}