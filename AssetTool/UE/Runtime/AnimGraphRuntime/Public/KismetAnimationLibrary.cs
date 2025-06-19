namespace AssetTool
{
    [JsonAsset("KismetAnimationLibrary")]
    public class UKismetAnimationLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}