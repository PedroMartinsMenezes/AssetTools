namespace AssetTool
{
    [JsonAsset("TimeManagementBlueprintLibrary")]
    public class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}