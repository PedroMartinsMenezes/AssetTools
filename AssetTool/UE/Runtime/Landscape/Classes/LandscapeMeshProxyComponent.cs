namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyComponent")]
    public class ULandscapeMeshProxyComponent : UStaticMeshComponent
    {
        public UInt32 Padding;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Padding);
            return this;
        }
    }
}