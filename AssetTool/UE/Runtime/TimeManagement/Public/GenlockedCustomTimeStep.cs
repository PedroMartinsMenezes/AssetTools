namespace AssetTool
{
    [JsonAsset("GenlockedCustomTimeStep")]
    public class UGenlockedCustomTimeStep : UFixedFrameRateCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}