namespace AssetTool
{
    [JsonAsset("ChaosWheeledVehicleMovementComponent")]
    public class UChaosWheeledVehicleMovementComponent : UChaosVehicleMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}