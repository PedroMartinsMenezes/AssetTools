namespace AssetTool
{
    [JsonAsset("MassEQSBlueprintLibrary")]
    public class UMassEQSBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}