namespace AssetTool
{
    [JsonAsset("ChaosVehicleMovementComponent")]
    public class UChaosVehicleMovementComponent : UPawnMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}