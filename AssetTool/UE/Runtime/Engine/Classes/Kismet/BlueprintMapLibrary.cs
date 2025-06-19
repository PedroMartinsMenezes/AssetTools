namespace AssetTool
{
    [JsonAsset("BlueprintMapLibrary")]
    public class UBlueprintMapLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}