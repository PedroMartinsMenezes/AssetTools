namespace AssetTool
{
    [JsonAsset("SubsystemBlueprintLibrary")]
    public class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}