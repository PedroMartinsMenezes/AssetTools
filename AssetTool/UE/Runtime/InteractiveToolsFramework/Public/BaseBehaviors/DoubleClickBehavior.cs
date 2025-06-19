namespace AssetTool
{
    [JsonAsset("DoubleClickInputBehavior")]
    public class UDoubleClickInputBehavior : USingleClickInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalDoubleClickInputBehavior")]
    public class ULocalDoubleClickInputBehavior : UDoubleClickInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}