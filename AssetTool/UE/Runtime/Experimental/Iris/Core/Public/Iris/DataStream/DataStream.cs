namespace AssetTool
{
    [JsonAsset("DataStream")]
    public class UDataStream : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}