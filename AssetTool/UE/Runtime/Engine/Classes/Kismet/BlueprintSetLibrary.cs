namespace AssetTool
{
    [JsonAsset("BlueprintSetLibrary")]
    public class UBlueprintSetLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}