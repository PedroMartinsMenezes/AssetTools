namespace AssetTool
{
    [JsonAsset("PCGGraphCompilationData")]
    public class UPCGGraphCompilationData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}