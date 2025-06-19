namespace AssetTool
{
    [JsonAsset("AnyButtonInputBehavior")]
    public class UAnyButtonInputBehavior : UInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}