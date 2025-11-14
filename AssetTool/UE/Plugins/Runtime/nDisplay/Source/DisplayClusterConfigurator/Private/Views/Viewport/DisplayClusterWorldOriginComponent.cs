namespace AssetTool
{
    [JsonAsset("DisplayClusterWorldOriginComponent")]
    public class UDisplayClusterWorldOriginComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}