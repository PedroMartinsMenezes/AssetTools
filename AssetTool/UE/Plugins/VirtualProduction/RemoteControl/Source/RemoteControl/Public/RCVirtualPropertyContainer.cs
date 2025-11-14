namespace AssetTool
{
    [JsonAsset("RCVirtualPropertyContainerBase")]
    public class URCVirtualPropertyContainerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}