namespace AssetTool
{
    [JsonAsset("VehicleAnimationInstance")]
    public class UVehicleAnimationInstance : UAnimInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}