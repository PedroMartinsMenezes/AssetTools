namespace AssetTool
{
    [JsonAsset("ModularVehicleBaseComponent")]
    public class UModularVehicleBaseComponent : UPawnMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}