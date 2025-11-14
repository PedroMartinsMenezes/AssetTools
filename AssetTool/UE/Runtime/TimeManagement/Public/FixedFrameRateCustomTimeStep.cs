namespace AssetTool
{
    [JsonAsset("FixedFrameRateCustomTimeStep")]
    public class UFixedFrameRateCustomTimeStep : UEngineCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}