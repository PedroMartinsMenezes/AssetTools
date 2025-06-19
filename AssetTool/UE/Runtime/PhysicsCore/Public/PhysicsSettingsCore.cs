namespace AssetTool
{
    [JsonAsset("PhysicsSettingsCore")]
    public class UPhysicsSettingsCore : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}