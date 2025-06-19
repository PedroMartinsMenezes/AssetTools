namespace AssetTool
{
    [JsonAsset("PCGDeterminismTestBlueprintBase")]
    public class UPCGDeterminismTestBlueprintBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}