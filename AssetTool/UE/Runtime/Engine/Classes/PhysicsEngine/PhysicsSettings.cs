namespace AssetTool
{
    [JsonAsset("PhysicsSettings")]
    public class UPhysicsSettings : UPhysicsSettingsCore
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}