namespace AssetTool
{
    [JsonAsset("ChaosVDInstancedStaticMeshComponent")]
    public class UChaosVDInstancedStaticMeshComponent : UInstancedStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}