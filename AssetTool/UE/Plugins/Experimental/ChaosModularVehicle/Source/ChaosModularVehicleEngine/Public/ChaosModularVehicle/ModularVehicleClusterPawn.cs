namespace AssetTool
{
    [JsonAsset("ModularVehicleClusterPawn")]
    public class AModularVehicleClusterPawn : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}