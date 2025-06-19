namespace AssetTool
{
    [JsonAsset("PluginCommandlet")]
    public class UPluginCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}