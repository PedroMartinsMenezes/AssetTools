namespace AssetTool
{
    [JsonAsset("SingleClickInputBehavior")]
    public class USingleClickInputBehavior : UAnyButtonInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalSingleClickInputBehavior")]
    public class ULocalSingleClickInputBehavior : USingleClickInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}