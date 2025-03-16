namespace AssetTool
{
    [JsonAsset("KismetSystemLibrary")]
    public class UKismetSystemLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}