namespace AssetTool
{
    [JsonAsset("HLODTemplatedInstancedStaticMeshComponent")]
    public class UHLODTemplatedInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}