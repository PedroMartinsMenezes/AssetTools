namespace AssetTool
{
    [JsonAsset("RCVirtualPropertyContainerBase")]
    public class URCVirtualPropertyContainerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}