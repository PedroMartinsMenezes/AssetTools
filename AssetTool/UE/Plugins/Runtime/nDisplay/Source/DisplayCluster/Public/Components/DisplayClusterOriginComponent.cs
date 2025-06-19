namespace AssetTool
{
    [JsonAsset("DisplayClusterOriginComponent")]
    public class UDisplayClusterOriginComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}