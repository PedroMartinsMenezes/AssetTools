namespace AssetTool
{
    [JsonAsset("TP_VehicleAdvWheelFront")]
    public class UTP_VehicleAdvWheelFront : UChaosVehicleWheel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}