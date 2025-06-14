namespace AssetTool
{
    [JsonAsset("PhysicsDrivenFlyingMode")]
    public class UPhysicsDrivenFlyingMode : UFlyingMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}