namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerKernel")]
    public class UPCGStaticMeshSpawnerKernel : UPCGComputeKernel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}