namespace AssetTool
{
    [JsonAsset("PhysicsDrivenFallingMode")]
    public class UPhysicsDrivenFallingMode : UFallingMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}