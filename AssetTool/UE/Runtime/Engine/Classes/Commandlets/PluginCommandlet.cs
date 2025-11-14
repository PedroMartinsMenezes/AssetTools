namespace AssetTool
{
    [JsonAsset("PluginCommandlet")]
    public class UPluginCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}