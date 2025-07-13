namespace AssetTool
{
    [JsonAsset("RivermaxCustomTimeStep")]
    public class URivermaxCustomTimeStep : UGenlockedCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}