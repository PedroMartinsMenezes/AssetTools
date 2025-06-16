namespace AssetTool
{
    [JsonAsset("PCGEngineSettings")]
    public class UPCGEngineSettings : UDeveloperSettingsBackedByCVars
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}