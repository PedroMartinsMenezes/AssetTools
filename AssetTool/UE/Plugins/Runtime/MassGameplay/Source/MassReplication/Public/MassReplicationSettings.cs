namespace AssetTool
{
    [JsonAsset("MassReplicationSettings")]
    public class UMassReplicationSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}