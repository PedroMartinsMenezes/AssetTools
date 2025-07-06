namespace AssetTool
{
    [JsonAsset("FixedFrameRateCustomTimeStep")]
    public class UFixedFrameRateCustomTimeStep : UEngineCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}