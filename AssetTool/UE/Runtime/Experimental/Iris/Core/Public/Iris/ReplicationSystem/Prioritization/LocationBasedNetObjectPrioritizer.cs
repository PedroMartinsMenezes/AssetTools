namespace AssetTool
{
    [JsonAsset("LocationBasedNetObjectPrioritizer")]
    public class ULocationBasedNetObjectPrioritizer : UNetObjectPrioritizer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}