namespace AssetTool
{
    [JsonAsset("SequencerExportTask")]
    public class USequencerExportTask : UAssetExportTask
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}