namespace AssetTool
{
    [JsonAsset("HLODTemplatedInstancedStaticMeshComponent")]
    public class UHLODTemplatedInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}