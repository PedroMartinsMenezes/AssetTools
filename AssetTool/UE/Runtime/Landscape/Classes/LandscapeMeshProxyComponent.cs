namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyComponent")]
    public class ULandscapeMeshProxyComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}