namespace AssetTool
{
    [JsonAsset("JsonObjectGraphFunctionLibrary")]
    public class UJsonObjectGraphFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}