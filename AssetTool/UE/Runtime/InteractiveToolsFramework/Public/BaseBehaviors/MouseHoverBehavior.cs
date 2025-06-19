namespace AssetTool
{
    [JsonAsset("MouseHoverBehavior")]
    public class UMouseHoverBehavior : UInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalMouseHoverBehavior")]
    public class ULocalMouseHoverBehavior : UMouseHoverBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}