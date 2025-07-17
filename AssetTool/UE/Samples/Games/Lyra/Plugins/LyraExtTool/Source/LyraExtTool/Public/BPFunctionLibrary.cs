namespace AssetTool
{
    [JsonAsset("BPFunctionLibrary")]
    public class UBPFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}