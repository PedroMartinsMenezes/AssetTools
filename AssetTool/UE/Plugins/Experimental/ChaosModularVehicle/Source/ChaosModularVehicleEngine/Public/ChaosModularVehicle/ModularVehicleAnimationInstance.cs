namespace AssetTool
{
    [JsonAsset("ModularVehicleAnimationInstance")]
    public class UModularVehicleAnimationInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}