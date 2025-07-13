namespace AssetTool
{
    [JsonAsset("MobileInstalledContent")]
    public class UMobileInstalledContent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MobilePendingContent")]
    public class UMobilePendingContent : UMobileInstalledContent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MobilePatchingLibrary")]
    public class UMobilePatchingLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}