namespace AssetTool
{
    [JsonAsset("SubobjectDataBlueprintFunctionLibrary")]
    public class USubobjectDataBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}