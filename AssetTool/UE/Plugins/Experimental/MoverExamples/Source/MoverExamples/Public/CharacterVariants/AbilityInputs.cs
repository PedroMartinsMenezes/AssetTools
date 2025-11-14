namespace AssetTool
{
    [JsonAsset("MoverExampleAbilityInputsLibrary")]
    public class UMoverExampleAbilityInputsLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}