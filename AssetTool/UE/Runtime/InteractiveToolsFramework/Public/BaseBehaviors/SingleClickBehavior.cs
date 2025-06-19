namespace AssetTool
{
    [JsonAsset("SingleClickInputBehavior")]
    public class USingleClickInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalSingleClickInputBehavior")]
    public class ULocalSingleClickInputBehavior : USingleClickInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}