namespace AssetTool
{
    [JsonAsset("PluginCommandlet")]
    public class UPluginCommandlet : UCommandlet
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}