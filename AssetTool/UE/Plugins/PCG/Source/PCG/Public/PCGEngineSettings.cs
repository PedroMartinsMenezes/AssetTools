namespace AssetTool
{
    [JsonAsset("PCGEngineSettings")]
    public class UPCGEngineSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}