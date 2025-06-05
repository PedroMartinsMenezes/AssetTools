namespace AssetTool
{
    [JsonAsset("ChaosVehicleMovementComponent")]
    public class UChaosVehicleMovementComponent : UPawnMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}