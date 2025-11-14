namespace AssetTool
{
    [JsonAsset("EyeTrackerFunctionLibrary")]
    public class UEyeTrackerFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}