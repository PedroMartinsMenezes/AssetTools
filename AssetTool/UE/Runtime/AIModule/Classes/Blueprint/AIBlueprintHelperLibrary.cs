namespace AssetTool
{
    [JsonAsset("AIBlueprintHelperLibrary")]
    public class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}