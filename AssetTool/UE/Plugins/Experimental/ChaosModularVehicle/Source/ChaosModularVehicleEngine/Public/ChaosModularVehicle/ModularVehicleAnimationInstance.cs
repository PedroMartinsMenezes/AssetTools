namespace AssetTool
{
    [JsonAsset("ModularVehicleAnimationInstance")]
    public class UModularVehicleAnimationInstance : UAnimInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}