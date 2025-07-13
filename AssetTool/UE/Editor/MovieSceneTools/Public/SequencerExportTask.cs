namespace AssetTool
{
    [JsonAsset("SequencerExportTask")]
    public class USequencerExportTask : UAssetExportTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}