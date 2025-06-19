namespace AssetTool
{
    [JsonAsset("ContentBundleDescriptor")]
    public class UContentBundleDescriptor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}