namespace AssetTool
{
    [JsonAsset("MultiClickSequenceInputBehavior")]
    public class UMultiClickSequenceInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}