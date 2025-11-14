namespace AssetTool
{
    [JsonAsset("MouseWheelInputBehavior")]
    public class UMouseWheelInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}