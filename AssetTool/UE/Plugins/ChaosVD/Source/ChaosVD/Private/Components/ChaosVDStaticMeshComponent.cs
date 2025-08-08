namespace AssetTool
{
    [JsonAsset("ChaosVDStaticMeshComponent")]
    public class UChaosVDStaticMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}