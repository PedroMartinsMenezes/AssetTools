namespace AssetTool
{
    [JsonAsset("KismetRenderingLibrary")]
    public class UKismetRenderingLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}