namespace AssetTool
{
    [JsonAsset("VehicleAnimationInstance")]
    public class UVehicleAnimationInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}