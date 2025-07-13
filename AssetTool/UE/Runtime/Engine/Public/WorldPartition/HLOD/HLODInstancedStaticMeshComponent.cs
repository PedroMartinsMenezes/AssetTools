namespace AssetTool
{
    [JsonAsset("HLODInstancedStaticMeshComponent")]
    public class UHLODInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}