namespace AssetTool
{
    [JsonAsset("GenlockedCustomTimeStep")]
    public class UGenlockedCustomTimeStep : UFixedFrameRateCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}