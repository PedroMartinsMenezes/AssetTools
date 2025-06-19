namespace AssetTool
{
    [JsonAsset("FleshDynamicAsset")]
    public class UFleshDynamicAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}