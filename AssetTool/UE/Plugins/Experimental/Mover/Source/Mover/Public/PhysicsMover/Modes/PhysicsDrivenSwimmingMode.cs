namespace AssetTool
{
    [JsonAsset("PhysicsDrivenSwimmingMode")]
    public class UPhysicsDrivenSwimmingMode : USwimmingMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}