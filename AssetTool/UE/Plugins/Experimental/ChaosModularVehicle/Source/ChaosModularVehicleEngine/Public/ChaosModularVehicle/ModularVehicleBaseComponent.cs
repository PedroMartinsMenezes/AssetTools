namespace AssetTool
{
    [JsonAsset("ModularVehicleBaseComponent")]
    public class UModularVehicleBaseComponent : UPawnMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}