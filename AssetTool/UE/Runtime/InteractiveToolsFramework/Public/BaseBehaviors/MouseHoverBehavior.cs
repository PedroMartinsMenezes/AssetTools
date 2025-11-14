namespace AssetTool
{
    [JsonAsset("MouseHoverBehavior")]
    public class UMouseHoverBehavior : UInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalMouseHoverBehavior")]
    public class ULocalMouseHoverBehavior : UMouseHoverBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}