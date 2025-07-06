namespace AssetTool
{
    [JsonAsset("RCControllerContainer")]
    public class URCControllerContainer : URCVirtualPropertyContainerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}