namespace AssetTool
{
    [JsonAsset("SubsystemBlueprintLibrary")]
    public class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}