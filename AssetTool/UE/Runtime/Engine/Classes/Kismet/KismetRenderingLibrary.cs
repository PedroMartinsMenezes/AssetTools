namespace AssetTool
{
    [JsonAsset("KismetRenderingLibrary")]
    public class UKismetRenderingLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}