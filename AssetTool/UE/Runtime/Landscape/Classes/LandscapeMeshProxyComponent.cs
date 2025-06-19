namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyComponent")]
    public class ULandscapeMeshProxyComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}