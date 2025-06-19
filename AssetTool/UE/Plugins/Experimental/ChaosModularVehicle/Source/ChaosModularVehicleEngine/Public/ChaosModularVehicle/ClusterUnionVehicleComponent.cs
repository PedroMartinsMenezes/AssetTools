namespace AssetTool
{
    [JsonAsset("ClusterUnionVehicleComponent")]
    public class UClusterUnionVehicleComponent : UClusterUnionComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}