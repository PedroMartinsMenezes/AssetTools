namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerKernel")]
    public class UPCGStaticMeshSpawnerKernel : UPCGComputeKernel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}