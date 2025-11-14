namespace AssetTool
{
    [JsonAsset("SDTestsBlueprintLibrary")]
    public class USDTestsBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}