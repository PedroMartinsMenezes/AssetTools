namespace AssetTool
{
    [JsonAsset("VisualLoggerKismetLibrary")]
    public class UVisualLoggerKismetLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}