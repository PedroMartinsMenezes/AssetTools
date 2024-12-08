namespace AssetTool
{
    [JsonAsset("ContentBundleDescriptor")]
    public class UContentBundleDescriptor : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}