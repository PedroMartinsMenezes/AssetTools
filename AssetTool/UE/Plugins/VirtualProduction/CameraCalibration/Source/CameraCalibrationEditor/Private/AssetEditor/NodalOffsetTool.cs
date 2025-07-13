namespace AssetTool
{
    [JsonAsset("NodalOffsetTool")]
    public class UNodalOffsetTool : UCameraCalibrationStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}