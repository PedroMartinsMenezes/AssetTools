namespace AssetTool
{
    [JsonAsset("GenlockedFixedRateCustomTimeStep")]
    public class UGenlockedFixedRateCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}