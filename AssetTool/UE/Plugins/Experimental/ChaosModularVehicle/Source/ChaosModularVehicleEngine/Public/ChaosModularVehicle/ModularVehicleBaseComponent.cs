namespace AssetTool
{
    [JsonAsset("ModularVehicleBaseComponent")]
    public class UModularVehicleBaseComponent : UPawnMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}