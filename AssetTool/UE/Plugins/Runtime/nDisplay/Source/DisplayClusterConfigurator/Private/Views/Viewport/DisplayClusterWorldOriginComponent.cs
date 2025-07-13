namespace AssetTool
{
    [JsonAsset("DisplayClusterWorldOriginComponent")]
    public class UDisplayClusterWorldOriginComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}