namespace AssetTool
{
    [JsonAsset("PCGEngineSettings")]
    public class UPCGEngineSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}