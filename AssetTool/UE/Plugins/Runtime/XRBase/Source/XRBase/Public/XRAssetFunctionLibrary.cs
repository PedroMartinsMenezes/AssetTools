namespace AssetTool
{
    [JsonAsset("XRAssetFunctionLibrary")]
    public class UXRAssetFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncTask_LoadXRDeviceVisComponent")]
    public class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}