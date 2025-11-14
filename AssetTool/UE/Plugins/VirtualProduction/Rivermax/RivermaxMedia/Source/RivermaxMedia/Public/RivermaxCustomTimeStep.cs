namespace AssetTool
{
    [JsonAsset("RivermaxCustomTimeStep")]
    public class URivermaxCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}