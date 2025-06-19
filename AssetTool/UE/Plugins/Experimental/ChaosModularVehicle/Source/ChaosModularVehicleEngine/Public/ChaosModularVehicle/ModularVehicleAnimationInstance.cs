namespace AssetTool
{
    [JsonAsset("ModularVehicleAnimationInstance")]
    public class UModularVehicleAnimationInstance : UAnimInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}