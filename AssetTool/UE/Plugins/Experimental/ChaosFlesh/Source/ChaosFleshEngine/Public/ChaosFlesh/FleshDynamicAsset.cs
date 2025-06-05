namespace AssetTool
{
    [JsonAsset("FleshDynamicAsset")]
    public class UFleshDynamicAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}