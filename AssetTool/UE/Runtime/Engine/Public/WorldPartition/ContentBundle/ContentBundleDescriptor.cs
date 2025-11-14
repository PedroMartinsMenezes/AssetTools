namespace AssetTool
{
    [JsonAsset("ContentBundleDescriptor")]
    public class UContentBundleDescriptor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}