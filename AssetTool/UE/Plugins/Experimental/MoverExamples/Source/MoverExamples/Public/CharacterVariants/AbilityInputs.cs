namespace AssetTool
{
    [JsonAsset("MoverExampleAbilityInputsLibrary")]
    public class UMoverExampleAbilityInputsLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}