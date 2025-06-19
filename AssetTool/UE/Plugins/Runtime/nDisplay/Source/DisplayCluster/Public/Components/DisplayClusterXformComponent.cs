namespace AssetTool
{
    [JsonAsset("DisplayClusterXformComponent")]
    public class UDisplayClusterXformComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}