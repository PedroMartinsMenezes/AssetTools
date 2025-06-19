namespace AssetTool
{
    [JsonAsset("ChaosVehicleWheel")]
    public class UChaosVehicleWheel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}