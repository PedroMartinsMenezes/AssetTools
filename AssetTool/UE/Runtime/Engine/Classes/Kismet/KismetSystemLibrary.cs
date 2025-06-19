namespace AssetTool
{
    [JsonAsset("KismetSystemLibrary")]
    public class UKismetSystemLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}