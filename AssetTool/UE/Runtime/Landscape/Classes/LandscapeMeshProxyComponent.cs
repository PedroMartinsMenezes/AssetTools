namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyComponent")]
    public class ULandscapeMeshProxyComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}