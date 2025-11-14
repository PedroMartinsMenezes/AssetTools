namespace AssetTool
{
    [JsonAsset("BPFunctionLibrary")]
    public class UBPFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}