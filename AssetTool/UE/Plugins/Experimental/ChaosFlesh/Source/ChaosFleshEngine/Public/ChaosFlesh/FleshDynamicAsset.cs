namespace AssetTool
{
    [JsonAsset("FleshDynamicAsset")]
    public class UFleshDynamicAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}