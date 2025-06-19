namespace AssetTool
{
    [JsonAsset("PhysicsDrivenFlyingMode")]
    public class UPhysicsDrivenFlyingMode : UFlyingMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}