namespace AssetTool
{
    [JsonAsset("LocationBasedNetObjectPrioritizer")]
    public class ULocationBasedNetObjectPrioritizer : UNetObjectPrioritizer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}