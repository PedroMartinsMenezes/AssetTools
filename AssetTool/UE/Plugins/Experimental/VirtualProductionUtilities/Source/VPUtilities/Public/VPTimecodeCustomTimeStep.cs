namespace AssetTool
{
    [JsonAsset("VPTimecodeCustomTimeStep")]
    public class UVPTimecodeCustomTimeStep : UFixedFrameRateCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}