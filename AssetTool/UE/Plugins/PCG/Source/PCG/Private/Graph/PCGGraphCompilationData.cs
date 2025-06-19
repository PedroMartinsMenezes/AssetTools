namespace AssetTool
{
    [JsonAsset("PCGGraphCompilationData")]
    public class UPCGGraphCompilationData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}