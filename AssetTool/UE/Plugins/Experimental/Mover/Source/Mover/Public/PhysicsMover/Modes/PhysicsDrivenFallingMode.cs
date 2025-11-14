namespace AssetTool
{
    [JsonAsset("PhysicsDrivenFallingMode")]
    public class UPhysicsDrivenFallingMode : UFallingMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}