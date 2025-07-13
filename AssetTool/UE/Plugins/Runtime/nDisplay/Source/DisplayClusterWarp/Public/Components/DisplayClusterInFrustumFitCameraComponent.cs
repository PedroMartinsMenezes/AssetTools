namespace AssetTool
{
    [JsonAsset("DisplayClusterInFrustumFitCameraComponent")]
    public class UDisplayClusterInFrustumFitCameraComponent : UDisplayClusterCameraComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}