namespace AssetTool
{
    [JsonAsset("KismetStringLibrary")]
    public class UKismetStringLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}