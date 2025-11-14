namespace AssetTool
{
    [JsonAsset("DisplayClusterInFrustumFitCameraComponent")]
    public class UDisplayClusterInFrustumFitCameraComponent : UDisplayClusterCameraComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}