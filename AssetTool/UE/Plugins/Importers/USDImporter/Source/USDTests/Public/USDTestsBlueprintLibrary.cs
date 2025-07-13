namespace AssetTool
{
    [JsonAsset("SDTestsBlueprintLibrary")]
    public class USDTestsBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}