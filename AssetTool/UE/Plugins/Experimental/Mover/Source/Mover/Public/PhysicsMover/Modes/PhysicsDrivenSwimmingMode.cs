namespace AssetTool
{
    [JsonAsset("PhysicsDrivenSwimmingMode")]
    public class UPhysicsDrivenSwimmingMode : USwimmingMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}