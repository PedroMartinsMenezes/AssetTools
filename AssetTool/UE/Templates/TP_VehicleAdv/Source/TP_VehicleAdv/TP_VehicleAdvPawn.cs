namespace AssetTool
{
    [JsonAsset("TP_VehicleAdvPawn")]
    public class ATP_VehicleAdvPawn : AWheeledVehiclePawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}