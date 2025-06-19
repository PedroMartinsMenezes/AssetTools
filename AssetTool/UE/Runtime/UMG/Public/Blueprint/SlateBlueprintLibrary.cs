namespace AssetTool
{
    [JsonAsset("SlateBlueprintLibrary")]
    public class USlateBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}