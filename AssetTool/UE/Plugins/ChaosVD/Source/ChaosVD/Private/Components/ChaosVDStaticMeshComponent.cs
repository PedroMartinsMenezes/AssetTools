namespace AssetTool
{
    [JsonAsset("ChaosVDStaticMeshComponent")]
    public class UChaosVDStaticMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}