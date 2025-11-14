namespace AssetTool
{
    [JsonAsset("HLODInstancedStaticMeshComponent")]
    public class UHLODInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}