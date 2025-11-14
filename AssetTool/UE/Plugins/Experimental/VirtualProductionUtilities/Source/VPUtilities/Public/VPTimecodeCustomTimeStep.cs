namespace AssetTool
{
    [JsonAsset("VPTimecodeCustomTimeStep")]
    public class UVPTimecodeCustomTimeStep : UFixedFrameRateCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}