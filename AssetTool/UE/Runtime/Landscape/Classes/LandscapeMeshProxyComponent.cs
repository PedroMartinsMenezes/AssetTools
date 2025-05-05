namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyComponent")]
    public class ULandscapeMeshProxyComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}