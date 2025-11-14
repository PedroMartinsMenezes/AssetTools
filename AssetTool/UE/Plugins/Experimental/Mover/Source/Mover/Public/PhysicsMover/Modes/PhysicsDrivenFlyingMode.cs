namespace AssetTool
{
    [JsonAsset("PhysicsDrivenFlyingMode")]
    public class UPhysicsDrivenFlyingMode : UFlyingMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}