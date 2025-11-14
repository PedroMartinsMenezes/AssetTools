namespace AssetTool
{
    [JsonAsset("VehicleAnimationInstance")]
    public class UVehicleAnimationInstance : UAnimInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}