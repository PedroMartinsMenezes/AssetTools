namespace AssetTool
{
    [JsonAsset("KismetRenderingLibrary")]
    public class UKismetRenderingLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}