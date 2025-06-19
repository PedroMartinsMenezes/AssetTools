namespace AssetTool
{
    [JsonAsset("ClusterUnionComponent")]
    public class UClusterUnionComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}