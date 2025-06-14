namespace AssetTool
{
    [JsonAsset("PhysicsDrivenSwimmingMode")]
    public class UPhysicsDrivenSwimmingMode : USwimmingMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}