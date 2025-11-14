namespace AssetTool
{
    [JsonAsset("ClusterUnionVehicleComponent")]
    public class UClusterUnionVehicleComponent : UClusterUnionComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}