namespace AssetTool
{
    [JsonAsset("TP_VehicleAdvSportsWheelFront")]
    public class UTP_VehicleAdvSportsWheelFront : UTP_VehicleAdvWheelFront
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}