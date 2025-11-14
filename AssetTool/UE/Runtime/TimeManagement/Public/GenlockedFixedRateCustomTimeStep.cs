namespace AssetTool
{
    [JsonAsset("GenlockedFixedRateCustomTimeStep")]
    public class UGenlockedFixedRateCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}