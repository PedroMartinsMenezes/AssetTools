namespace AssetTool
{
    [JsonAsset("JsonBlueprintFunctionLibrary")]
    public class UJsonBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}