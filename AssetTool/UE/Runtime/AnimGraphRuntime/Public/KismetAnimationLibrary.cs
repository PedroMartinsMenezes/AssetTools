namespace AssetTool
{
    [JsonAsset("KismetAnimationLibrary")]
    public class UKismetAnimationLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}