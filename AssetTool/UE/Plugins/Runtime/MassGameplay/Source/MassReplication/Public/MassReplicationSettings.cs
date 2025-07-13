namespace AssetTool
{
    [JsonAsset("MassReplicationSettings")]
    public class UMassReplicationSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}