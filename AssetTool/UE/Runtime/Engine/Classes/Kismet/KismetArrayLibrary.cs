namespace AssetTool
{
    [JsonAsset("KismetArrayLibrary")]
    public class UKismetArrayLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}