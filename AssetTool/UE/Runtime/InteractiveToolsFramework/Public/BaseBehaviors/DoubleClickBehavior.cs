namespace AssetTool
{
    [JsonAsset("DoubleClickInputBehavior")]
    public class UDoubleClickInputBehavior : USingleClickInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalDoubleClickInputBehavior")]
    public class ULocalDoubleClickInputBehavior : UDoubleClickInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}