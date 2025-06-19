namespace AssetTool
{
    [JsonAsset("DisplayClusterCameraComponent")]
    public class UDisplayClusterCameraComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}