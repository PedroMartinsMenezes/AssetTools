namespace AssetTool
{
    [JsonAsset("SequencerPivotToolBuilder")]
    public class USequencerPivotToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SequencerPivotTool")]
    public class USequencerPivotTool : UMultiSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}