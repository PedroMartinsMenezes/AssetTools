namespace AssetTool
{
    [JsonAsset("ChaosWheeledVehicleMovementComponent")]
    public class UChaosWheeledVehicleMovementComponent : UChaosVehicleMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}