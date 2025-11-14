namespace AssetTool
{
    [JsonAsset("XRAssetFunctionLibrary")]
    public class UXRAssetFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncTask_LoadXRDeviceVisComponent")]
    public class UAsyncTask_LoadXRDeviceVisComponent : UBlueprintAsyncActionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}