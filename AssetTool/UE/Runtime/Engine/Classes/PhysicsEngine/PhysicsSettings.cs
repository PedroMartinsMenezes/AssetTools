namespace AssetTool
{
    [JsonAsset("PhysicsSettings")]
    public class UPhysicsSettings : UPhysicsSettingsCore
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}