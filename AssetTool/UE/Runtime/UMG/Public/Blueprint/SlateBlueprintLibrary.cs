namespace AssetTool
{
    [JsonAsset("SlateBlueprintLibrary")]
    public class USlateBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}