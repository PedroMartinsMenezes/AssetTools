namespace AssetTool
{
    [JsonAsset("PhysicsSettingsCore")]
    public class UPhysicsSettingsCore : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}