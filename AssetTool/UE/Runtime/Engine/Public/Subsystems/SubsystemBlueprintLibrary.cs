namespace AssetTool
{
    [JsonAsset("SubsystemBlueprintLibrary")]
    public class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}