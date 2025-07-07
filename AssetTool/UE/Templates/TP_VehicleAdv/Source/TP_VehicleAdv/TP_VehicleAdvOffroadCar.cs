namespace AssetTool
{
    [JsonAsset("TP_VehicleAdvOffroadCar")]
    public class ATP_VehicleAdvOffroadCar : ATP_VehicleAdvPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}