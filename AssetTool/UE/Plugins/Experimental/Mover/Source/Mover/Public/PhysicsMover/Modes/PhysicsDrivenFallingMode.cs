namespace AssetTool
{
    [JsonAsset("PhysicsDrivenFallingMode")]
    public class UPhysicsDrivenFallingMode : UFallingMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}