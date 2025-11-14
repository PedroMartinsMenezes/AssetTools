namespace AssetTool
{
    [JsonAsset("NodalOffsetTool")]
    public class UNodalOffsetTool : UCameraCalibrationStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}