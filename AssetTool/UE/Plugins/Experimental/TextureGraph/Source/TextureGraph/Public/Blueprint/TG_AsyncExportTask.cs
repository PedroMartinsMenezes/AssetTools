namespace AssetTool
{
    [JsonAsset("TG_AsyncExportTask")]
    public class UTG_AsyncExportTask : UTG_AsyncTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}