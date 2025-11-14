namespace AssetTool
{
    [JsonAsset("BinkFunctionLibrary")]
    public class UBinkFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}