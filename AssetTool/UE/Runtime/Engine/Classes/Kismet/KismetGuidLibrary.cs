namespace AssetTool
{
    [JsonAsset("KismetGuidLibrary")]
    public class UKismetGuidLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}