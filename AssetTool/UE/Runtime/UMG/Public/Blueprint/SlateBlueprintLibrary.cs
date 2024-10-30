namespace AssetTool
{
    [JsonAsset("SlateBlueprintLibrary")]
    public class USlateBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}