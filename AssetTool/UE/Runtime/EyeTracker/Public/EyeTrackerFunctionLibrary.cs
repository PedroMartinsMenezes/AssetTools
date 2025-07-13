namespace AssetTool
{
    [JsonAsset("EyeTrackerFunctionLibrary")]
    public class UEyeTrackerFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}