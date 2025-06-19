namespace AssetTool
{
    [JsonAsset("MouseWheelInputBehavior")]
    public class UMouseWheelInputBehavior : UAnyButtonInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}