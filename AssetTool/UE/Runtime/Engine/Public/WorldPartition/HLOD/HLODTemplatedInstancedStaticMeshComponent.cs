namespace AssetTool
{
    [JsonAsset("HLODTemplatedInstancedStaticMeshComponent")]
    public class UHLODTemplatedInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}