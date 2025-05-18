namespace AssetTool
{
    [JsonAsset("MouseWheelInputBehavior")]
    public class UMouseWheelInputBehavior : UAnyButtonInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}