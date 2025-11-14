namespace AssetTool
{
    [JsonAsset("ChaosVehicleMovementComponent")]
    public class UChaosVehicleMovementComponent : UPawnMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}