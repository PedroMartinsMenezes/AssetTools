namespace AssetTool
{
    [JsonAsset("PhysicsSettings")]
    public class UPhysicsSettings : UPhysicsSettingsCore
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}