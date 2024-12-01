namespace AssetTool
{
    [JsonAsset("PhysicsSettingsCore")]
    public class UPhysicsSettingsCore : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}